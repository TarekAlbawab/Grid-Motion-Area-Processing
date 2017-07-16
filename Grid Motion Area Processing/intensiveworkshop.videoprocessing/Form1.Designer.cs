namespace intensiveworkshop.videoprocessing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoSourcePlayerInput = new AForge.Controls.VideoSourcePlayer();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoSourcePlayerInput
            // 
            this.videoSourcePlayerInput.Location = new System.Drawing.Point(12, 9);
            this.videoSourcePlayerInput.Name = "videoSourcePlayerInput";
            this.videoSourcePlayerInput.Size = new System.Drawing.Size(557, 486);
            this.videoSourcePlayerInput.TabIndex = 0;
            this.videoSourcePlayerInput.Text = "videoSourcePlayer1";
            this.videoSourcePlayerInput.VideoSource = null;
            this.videoSourcePlayerInput.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayerInput_NewFrame);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(215, 501);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(171, 59);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Text = "INSERT VIDEO";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(575, 9);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(377, 459);
            this.listBoxHistory.TabIndex = 2;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(691, 501);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(197, 59);
            this.buttonHistory.TabIndex = 3;
            this.buttonHistory.Text = "HISTORY";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 583);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.videoSourcePlayerInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayerInput;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Button buttonHistory;
    }
}

