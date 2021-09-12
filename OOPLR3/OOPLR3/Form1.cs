using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOPLR3
{
    public partial class Form1 : Form
    {
        mail sho;
        email now;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sho = new mail();
            now = new email();
            MessageBox.Show("Лист по замовчуванню створено", "Лист", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sho != null)
            {
                sho.Info();
            }
            else
                MessageBox.Show("Поштовий лист ще не створено.\nСкористайтеся кнопками вище", "Лист", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sho != null)
            {
                int plus = Convert.ToInt32(Interaction.InputBox("Введіть кількість символів", "Увага", "7"));
                sho.symbol += plus;
            }
            else
                MessageBox.Show("Лист ще не створено.\nСкористайтеся кнопками вище", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = Interaction.InputBox("Введіть кому цей лист", "Лист", "Ilya");
            double b = Convert.ToDouble(Interaction.InputBox("Введіть ширину листа", "Увага", "9"));
            double c = Convert.ToDouble(Interaction.InputBox("Введіть довжину листа", "Увага", "6"));
            int d = Convert.ToInt32(Interaction.InputBox("Введіть кількість символів", "Увага", "150"));
            sho = new mail(a, b, c, d);
            sho.Info();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sho != null)
            {
                int v = Convert.ToInt32(Interaction.InputBox("Введіть кількість використаних символів", "Лист", "70"));
                sho.symbol -= v;
            }
            else
                MessageBox.Show("Автомобіль ще не створено.\nСкористайтеся кнопками вище", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = Interaction.InputBox("Введіть кому цей лист", "Лист", "Ilya@gmail.com");
            int b = Convert.ToInt32(Interaction.InputBox("Введіть кількість символів", "Лист", "150"));
            int c = Convert.ToInt32(Interaction.InputBox("Введіть кількість картинок", "Лист", "2"));
            now = new email(a, 0, 0, b, c);
            now.Info();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (now != null)
            {
                now.Info();
            }
            else
                MessageBox.Show("Електронний лист ще не створено.\nСкористайтеся кнопками вище", "Лист", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class mail
    {
        public string komy;
        public double width;
        public double height;
        public int symbol;

        public mail()
        {
            komy = "Ilya";
            width = 10;
            height = 15;
            symbol = 55;
        }

        public mail(string komy, double width, double height, int symbol) : this()
        {
            this.komy = komy;
            this.width = width;
            this.height = height;
            this.symbol = symbol;
        }

        public void Info()
        {
            MessageBox.Show("Кому: " + komy + "\nШирина: " + width.ToString() + " см\nДовжина: " + height.ToString() + "см\nКількість символів: " + symbol.ToString(), "Лист", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class email : mail
    {
        public int img = 2;

        public email()
        {
            komy = "Ilya@gmail.com";
            img = 15;
            symbol = 55;
        }
        public email(string komy, double width, double height, int symbol, int img) : base(komy, width, height, symbol)
        {
            this.img = img;
        }

        public void Info()
        {
            MessageBox.Show("Кому: " + komy + "\nКількість символів: " + symbol.ToString() + "\nКількіть картинок: " + img.ToString(), "Електроний лист", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
