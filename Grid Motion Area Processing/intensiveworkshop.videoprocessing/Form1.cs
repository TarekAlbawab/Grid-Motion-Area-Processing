using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;


namespace intensiveworkshop.videoprocessing
{
    public partial class Form1 : Form
    {
        private readonly MotionDetector _detector;
        private readonly List<string> _historyList; //global variable to be accessable to other loops
        int count = 1;
        private readonly GridMotionAreaProcessing _gridMotionAreaProcessing;
        public Form1()
        {
            InitializeComponent();        
            _detector = new MotionDetector(new SimpleBackgroundModelingDetector(), new MotionAreaHighlighting(Color.Purple));    
            _historyList = new List<string>();
        }


        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                var videoSource = new FileVideoSource(openFileDialog.FileName);

                OpenVideoSource(videoSource);
            }
            }

        private void OpenVideoSource(IVideoSource source)
        {
            Cursor = Cursors.WaitCursor;

            CloseCurrentVideoSource();//if you insert multiple times it will close the first one

            videoSourcePlayerInput.VideoSource = source; 
            videoSourcePlayerInput.Start();
            Cursor = Cursors.Default;
        }

        private void CloseCurrentVideoSource()
        {
            if (videoSourcePlayerInput.VideoSource != null)
            {
                videoSourcePlayerInput.SignalToStop();
                for (var i = 0; i < 30; i++)
                {
                    if (!videoSourcePlayerInput.IsRunning)
                    {
                        break;
                    }
                }
                if (videoSourcePlayerInput.IsRunning)
                {
                    videoSourcePlayerInput.Stop();

                }
                videoSourcePlayerInput.VideoSource = null;
            }
        }

        private void videoSourcePlayerInput_NewFrame(object sender, ref Bitmap image)//it enables the processing in the video that is in the video box
  // it breaks the video into images 
        {
            var motionlevel = _detector.ProcessFrame(image);//motion level is threshold
            var dateTime = DateTime.Now;
            float i = image.Width;
            float j = image.Height;
            if (motionlevel > 0.05)
            {
                var historyString = "There was a motion at" + dateTime.ToString() + count.ToString();
                _historyList.Add(historyString);
            }
           
            var g = Graphics.FromImage(image);
            var font = new Font(FontFamily.GenericSerif, 30);
            var brush = new SolidBrush(Color.Red);
            var pen = new SolidBrush(Color.Beige);                    
            g.DrawString(dateTime.ToString(),  font, brush, new PointF(5, 5));
            g.DrawString(count.ToString(),  font, brush, new PointF(40, 40));
            brush.Dispose();
            g.Dispose();
            count ++;
            

        }

        private void buttonHistory_Click(object sender, EventArgs e)//event loop
        {
            listBoxHistory.DataSource = _historyList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

