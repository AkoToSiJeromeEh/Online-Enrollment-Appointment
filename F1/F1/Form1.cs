using System.Timers;

namespace F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void FRM_Splash_Load(object sender , EventArgs e)
        {
            panel2.Width = 0;
            Timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            for(int i = 0; i < 99; i++)
            {
                panel2.Width = panel2.Width + 6;
                Thread.Sleep(60);
            }
            Timer.Stop();
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
            
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}