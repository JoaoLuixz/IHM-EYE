namespace Eye
{
    public partial class MainFormEye : Form
    {
        MainFormEye MainEyeForm;
        Configs ConfigForm;
        Sobre SobreForm;
        private EyeBlink blink; //eyeForm
        public System.Windows.Forms.Timer timer;
        private bool shouldBlink = false;
        public int BlinkTime { get; set; }



        public MainFormEye()
        {
            InitializeComponent();
            BlinkTime = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Visible = true;

            if (blink == null)
            {
                blink = new EyeBlink();
                blink.Show();
                timer = new System.Windows.Forms.Timer();
                if (BlinkTime == 1) // condição para que, qundo o Form inicar, não piscar fora do tempo.
                {
                    timer.Interval = 1000;
                }
                else
                {
                    timer.Interval = BlinkTime; // Intervalo em ms (padrão 1000ms)
                }
                timer.Tick += Timer_Tick;
                timer.Start();

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            shouldBlink = !shouldBlink;

            if (shouldBlink)
            {
                blink.ShowEye();
            }
            else
            {
                blink.HideEye();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            blink.Visible = false;
            btnStop.Visible = false;
            btnResume.Visible = true;


        }

        private void MainFormEye_Load(object sender, EventArgs e)
        {
            btnResume.Visible = false;
            btnStop.Visible = false;

        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            timer.Start();
            blink.Visible = true;
            btnResume.Visible = false;
            btnStop.Visible = true;
        }

        private void pictureBoxMainFormEye2_Click(object sender, EventArgs e)
        {

        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (blink == null)
            {
                MessageBox.Show("É necessário apertar 'START' primeiro!");
            }
            else
            {
                if (ConfigForm == null)
                {
                    ConfigForm = new Configs(blink, this);
                    ConfigForm.ShowDialog();
                    resetConfig();
                }
                else
                {
                    ConfigForm.Activate();
                }
            }

        }
        private void resetConfig()
        {
            ConfigForm = null; // Reseta o formuláio, atribuindo null ao mesmo para que possa ser aberto novamente;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SobreForm == null)
            {
                SobreForm = new Sobre();
                SobreForm.ShowDialog();
                resetSobre();
            }
            else
            {
                SobreForm.Activate();
            }
        }
        private void resetSobre()
        {
            SobreForm = null; // Reseta o formuláio, atribuindo null ao mesmo para que possa ser aberto novamente;
        }
    }

}