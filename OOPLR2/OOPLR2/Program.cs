using System;
using System.Windows.Forms;

namespace OOPLR2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class mail
    {
        int count, fail_mail;
        double weight;

        public mail()
        {
            int count = 20, fail_mail = 2;
            double weight = 0.25;
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
