using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miracle_Footwear.Models;

namespace Miracle_Footwear.AppForms
{
    public partial class LoginForm : ParentForm
    {
        private bool login = false;
        private string _username = "";
        public LoginForm()
        {
            InitializeComponent();
            this.Text = $"\"Чудо Обувь\": Вход";
            titleLab.Text = "Вход";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            List<User> users = Program.context.User.ToList();
            foreach (User user in users)
            {
                if (loginTxb.Text == user.Username)
                {
                    login = true;
                    _username = user.Username;
                    break;
                }
                else
                {
                    login = false;
                }
            }
            ProductForm.TempOrderItems.Clear();
            if(login == true)
            {
                MainForm mainForm = new MainForm(_username);
                mainForm.Owner = this;
                this.Hide();
                mainForm.ShowDialog();
            }
            if(login == false)
            {
                MessageBox.Show("Пользователь с введенным логином не найден в системе. Проверьте правильность написания логина и повторите попытку.","Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
