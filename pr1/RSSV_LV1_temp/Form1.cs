using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSV_LV1_temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader citac = new StreamReader("value.txt");
            int crit = Int32.Parse(richTextBox2.Text);
            int[] valueArray = Array.ConvertAll(citac.ReadLine().Split(',').ToArray(), int.Parse);
            citac.Close();
            checkCriticalValue(crit, valueArray);
        }

        private void checkCriticalValue(int crit, int[] valueArray)
        {
            button1.Enabled = false;
            for(int i=0; i < valueArray.Length; i++)
            {
                richTextBox1.Text = valueArray[i].ToString();
                Application.DoEvents();

                if(valueArray[i] > crit)
                {
                    MessageBox.Show(valueArray[i].ToString() + "je veci od kriticne vrijednosti, prekidam program.");
                    break;
                }
                Thread.Sleep(1000);
            }
            MessageBox.Show("Provjera gotova, nema vrijednosti vecih od kriticne.");
            button1.Enabled = true;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            checkInputValue(richTextBox2.Text);
        }

        private void checkInputValue(string value)
        {
            if(!int.TryParse(value,out int i))
            {
                button1.Enabled = false;
                label1.Text = "Niste unjeli broj ili je prazno polje";
                return;
            }

            label1.Text = "Kritična vrijednost";
            button1.Enabled = true;
        }

       
    }
}
