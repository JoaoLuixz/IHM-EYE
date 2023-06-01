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
        MainFormEye MainEyeTime;
        System.Windows.Forms.Timer TimerChange;
        public Configs()
        {
            InitializeComponent();
            BlinkChange = new EyeBlink();
            this.KeyPreview = true;
            this.KeyDown += Configs_KeyDown;

        }
        public Configs(EyeBlink blinkForm, MainFormEye Time)
        {
            InitializeComponent();
            this.BlinkChange = blinkForm;
            this.MainEyeTime = Time;
            TimerChange = MainEyeTime.timer;
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
        private void Configs_KeyDown(object sender, KeyEventArgs e) // tentativa de mover com as setas do teclado
        {
            if (e.KeyCode == Keys.Up)
            {
                BlinkChange.MoveYUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                BlinkChange.MoveYDown();

            }
            if (e.KeyCode == Keys.Left)
            {
                BlinkChange.MoveXLeft();

            }
            if (e.KeyCode == Keys.Right)
            {
                BlinkChange.MoveXRight();
            }
        }

        private void Configs_Load(object sender, EventArgs e)
        {
            lbConfigsTimeBlink.Text = $"{MainEyeTime.BlinkTime}s";
        }

        private void btnConfigsTimeBlinkLeft_Click(object sender, EventArgs e)
        {
            if (MainEyeTime.BlinkTime > 1)
            {
                MainEyeTime.BlinkTime--;
                lbConfigsTimeBlink.Text = $"{MainEyeTime.BlinkTime}s";
                TimerChange.Interval = MainEyeTime.BlinkTime * 1000;
            }
            else
            {
                MessageBox.Show("Limite de 1s atingido");
            }

        }

        private void btnConfigsTimeBlinkRight_Click(object sender, EventArgs e)
        {
            if (MainEyeTime.BlinkTime < 10)
            {
                MainEyeTime.BlinkTime++;
                lbConfigsTimeBlink.Text = $"{MainEyeTime.BlinkTime}s";
                TimerChange.Interval = MainEyeTime.BlinkTime * 1000;
            }
            else
            {
                MessageBox.Show("Limite de 10s atingido");
            }
        }

        private void lbConfigsTimeBlink_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPanelTopMiddle_Click(object sender, EventArgs e)
        {
            //Screen.PrimaryScreen.WorkingArea.Width - localizacaoX, Screen.PrimaryScreen.WorkingArea.Height - this.Width - localizacaoY;
            BlinkChange.MoveToTopMiddle();
        }

        private void btnPanelTopRight_Click(object sender, EventArgs e)
        {
            BlinkChange.MoveToTopRight();
        }

        private void btnPanelRight_Click(object sender, EventArgs e)
        {
            BlinkChange.MoveToRight();
        }

        private void btnPanelBottomRight_Click(object sender, EventArgs e)
        {
            BlinkChange.MoveToBottomRight();
        }

        private void btnPanelBottom_Click(object sender, EventArgs e)
        {
            BlinkChange.MoveToBottom();
        }

        private void btnPanelBottomLeft_Click(object sender, EventArgs e)
        {
            BlinkChange.MoveToBottomLeft();
        }

        private void btnPanelLeft_Click(object sender, EventArgs e)
        {
            BlinkChange.MoveToLeft();
        }

        private void btnPanelTopLeft_Click(object sender, EventArgs e)
        {
            BlinkChange.MoveToTopLeft();
        }

        private void btnPanelMiddle_Click_1(object sender, EventArgs e)
        {
            BlinkChange.MoveToMiddle();
        }

        private void toolTipConfigsPanel_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}
