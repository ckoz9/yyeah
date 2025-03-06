using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void renkDegistir()
        {
            Random rnd = new Random();
            int yeniR = rnd.Next(255);
            int yeniG = rnd.Next(255);
            int yeniB = rnd.Next(255);
            label1.ForeColor = Color.FromArgb(yeniB, yeniG, yeniR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size + 1);
            renkDegistir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size - 1);
            renkDegistir();
        }
    }
}
