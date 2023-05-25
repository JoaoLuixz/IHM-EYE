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
    public partial class Configs : Form
    {
        EyeBlink BlinkChange;
        public Configs()
        {
            InitializeComponent();
            BlinkChange = new EyeBlink();
        }
        public Configs(EyeBlink blinkForm)
        {
            InitializeComponent();
            this.BlinkChange = blinkForm;
        }
        private void btnConfigsUp_Click(object sender, EventArgs e) // Botão UP
        {
            BlinkChange.MoveYUp();
        }
        private void btnConfigsDown_Click(object sender, EventArgs e) // Botão DOWN
        {
            BlinkChange.MoveYDown();
        }
        private void btnConfigsLeft_Click(object sender, EventArgs e) // Botão LEFT
        {
            BlinkChange.MoveXLeft();
        }
        private void btnConfigsRight_Click(object sender, EventArgs e) // Botão RIGHT
        {
            BlinkChange.MoveXRight();

        }
        
    }
}
