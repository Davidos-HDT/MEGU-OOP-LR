using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOPLR7
{
    public partial class Form1 : Form
    {
        double x = 1.567, y = 1.786, z = 1.1236, x2 = 2.5, dx = 1.5, xp = 0.3, x3, y3, res;
        int n = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!InputDouble(ref x, "Введіть x"))
                return;
            if (!InputDouble(ref y, "Введіть y"))
                return;
            if (!InputDouble(ref z, "Введіть z"))
                return;
            res = (x + y) / ((4 * x) - z - y);
            MessageBox.Show("X = " + x.ToString() + "\nY = " + y.ToString() + "\nZ = " + z.ToString() + "\n\nДорівнює: " + res.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!InputDouble(ref x2, "Введіть x"))
                return;
            if (0 < x2 && x2 <= 1.2)
                res = Math.Pow(Math.Sin(x2), 2);
            if (1.2 < x2 && x2 < 9)
                res = Math.Log(Math.Sqrt(Math.Pow(x2, 3)));
            if (x2 <= 9 & x2 <= 0)
                res = Math.Pow(Math.E, x2+3);
            MessageBox.Show("X = " + x2.ToString() + "\n\nДорівнює: " + res.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!InputDouble(ref xp, "Введіть початок проміжку табулювання"))
                return;
            if (!InputDouble(ref dx, "Введіть крок"))
                return;
            if (!InputInt(ref n, "Введіть кількість точок"))
                return;
            string res = "Протабульвана функція:\nX\tY";
            for (int i = 0; i < n; i++)
            {
                x3 = xp + (i * dx);
                y3 = (Math.Pow(Math.E, 2 * x3) - 8) / (x3 + 3);
                res += "\n" + x3.ToString() + "\t" + y3.ToString();
            }
            MessageBox.Show(res, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static bool InputDouble(ref double x, string message)
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

        static bool InputInt(ref int x, string message)
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
    }
}
