using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizacao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int x = rnd.Next(1, 7);

            label1.Text = x.ToString();

            pictureBox1.Load("dado" + x.ToString() + ".png");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
