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

        void button2_Click(object sender, EventArgs e)
        {
            int count, fail_mail;
            double weight = 1;
            count = Convert.ToInt32(Interaction.InputBox("Введіть кількість листів", "Кількість листів", "4"));
            fail_mail = Convert.ToInt32(Interaction.InputBox("Введіть кількіcть не доставлених листів", "Кількість не доставлених листів", "1"));
            weight = Convert.ToDouble(Interaction.InputBox("Введіть вагу листів", "Вага листів", "0,2"));
            mail m2 = new mail(count, fail_mail, weight);
            m2.Info();
        }
    }

    class mail
    {
        int count, fail_mail;
        double weight;

        public mail(int count, int fail_mail, double weight)
        {
            this.count = count;
            this.fail_mail = fail_mail;
            this.weight = weight;
        }

        public double kg()
        {
            return count * weight;
        }

        public double delivered()
        {
            return count - fail_mail;
        }

        public void Info()
        {
            MessageBox.Show("Інформація про листи\n\nКількість листів: " + count.ToString() + "\nВага всіх листів: " +
                kg().ToString() + "кг\nДоставлено листів: " + delivered().ToString() + "\nНе доставлено: " +
                fail_mail.ToString(), "Пошта", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

   
