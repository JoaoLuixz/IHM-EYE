namespace Eye
{
    partial class MainFormEye
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormEye));
            btnStart = new Button();
            pictureBoxMainFormEye = new PictureBox();
            btnStop = new Button();
            btnResume = new Button();
            pictureBoxMainFormEye2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainFormEye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainFormEye2).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Location = new Point(266, 511);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 36);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBoxMainFormEye
            // 
            pictureBoxMainFormEye.Image = (Image)resources.GetObject("pictureBoxMainFormEye.Image");
            pictureBoxMainFormEye.Location = new Point(172, 186);
            pictureBoxMainFormEye.Name = "pictureBoxMainFormEye";
            pictureBoxMainFormEye.Size = new Size(355, 241);
            pictureBoxMainFormEye.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMainFormEye.TabIndex = 1;
            pictureBoxMainFormEye.TabStop = false;
            pictureBoxMainFormEye.Click += pictureBox1_Click;
            // 
            // btnStop
            // 
            btnStop.FlatStyle = FlatStyle.Popup;
            btnStop.Location = new Point(291, 553);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(102, 31);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnResume
            // 
            btnResume.FlatStyle = FlatStyle.Popup;
            btnResume.Location = new Point(291, 553);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(102, 31);
            btnResume.TabIndex = 3;
            btnResume.Text = "Resume";
            btnResume.UseVisualStyleBackColor = true;
            btnResume.Click += btnResume_Click;
            // 
            // pictureBoxMainFormEye2
            // 
            pictureBoxMainFormEye2.Image = (Image)resources.GetObject("pictureBoxMainFormEye2.Image");
            pictureBoxMainFormEye2.Location = new Point(172, 186);
            pictureBoxMainFormEye2.Name = "pictureBoxMainFormEye2";
            pictureBoxMainFormEye2.Size = new Size(355, 241);
            pictureBoxMainFormEye2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMainFormEye2.TabIndex = 4;
            pictureBoxMainFormEye2.TabStop = false;
            pictureBoxMainFormEye2.Click += pictureBoxMainFormEye2_Click;
            // 
            // MainFormEye
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(699, 642);
            Controls.Add(pictureBoxMainFormEye2);
            Controls.Add(btnResume);
            Controls.Add(btnStop);
            Controls.Add(pictureBoxMainFormEye);
            Controls.Add(btnStart);
            Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainFormEye";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eye";
            Load += MainFormEye_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainFormEye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainFormEye2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private PictureBox pictureBoxMainFormEye;
        private Button btnStop;
        private Button btnResume;
        private PictureBox pictureBoxMainFormEye2;
    }
}