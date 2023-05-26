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
            menuStripMainForm = new MenuStrip();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainFormEye).BeginInit();
            menuStripMainForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Location = new Point(273, 511);
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
            pictureBoxMainFormEye.Location = new Point(172, 168);
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
            btnStop.Location = new Point(298, 553);
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
            btnResume.Location = new Point(298, 553);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(102, 31);
            btnResume.TabIndex = 3;
            btnResume.Text = "Resume";
            btnResume.UseVisualStyleBackColor = true;
            btnResume.Click += btnResume_Click;
            // 
            // menuStripMainForm
            // 
            menuStripMainForm.BackColor = SystemColors.ControlDark;
            menuStripMainForm.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStripMainForm.Items.AddRange(new ToolStripItem[] { configuraçõesToolStripMenuItem, sobreToolStripMenuItem });
            menuStripMainForm.Location = new Point(0, 0);
            menuStripMainForm.Name = "menuStripMainForm";
            menuStripMainForm.Size = new Size(699, 24);
            menuStripMainForm.TabIndex = 5;
            menuStripMainForm.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(104, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += configuraçõesToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(54, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // MainFormEye
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(699, 642);
            Controls.Add(btnResume);
            Controls.Add(btnStop);
            Controls.Add(pictureBoxMainFormEye);
            Controls.Add(btnStart);
            Controls.Add(menuStripMainForm);
            Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMainForm;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "MainFormEye";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blink";
            Load += MainFormEye_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainFormEye).EndInit();
            menuStripMainForm.ResumeLayout(false);
            menuStripMainForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private PictureBox pictureBoxMainFormEye;
        private Button btnStop;
        private Button btnResume;
        private MenuStrip menuStripMainForm;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}