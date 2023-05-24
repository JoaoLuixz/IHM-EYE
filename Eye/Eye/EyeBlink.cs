using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eye
{
    public partial class EyeBlink : Form
    {
        public EyeBlink()
        {
            InitializeComponent();
        }

        private void EyeBlink_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(128, 255, 255, 255); // Define a cor de fundo translúcida
            //this.TransparencyKey = Color.FromArgb(128, 255, 255, 255); // Define a cor transparente
            //this.TopMost = true; // Torna o formulário sempre visível no topo
            //this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0); // Define a posição no canto superior direito

            this.BackColor = Color.White; // Define a cor de fundo
            this.TransparencyKey = Color.White; // Define a cor transparente
            this.TopMost = false; // Torna o formulário sempre visível no topo
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0); // Define a posição no canto superior direito
            this.FormBorderStyle = FormBorderStyle.None; // Remove a borda do formulário
            this.Opacity = 0.5; // Define a opacidade desejada (0.0 - 1.0)
        }

        private void pictureBoxEyeBlink_Click(object sender, EventArgs e)
        {

        }
    }

}

