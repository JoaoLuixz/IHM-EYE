namespace Eye
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            pictureBoxEyeSobre = new PictureBox();
            lbSobre = new Label();
            lbSobreData = new Label();
            lbSobreTitleBlink = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEyeSobre).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxEyeSobre
            // 
            pictureBoxEyeSobre.Image = (Image)resources.GetObject("pictureBoxEyeSobre.Image");
            pictureBoxEyeSobre.Location = new Point(12, 167);
            pictureBoxEyeSobre.Name = "pictureBoxEyeSobre";
            pictureBoxEyeSobre.Size = new Size(112, 117);
            pictureBoxEyeSobre.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEyeSobre.TabIndex = 2;
            pictureBoxEyeSobre.TabStop = false;
            // 
            // lbSobre
            // 
            lbSobre.AutoSize = true;
            lbSobre.Location = new Point(152, 209);
            lbSobre.Name = "lbSobre";
            lbSobre.Size = new Size(217, 44);
            lbSobre.TabIndex = 3;
            lbSobre.Text = "João Luiz Martins Neto\r\n218719";
            lbSobre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSobreData
            // 
            lbSobreData.AutoSize = true;
            lbSobreData.Location = new Point(97, 471);
            lbSobreData.Name = "lbSobreData";
            lbSobreData.Size = new Size(177, 22);
            lbSobreData.TabIndex = 4;
            lbSobreData.Text = "Projeto IHM - 2023";
            lbSobreData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSobreTitleBlink
            // 
            lbSobreTitleBlink.Font = new Font("Arial Rounded MT Bold", 69.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbSobreTitleBlink.Location = new Point(23, 9);
            lbSobreTitleBlink.Name = "lbSobreTitleBlink";
            lbSobreTitleBlink.Size = new Size(346, 143);
            lbSobreTitleBlink.TabIndex = 5;
            lbSobreTitleBlink.Text = "Blink👁‍🗨";
            lbSobreTitleBlink.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Sobre
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(381, 502);
            Controls.Add(lbSobreTitleBlink);
            Controls.Add(lbSobreData);
            Controls.Add(lbSobre);
            Controls.Add(pictureBoxEyeSobre);
            Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Sobre";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre";
            Load += Sobre_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxEyeSobre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxEyeSobre;
        private Label lbSobre;
        private Label lbSobreData;
        public Label lbSobreTitleBlink;
    }
}