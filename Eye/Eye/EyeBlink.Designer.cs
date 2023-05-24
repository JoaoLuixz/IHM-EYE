namespace Eye
{
    partial class EyeBlink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EyeBlink));
            pictureBoxEyeBlink = new PictureBox();
            pictureBoxEyeBlink2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEyeBlink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEyeBlink2).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxEyeBlink
            // 
            pictureBoxEyeBlink.Dock = DockStyle.Fill;
            pictureBoxEyeBlink.Image = (Image)resources.GetObject("pictureBoxEyeBlink.Image");
            pictureBoxEyeBlink.Location = new Point(0, 0);
            pictureBoxEyeBlink.Name = "pictureBoxEyeBlink";
            pictureBoxEyeBlink.Size = new Size(83, 71);
            pictureBoxEyeBlink.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEyeBlink.TabIndex = 0;
            pictureBoxEyeBlink.TabStop = false;
            pictureBoxEyeBlink.Click += pictureBoxEyeBlink_Click;
            // 
            // pictureBoxEyeBlink2
            // 
            pictureBoxEyeBlink2.Dock = DockStyle.Fill;
            pictureBoxEyeBlink2.Image = (Image)resources.GetObject("pictureBoxEyeBlink2.Image");
            pictureBoxEyeBlink2.Location = new Point(0, 0);
            pictureBoxEyeBlink2.Name = "pictureBoxEyeBlink2";
            pictureBoxEyeBlink2.Size = new Size(83, 71);
            pictureBoxEyeBlink2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEyeBlink2.TabIndex = 1;
            pictureBoxEyeBlink2.TabStop = false;
            // 
            // EyeBlink
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(83, 71);
            Controls.Add(pictureBoxEyeBlink2);
            Controls.Add(pictureBoxEyeBlink);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EyeBlink";
            Text = "EyeBlink";
            Load += EyeBlink_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxEyeBlink).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEyeBlink2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxEyeBlink;
        private PictureBox pictureBoxEyeBlink2;
    }
}