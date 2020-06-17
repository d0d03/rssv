using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak1
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer t;
        private StreamReader reader;
        private int[] valueArray;
        private int i;
        private int n;

        public Form1()
        {
            InitializeComponent();

            btn_start_stop.Enabled = false;

            reader = new StreamReader("value.txt");
            valueArray = Array.ConvertAll(reader.ReadLine().Split(',').ToArray(), int.Parse);
            i = 0;
            t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(read);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            reader.Close();
        }

        private void read(object s,EventArgs e)
        {
            int criticalValue = Int32.Parse(tBoxCrit.Text);
            int current;
            
            Invoke((MethodInvoker)delegate
            {
                if (i < valueArray.Length) {
                    current = valueArray[i];
                    i++;
                    checkCriticalValue(criticalValue, current);
                }
            });
        }

        private void DisplayMessageBoxText()
        {
            MessageBox.Show("Check done! Found " + n.ToString() + " outliers\n Ending program.");
        }

        public void checkCriticalValue(int crit, int current)
        {
            tBoxCurrent.Text = current.ToString();
            if(current > crit)
            {
                tBoxOutliers.Text += current.ToString() + ", ";
                n++;
            }
            if (i >= valueArray.Length) { DisplayMessageBoxText(); }
        }

        private void tBoxCrit_TextChanged(object sender, EventArgs e)
        {
            checkInputValue(tBoxCrit.Text);
        }

        private void checkInputValue(string value)
        {
            if(!int.TryParse(value,out int i))
            {
                btn_start_stop.Enabled = false;
                lblCrit.Text = "Invalid value! Please enter integer value.";
                return;
            }

            lblCrit.Text = "Critical Value";
            btn_start_stop.Enabled = true;
        }

        private void btn_start_stop_Click(object sender, EventArgs e)
        {

            if(t.Enabled == false)
            {
                tBoxCrit.Enabled = false;
                t.Start();
                btn_start_stop.Text = "Stop";
            }
            else
            {
                tBoxCrit.Enabled = true;
                tBoxCurrent.Text = "Paused";
                t.Stop();
                btn_start_stop.Text = "Start";
            }
        }
    }
}
