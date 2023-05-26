namespace Eye
{
    partial class Configs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configs));
            btnConfigsUp = new Button();
            btnConfigsDown = new Button();
            btnConfigsRight = new Button();
            btnConfigsLeft = new Button();
            btnConfigsTimeBlinkLeft = new Button();
            btnConfigsTimeBlinkRight = new Button();
            lbConfigsTimeBlink = new Label();
            lbConfigsTimer = new Label();
            SuspendLayout();
            // 
            // btnConfigsUp
            // 
            btnConfigsUp.BackColor = SystemColors.AppWorkspace;
            btnConfigsUp.BackgroundImage = (Image)resources.GetObject("btnConfigsUp.BackgroundImage");
            btnConfigsUp.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfigsUp.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnConfigsUp.ForeColor = SystemColors.ControlDark;
            btnConfigsUp.Location = new Point(182, 288);
            btnConfigsUp.Name = "btnConfigsUp";
            btnConfigsUp.Size = new Size(32, 66);
            btnConfigsUp.TabIndex = 0;
            btnConfigsUp.UseVisualStyleBackColor = false;
            btnConfigsUp.Click += btnConfigsUp_Click;
            // 
            // btnConfigsDown
            // 
            btnConfigsDown.BackColor = SystemColors.AppWorkspace;
            btnConfigsDown.BackgroundImage = (Image)resources.GetObject("btnConfigsDown.BackgroundImage");
            btnConfigsDown.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfigsDown.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnConfigsDown.ForeColor = SystemColors.ControlDark;
            btnConfigsDown.Location = new Point(182, 375);
            btnConfigsDown.Name = "btnConfigsDown";
            btnConfigsDown.Size = new Size(32, 66);
            btnConfigsDown.TabIndex = 1;
            btnConfigsDown.UseVisualStyleBackColor = false;
            btnConfigsDown.Click += btnConfigsDown_Click;
            // 
            // btnConfigsRight
            // 
            btnConfigsRight.BackColor = SystemColors.AppWorkspace;
            btnConfigsRight.BackgroundImage = (Image)resources.GetObject("btnConfigsRight.BackgroundImage");
            btnConfigsRight.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfigsRight.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnConfigsRight.ForeColor = SystemColors.ControlDark;
            btnConfigsRight.Location = new Point(207, 347);
            btnConfigsRight.Name = "btnConfigsRight";
            btnConfigsRight.Size = new Size(66, 32);
            btnConfigsRight.TabIndex = 2;
            btnConfigsRight.UseVisualStyleBackColor = false;
            btnConfigsRight.Click += btnConfigsRight_Click;
            // 
            // btnConfigsLeft
            // 
            btnConfigsLeft.BackColor = SystemColors.AppWorkspace;
            btnConfigsLeft.BackgroundImage = (Image)resources.GetObject("btnConfigsLeft.BackgroundImage");
            btnConfigsLeft.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfigsLeft.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnConfigsLeft.ForeColor = SystemColors.ControlDark;
            btnConfigsLeft.Location = new Point(121, 347);
            btnConfigsLeft.Name = "btnConfigsLeft";
            btnConfigsLeft.Size = new Size(66, 32);
            btnConfigsLeft.TabIndex = 4;
            btnConfigsLeft.UseVisualStyleBackColor = false;
            btnConfigsLeft.Click += btnConfigsLeft_Click;
            // 
            // btnConfigsTimeBlinkLeft
            // 
            btnConfigsTimeBlinkLeft.BackColor = SystemColors.AppWorkspace;
            btnConfigsTimeBlinkLeft.BackgroundImage = (Image)resources.GetObject("btnConfigsTimeBlinkLeft.BackgroundImage");
            btnConfigsTimeBlinkLeft.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfigsTimeBlinkLeft.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnConfigsTimeBlinkLeft.ForeColor = SystemColors.ControlDark;
            btnConfigsTimeBlinkLeft.Location = new Point(121, 102);
            btnConfigsTimeBlinkLeft.Name = "btnConfigsTimeBlinkLeft";
            btnConfigsTimeBlinkLeft.Size = new Size(66, 32);
            btnConfigsTimeBlinkLeft.TabIndex = 5;
            btnConfigsTimeBlinkLeft.UseVisualStyleBackColor = false;
            btnConfigsTimeBlinkLeft.Click += btnConfigsTimeBlinkLeft_Click;
            // 
            // btnConfigsTimeBlinkRight
            // 
            btnConfigsTimeBlinkRight.BackColor = SystemColors.AppWorkspace;
            btnConfigsTimeBlinkRight.BackgroundImage = (Image)resources.GetObject("btnConfigsTimeBlinkRight.BackgroundImage");
            btnConfigsTimeBlinkRight.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfigsTimeBlinkRight.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnConfigsTimeBlinkRight.ForeColor = SystemColors.ControlDark;
            btnConfigsTimeBlinkRight.Location = new Point(207, 102);
            btnConfigsTimeBlinkRight.Name = "btnConfigsTimeBlinkRight";
            btnConfigsTimeBlinkRight.Size = new Size(66, 32);
            btnConfigsTimeBlinkRight.TabIndex = 6;
            btnConfigsTimeBlinkRight.UseVisualStyleBackColor = false;
            btnConfigsTimeBlinkRight.Click += btnConfigsTimeBlinkRight_Click;
            // 
            // lbConfigsTimeBlink
            // 
            lbConfigsTimeBlink.AccessibleRole = AccessibleRole.None;
            lbConfigsTimeBlink.AutoSize = true;
            lbConfigsTimeBlink.BackColor = Color.Transparent;
            lbConfigsTimeBlink.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbConfigsTimeBlink.ForeColor = SystemColors.ActiveCaptionText;
            lbConfigsTimeBlink.Location = new Point(186, 59);
            lbConfigsTimeBlink.Name = "lbConfigsTimeBlink";
            lbConfigsTimeBlink.Size = new Size(63, 25);
            lbConfigsTimeBlink.TabIndex = 7;
            lbConfigsTimeBlink.Text = "Time";
            lbConfigsTimeBlink.TextAlign = ContentAlignment.MiddleRight;
            lbConfigsTimeBlink.Click += lbConfigsTimeBlink_Click;
            // 
            // lbConfigsTimer
            // 
            lbConfigsTimer.AccessibleRole = AccessibleRole.None;
            lbConfigsTimer.AutoSize = true;
            lbConfigsTimer.BackColor = Color.Transparent;
            lbConfigsTimer.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbConfigsTimer.ForeColor = SystemColors.ActiveCaptionText;
            lbConfigsTimer.Location = new Point(121, 20);
            lbConfigsTimer.Name = "lbConfigsTimer";
            lbConfigsTimer.Size = new Size(157, 25);
            lbConfigsTimer.TabIndex = 8;
            lbConfigsTimer.Text = "Temporizador";
            lbConfigsTimer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Configs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(406, 450);
            Controls.Add(lbConfigsTimer);
            Controls.Add(lbConfigsTimeBlink);
            Controls.Add(btnConfigsTimeBlinkRight);
            Controls.Add(btnConfigsTimeBlinkLeft);
            Controls.Add(btnConfigsUp);
            Controls.Add(btnConfigsRight);
            Controls.Add(btnConfigsLeft);
            Controls.Add(btnConfigsDown);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Configs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configs";
            Load += Configs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfigsUp;
        private Button btnConfigsDown;
        private Button btnConfigsRight;
        private Button btnConfigsLeft;
        private Button btnConfigsTimeBlinkLeft;
        private Button btnConfigsTimeBlinkRight;
        private Label lbConfigsTimeBlink;
        private Label lbConfigsTimer;
    }
}