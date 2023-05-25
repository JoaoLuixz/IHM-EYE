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
            // Configs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(406, 450);
            Controls.Add(btnConfigsUp);
            Controls.Add(btnConfigsRight);
            Controls.Add(btnConfigsLeft);
            Controls.Add(btnConfigsDown);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "Configs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configs";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConfigsUp;
        private Button btnConfigsDown;
        private Button btnConfigsRight;
        private Button btnConfigsLeft;
    }
}