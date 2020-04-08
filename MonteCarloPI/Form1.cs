using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarloPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void baslatButon_Click(object sender, EventArgs e)
        {
            try
            {
                double x, y; //rastele oluşturulan noktalar
                double sayac = 0;
                int adimSayisi = Convert.ToInt32(adimSayisiText.Text);
                Random rnd = new Random();
                progressBar1.Minimum = 0;
                progressBar1.Maximum = adimSayisi;
                progressBar1.Value = 0;

                for (int i = 0; i < adimSayisi; i++)
                {
                    x = rnd.NextDouble(); // 0-1 arası rastgele bir X noktası
                    y = rnd.NextDouble(); // 0-1 arası rastgele bir Y noktası

                    if (Math.Pow(x, 2) + Math.Pow(y, 2) < 1)
                        sayac++;
                    progressBar1.Value++;
                }
                lblSonuc.Text = "PI = " + (4 * sayac / adimSayisi).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
