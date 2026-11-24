using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miracle_Footwear.AppForms;
using Miracle_Footwear.Models;

namespace Miracle_Footwear
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static DbBoots context = new DbBoots();
        [STAThread]
        static void Main()
        {
            if (!context.Database.Exists())
            {
                MessageBox.Show("Не удалось установить соединение с базой данных", "Ошибка подключения к базе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
