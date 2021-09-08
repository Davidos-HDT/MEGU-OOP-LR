using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOPLR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mail m1 = new mail(20, 2, 0.25);
            m1.Info();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count, fail_mail;
            double weight;
            count = Convert.ToInt32(Interaction.InputBox("Введіть кількість листів", "Кількість листів", "4"));
            fail_mail = Convert.ToInt32(Interaction.InputBox("Введіть кількіcть не доставлених листів", "Кількість не доставлених листів", "1"));
            weight = Convert.ToDouble(Interaction.InputBox("Введіть вагу листів", "Вага листів", "0.2"));
            mail m2 = new mail(count, fail_mail, weight);
            m2.Info();
        }
    }
}
