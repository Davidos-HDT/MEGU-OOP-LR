using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOPLR5
{
    public partial class Form1 : Form
    {
        pmail pmail_zm = null; 
        email email_zm = null;
        public static int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        static bool inputDouble(ref double x, string message)
        {
            string s;
            s = x.ToString();
        retry:
            s = Interaction.InputBox(message, "Введення", s);
            try
            {
                x = Convert.ToDouble(s);
            }
            catch (FormatException)
            {
                if (MessageBox.Show("Ви ввели не число\n\nБажаєте повторити?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    goto retry;
                else
                    return false;
            }
            return true;
        }

        static bool inputInt(ref int x, string message)
        {
            string s;
            s = x.ToString();
        retry:
            s = Interaction.InputBox(message, "Введення", s);
            try
            {
                x = Convert.ToInt32(s);
            }
            catch (FormatException)
            {
                if (MessageBox.Show("Ви ввели не число\n\nБажаєте повторити?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    goto retry;
                else
                    return false;
            }
            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string komy = "Vasya";
            double width = 15.2, height = 10;
            int symbol = 50;
            komy = Interaction.InputBox("Введіть кому ви хочете відправити лист", "Введення", komy);
            if (!inputDouble(ref width, "Введіть шрину першного листа"))
                return;
            if (!inputDouble(ref height, "Введіть довжину першого листа"))
                return;
            if (!inputInt(ref symbol, "Введіть кількість символів в листі"))
                return;
            pmail_zm = new pmail(komy, width, height, symbol);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pmail_zm == null)
            {
                MessageBox.Show("Перший лист ще не створено!", "Увага!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int symbol = pmail_zm.Symbol;
            if (!inputInt(ref symbol, "Введіть кількість символів першного листа"))
                return;
            pmail_zm.Symbol = symbol;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string komy = "Vasya";
            double width = 15.2, height = 10;
            int symbol = 50, img = 3;
            komy = Interaction.InputBox("Введіть кому ви хочете відправити лист", "Введення", komy);
            if (!inputDouble(ref width, "Введіть шрину першного листа"))
                return;
            if (!inputDouble(ref height, "Введіть довжину першого листа"))
                return;
            if (!inputInt(ref symbol, "Введіть кількість символів в листі"))
                return;
            if (!inputInt(ref img, "Введіть кількість картинок в листі"))
                return;
            email_zm = new email(komy, width, height, symbol, img);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pmail_zm == null)
            {
                MessageBox.Show("Перший лист ще не створено!", "Увага!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string komy = pmail_zm.Komy;
            komy = Interaction.InputBox("Введіть кому ви хочете відправити лист", "Введення", komy);
            pmail_zm.Komy = komy;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (email_zm == null)
            {
                MessageBox.Show("Другий лист ще не створено!", "Увага!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string komy = email_zm.Komy;
            komy = Interaction.InputBox("Введіть кому ви хочете відправити лист", "Введення", komy);
            email_zm.Komy = komy;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pmail_zm == null)
            {
                MessageBox.Show("Перший лист ще не створено!", "Увага!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double width = pmail_zm.Width;
            if (!inputDouble(ref width, "Введіть шрину першного листа"))
                return;
            pmail_zm.Width = width;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pmail_zm == null)
            {
                MessageBox.Show("Перший лист ще не створено!", "Увага!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double height = pmail_zm.Height;
            if (!inputDouble(ref height, "Введіть довжину першного листа"))
                return;
            pmail_zm.Height = height;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pmail_zm == null)
            {
                MessageBox.Show("Перший лист ще не створено!", "Увага!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string komy = pmail_zm.Komy;
            double height = pmail_zm.Height;
            double width = pmail_zm.Width;
            int symbol = pmail_zm.Symbol;
            komy = Interaction.InputBox("Введіть кому ви хочете відправити лист", "Введення", komy);
            pmail_zm.Komy = komy;
            if (!inputDouble(ref width, "Введіть шрину першного листа"))
                return;
            pmail_zm.Width = width;
            if (!inputDouble(ref height, "Введіть довжину першного листа"))
                return;
            pmail_zm.Height = height;
            if (!inputInt(ref symbol, "Введіть кількість символів першного листа"))
                return;
            pmail_zm.Symbol = symbol;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (email_zm == null)
            {
                MessageBox.Show("Другий лист ще не створено!", "Увага!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double width = email_zm.Width;
            if (!inputDouble(ref width, "Введіть шрину першного листа"))
                return;
            email_zm.Width = width;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (email_zm == null)
            {
                MessageBox.Show("Другий лист ще не створено!", "Увага!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double height = email_zm.Height;
            if (!inputDouble(ref height, "Введіть довжину першного листа"))
                return;
            email_zm.Height = height;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (email_zm == null)
            {
                MessageBox.Show("Другий лист ще не створено!", "Увага!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int symbol = email_zm.Symbol;
            if (!inputInt(ref symbol, "Введіть кількість символів першного листа"))
                return;
            email_zm.Symbol = symbol;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (email_zm == null)
            {
                MessageBox.Show("Другий лист ще не створено!", "Увага!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string komy = email_zm.Komy;
            double height = email_zm.Height;
            double width = email_zm.Width;
            int symbol = email_zm.Symbol;
            komy = Interaction.InputBox("Введіть кому ви хочете відправити лист", "Введення", komy);
            email_zm.Komy = komy;
            if (!inputDouble(ref width, "Введіть шрину першного листа"))
                return;
            email_zm.Width = width;
            if (!inputDouble(ref height, "Введіть довжину першного листа"))
                return;
            email_zm.Height = height;
            if (!inputInt(ref symbol, "Введіть кількість символів першного листа"))
                return;
            email_zm.Symbol = symbol;
        }

        static bool inputInt(ref string x, string message)
        {
            string s;
            s = x.ToString();
        retry:
            s = Interaction.InputBox(message, "Введення", s);
            try
            {
                x = s;
            }
            catch (FormatException)
            {
                if (MessageBox.Show("Ви ввели не число\n\nБажаєте повторити?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    goto retry;
                else
                    return false;
            }
            return true;
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

       /* ~mail()
        {
            MessageBox.Show("Лист № " + nomer.ToString() + " видалено.", "Деструктор", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1.count--;
        } */

        public abstract double perimeter();

        public mail(string komy, double width, double height, int symbol) : this()
        {
            this.komy = komy;
            this.width = width;
            this.height = height;
            this.symbol = symbol;
        }

        public virtual void info()
        {}
    }

    public class pmail : mail
    {
        private string komy;
        private double width, height;
        private int symbol;

        public pmail(string komy, double width, double height, int symbol)
        {
            this.komy = komy;
            this.width = width;
            this.height = height;
            this.symbol = symbol;
        }

        public string Komy
        {
            get { return komy; }
            set { komy = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Symbol
        {
            get { return symbol; }
            set { if (value > 0)
                    symbol = value;
            }
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


    public class email : mail
    {
        private string komy;
        private double width, height;
        private int symbol, img;

        public email(string komy, double width, double height, int symbol, int img)
        {
            this.komy = komy;
            this.width = width;
            this.height = height;
            this.symbol = symbol;
            this.img = img;
        }

        public string Komy
        {
            get { return komy; }
            set { komy = value; }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
            }
        }

        public int Symbol
        {
            get { return symbol; }
            set
            {
                if (value > 0)
                    symbol = value;
            }
        }

        public int Img
        {
            get { return img; }
            set
            {
                if (value >= 0)
                    img = value;
            }
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