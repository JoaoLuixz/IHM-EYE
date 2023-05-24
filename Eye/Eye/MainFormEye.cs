namespace Eye
{
    public partial class MainFormEye : Form
    {
        private EyeBlink blink; //eyeForm
        private System.Windows.Forms.Timer timer;
        private bool shouldBlink = false;

        public MainFormEye()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (blink == null)
            {
                blink = new EyeBlink();
                blink.Show();

                timer = new System.Windows.Forms.Timer();
                timer.Interval = 2000; // Intervalo em milissegundos (2 segundos)
                timer.Tick += Timer_Tick;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            shouldBlink = !shouldBlink;

            if (shouldBlink)
            {
                blink.BackColor = Color.Red; // Altere a cor para a cor desejada quando a pessoa deve piscar
            }
            else
            {
                blink.BackColor = Color.White; // Restaure a cor de fundo translúcida 
            }
        }
    }
}