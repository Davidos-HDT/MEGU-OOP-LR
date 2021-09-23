using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOPLR3
{
    public partial class Form1 : Form
    {
        pmail pmail_zm;
        email email_zm;
        mail mail_zm;
        public static int count = 0;
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
            mail_zm = new pmail();
            MessageBox.Show("Лист по замовчуванню створено", "Лист", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mail_zm.info();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pmail_zm != null)
            {
                pmail_zm.info();
            }
            else
                MessageBox.Show("Поштовий лист ще не створено.\nСкористайтеся кнопками вище", "Лист", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pmail_zm != null)
            {
                int change = Convert.ToInt32(Interaction.InputBox("Введіть кількість символів для поштового листа", "Зміна кількості символів", "7"));
                pmail_zm.symbol = change;
            }
            if (email_zm != null)
            {
                int change = Convert.ToInt32(Interaction.InputBox("Введіть кількість символів для електроного листа", "Зміна кількості символів", "7"));
                email_zm.symbol = change;
            }
            else
                MessageBox.Show("Лист ще не створено.\nСкористайтеся кнопками вище", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = Interaction.InputBox("Введіть кому цей лист", "Лист", "Ilya");
            double b = Convert.ToDouble(Interaction.InputBox("Введіть ширину листа", "Лист", "9"));
            double c = Convert.ToDouble(Interaction.InputBox("Введіть довжину листа", "Лист", "6"));
            int d = Convert.ToInt32(Interaction.InputBox("Введіть кількість символів", "Лист", "150"));
            mail_zm = new pmail(a, b, c, d);
            mail_zm.info();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pmail_zm != null)
            {
                int minus = Convert.ToInt32(Interaction.InputBox("Введіть кількість символів щоб добавити для поштового листа", "Дадавання символів до листа", "7"));
                pmail_zm.symbol += minus;
            }
            if (email_zm != null)
            {
                int minus = Convert.ToInt32(Interaction.InputBox("Введіть кількість символів щоб добавити для електроного листа", "Дадавання символів до листа", "7"));
                email_zm.symbol += minus;
            }
            else
                MessageBox.Show("Лист ще не створено.\nСкористайтеся кнопками вище", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = Interaction.InputBox("Введіть кому цей лист", "Електроний лист", "Ilya@gmail.com");
            int b = Convert.ToInt32(Interaction.InputBox("Введіть кількість символів", "Електроний лист", "150"));
            int c = Convert.ToInt32(Interaction.InputBox("Введіть кількість картинок", "Електроний лист", "2"));
            mail_zm = new email(a, 0, 0, b, c);
            mail_zm.info();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (email_zm != null)
            {
                email_zm.info();
            }
            else
                MessageBox.Show("Електронний лист ще не створено.\nСкористайтеся кнопками вище", "Лист", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поточна кількість об'єктів " + count.ToString(), "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mail_zm = new pmail();
            MessageBox.Show("Лист по замовчуванню створено", "Поштовий лист", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mail_zm.info();
        }

        public void button11_Click(object sender, System.EventArgs e)
        {
            mail_zm = new email();
            MessageBox.Show("Лист по замовчуванню створено", "Електронный лист", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mail_zm.info();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button a = new Button();
            Random rnd = new Random();
            a.Width = 200;
            a.Height = 50;
            a.Left = rnd.Next(500);
            a.Top = rnd.Next(400);
            a.Text = ((Button)sender).Text;
            a.Parent = this;
            a.Show();
            a.Click += new System.EventHandler(this.button12_Click);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            foreach (Control elem in this.Controls)
            elem.Left += 60;
        }
    }

    public abstract class mail
    {
        public string komy;
        public double width, height;
        public int symbol, nomer;

        public mail()
        {
            komy = "Ilya";
            width = 10;
            height = 15;
            symbol = 55;

            Form1.count++;
            nomer = Form1.count;
        }

        ~mail()
        {
            MessageBox.Show("Лист № " + nomer.ToString() + " видалено.", "Деструктор", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1.count--;
        }

        public abstract double perimeter();

        public mail(string komy, double width, double height, int symbol) : this()
        {
            this.komy = komy;
            this.width = width;
            this.height = height;
            this.symbol = symbol;
        }

        public virtual void info()
        {
            MessageBox.Show("Кому: " + komy + "\nШирина: " + width.ToString() + " см\nДовжина: " + height.ToString() + "см\nКількість символів: " + symbol.ToString() + "\nПериметер: " + perimeter().ToString(), "Лист №" + nomer.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class pmail : mail
    {
        public pmail()
        {}

        public pmail(string komy, double width, double height, int symbol) : base(komy, width, height, symbol)
        {
        }

        public override double perimeter()
        {
            return (width + height) * 2;
        }

        public override void info()
        {
            MessageBox.Show("Кому: " + komy + "\nШирина: " + width.ToString() + " см\nДовжина: " + height.ToString() + "см\nКількість символів: " + symbol.ToString() + "\nПериметер: " + perimeter().ToString(), "Поштовий лист №" + nomer.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


    public  class email : mail
    {
        public int img = 2;

        public email()
        {
            komy = "Ilya@gmail.com";
            img = 15;
        }
        public email(string komy, double width, double height, int symbol, int img) : base(komy, width, height, symbol)
        {
            this.img = img;
        }

        public override double perimeter()
        {
            return (width + height) * 2;
        }

        public override void info()
        {
            MessageBox.Show("Кому: " + komy + "\nКількість символів: " + symbol.ToString() + "\nКількіть картинок: " + img.ToString() + "\nПериметер: " + perimeter().ToString(), "Електроний лист №" + nomer.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
