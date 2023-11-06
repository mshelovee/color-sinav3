using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygsinav3_96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i <= 100; i++)
            {
                int sayi = rnd.Next(0, 100);
                lblSayilar.Text = sayi.ToString();



                if(sayi < 49)
                {
                    lblSayilar.ForeColor = Color.Red;
                }
                if (sayi >= 50 && sayi < 69)
                {
                    lblSayilar.ForeColor = Color.Orange;
                }
                if(sayi >= 70 && sayi <= 100)
                {
                    lblSayilar.ForeColor = Color.Blue;
                }
                                
            }
        }
    }
}
