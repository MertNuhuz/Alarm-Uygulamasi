using System;
using System.Windows.Forms;
using System.Media;

namespace AlarmApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kronometre.Start();
        }

        private void onDakikaButton_Click(object sender, EventArgs e)
        {
            dakikaAyarla.Text = Convert.ToString(alarmKur(10));
        }

        private void otuzDakikaButton_Click(object sender, EventArgs e)
        {
           dakikaAyarla.Text =Convert.ToString(alarmKur(30));
        }

        private void yenidenKur_Click(object sender, EventArgs e)
        {
            kronometre.Start();
        }

        private void kronometre_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToShortTimeString();
            if (dakikaAyarla.Value == DateTime.Now.Minute)
            {
                kronometre.Stop();
                SoundPlayer player = new SoundPlayer();
                string sarkiYol = Application.StartupPath + "/alarm.wav";
                player.SoundLocation = sarkiYol;
                player.Play();
                MessageBox.Show("Vakit geldi!");

            }
        }

        public decimal alarmKur(int artisMiktari)
        {
            decimal vakit = Convert.ToDecimal(Convert.ToInt32(DateTime.Now.Minute) + artisMiktari);
            if (vakit > 60)
            {
                vakit = vakit - 60;
                return vakit;
            }
            else
            {
                return vakit;
            }

        }
    }
}
