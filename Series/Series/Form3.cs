using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Series
{
    public partial class Form3 : Form
    {
        public static string pseudo; 
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4.pseudo = Form3.pseudo;
            Form4 f = new Form4();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5.pseudo = Form3.pseudo;
            Form5 f = new Form5();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6.pseudo = Form3.pseudo;
            Form6 f = new Form6();
            f.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            XX.Text = pseudo;
        }

        private void deco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pseudo = "";
            this.Close();
        }
    }
}
