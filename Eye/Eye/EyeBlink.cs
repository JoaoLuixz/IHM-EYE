using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eye
{
    public partial class EyeBlink : Form
    {
        public int localizacaoX { get; set; }
        public int localizacaoY { get; set; }
        public EyeBlink()
        {
            InitializeComponent();
            localizacaoX = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            localizacaoY = (Screen.PrimaryScreen.WorkingArea.Height - this.Width) / 2;
        }

        private void EyeBlink_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // cor de fundo
            this.TransparencyKey = Color.White; // define qual cor deve ser transparente
            this.TopMost = true; // Torna o formulátio sempre visível
            //this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 5); // Define a posição no canto superior direito
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - localizacaoX, Screen.PrimaryScreen.WorkingArea.Height - this.Width - localizacaoY);
            this.FormBorderStyle = FormBorderStyle.None; // Remove borda
            this.Opacity = 0.5;
        }
        public void MoveXRight() // Método move formuláio para a direita
        {
            localizacaoX = localizacaoX + 75;
            this.Location = new Point(localizacaoX, this.Location.Y);
        }
        public void MoveXLeft() // Método move formuláio para a esquerda
        {
            localizacaoX = localizacaoX - 75;
            this.Location = new Point(localizacaoX, this.Location.Y);
        }
        public void MoveYDown() // Método move formuláio para baixo
        {
            localizacaoY = localizacaoY + 75;
            this.Location = new Point(this.Location.X, localizacaoY);

        }
        public void MoveYUp() // Método move formuláio para cima
        {
            localizacaoY = localizacaoY - 75;
            this.Location = new Point(this.Location.X, localizacaoY);

        }

        private void pictureBoxEyeBlink_Click(object sender, EventArgs e)
        {

        }

        public void ShowEye()
        {
            pictureBoxEyeBlink.Visible = true; // Mostra picture box
            pictureBoxEyeBlink2.Visible = false;
        }

        public void HideEye()
        {
            pictureBoxEyeBlink.Visible = false; // Esconde picture box
            pictureBoxEyeBlink2.Visible = true;

        }


    }

}

