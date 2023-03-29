using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Preglednik
        {
            string url;

            public string Url { get => url; set => url = value; }
        }
        List<Preglednik> lista = new List<Preglednik>();
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //tab
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //bookmark
            try
            {
                Preglednik bm = new Preglednik();
                lista.Add(bm);


            }
            catch
            {

            }
        }
    }
}
