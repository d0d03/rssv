using System;
using System.Linq;
using System.Windows.Forms;
using WMPLib;


namespace zadatak2
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer t;
        private int Hours;
        private int Minutes;
        private int Seconds;
        private WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();

            lblAlarm.Text = "";
            label1.Text = "";

            t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(time);
            t.Start();  
        }

        private void time(object s, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                lblTime.Text = DateTime.Now.ToLongTimeString();

                if(lblTime.Text == lblAlarm.Text)
                {
                    wplayer.URL = "happy_hour.mp3";
                    wplayer.controls.play();
                }
            });
        }

        private void bntAlarm_Click(object sender, EventArgs e)
        {
            Hours = (int)nUDHours.Value;
            Minutes = (int)nUDMinutes.Value;
            Seconds = (int)nUDSeconds.Value;

            foreach (RadioButton rbtn in gbRadioBtns.Controls.OfType<RadioButton>())
            {
                if (rbtn.Checked)
                {
                    DateTime alarm = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Hours, Minutes, Seconds);
                    label1.Text = "Alarm set for: ";
                    lblAlarm.Text = string.Format("{0:hh:mm:ss}", alarm) + " " + rbtn.Text;
                }
            } 
        }
    }
}
