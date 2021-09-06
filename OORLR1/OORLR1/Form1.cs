using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OORLR1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розпочинаємо вивчення основ ООП");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Закінчуємо вивчення основ ООП");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хотя може почнемо основи ООП");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хотя не нада");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
