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
            //pictureBoxMainFormEye2.Visible = true;

            //pictureBoxMainFormEye.BackColor = Color.Red; // Define a cor desejada para o olho (substitua "pictureBoxEye" pelo nome do seu controle PictureBox)
            if (blink == null)
            {
                blink = new EyeBlink();
                blink.Show();
                timer = new System.Windows.Forms.Timer();
                if (BlinkTime == 1)
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
                //blink.BackColor = Color.WhiteSmoke; // Altere a cor para a cor desejada quando a pessoa deve piscar
                blink.ShowEye();

            }
            else
            {
                //blink.BackColor = Color.White; // Restaure a cor de fundo translúcida 
                blink.HideEye();
            }

            //pictureBoxMainFormEye.Visible = !pictureBoxMainFormEye.Visible; // Alterna a visibilidade do controle PictureBox
            //pictureBoxMainFormEye.BackColor = Color.White;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop(); // Para o temporizador (substitua "timer" pelo nome do seu temporizador)
            blink.Visible = false; // Oculta o controle do olho (substitua "blink" pelo nome do seu controle de olho)
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
            timer.Start(); // Inicia o temporizador (substitua "timer" pelo nome do seu temporizador)
            blink.Visible = true; // Torna o controle do olho visível (substitua "blink" pelo nome do seu controle de olho)
            btnResume.Visible = false;
            btnStop.Visible = true;
        }

        private void pictureBoxMainFormEye2_Click(object sender, EventArgs e)
        {

        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //MainEyeForm.Activate();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void resetConfig()
        {
            ConfigForm = null; // Redefine a variável ConfigForm para null quando o formulário é fechado
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
            SobreForm = null; // Redefine a variável ConfigForm para null quando o formulário é fechado
        }
    }

}