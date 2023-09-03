using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vücutkitleendekshesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kg,sonuc;
            boy = Convert.ToDouble(textBox1.Text);
            kg = Convert.ToDouble(textBox2.Text);
            boy = boy / 100;
            sonuc = (kg / (boy * boy));
            label4.Text = sonuc.ToString();

            if (sonuc < 18.5)
            {
                label4.Text = sonuc+" "+"Zayıf";
            }
            else if(sonuc>18.5 && sonuc < 25)
            {
                label4.Text = sonuc + " " + "Normal";
            }
            else if(sonuc > 25 && sonuc < 30)
            {
                label4.Text = sonuc + " " +"Fazla Kilolu";
            }
            else if(sonuc > 30 && sonuc < 40)
            {
                label4.Text = sonuc + " " + "Obez";
            }
            else if(sonuc > 40 && sonuc < 50)
            {
                label4.Text = sonuc + " " + "Aşırı Obez";
            }
            else
            {
                label4.Text = "Böyle Bir Değer Yok";
            }

        }
    }
}
