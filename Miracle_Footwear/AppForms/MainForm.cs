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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Miracle_Footwear.AppForms
{
    public partial class MainForm : ParentForm
    {
        private int _idUser;
        private string _userRole;
        private bool _isSelectForOrder;
        public MainForm(string username, bool isSelectForOrder)
        {
            InitializeComponent();
            _isSelectForOrder = isSelectForOrder;

            List<User> users = Program.context.User.Where(u => u.Username == username).ToList();
            foreach (User user in users)
            {
                _idUser = user.IdUser;
                _userRole = user.Role;
                fioLab.Text = $"{user.FirstName} {user.LastName} {user.PatronymicName}";
                roleLab.Text = user.Role;
            }

            if (_isSelectForOrder == true)
            {
                orderBtn.Visible = false;
                this.Text = "\"Чудо Обувь\": Выбор товаров для заказа";
                titleLab.Text = "Выбор товаров для заказа";
            }
            else
            {
                this.Text = "\"Чудо Обувь\": Список товаров";
                titleLab.Text = "Список товаров";

                if (_userRole == "Менеджер" || _userRole == "Администратор")
                {
                    orderBtn.Visible = true;
                }
                else
                {
                    orderBtn.Visible = false;
                }
            }

            AddCategoryCB();
            categoryComboBox.SelectedIndex = 0;
            ShowProduct();
        }
        public MainForm(string username)
        {
            InitializeComponent();
            List<User> users = Program.context.User.Where(u => u.Username == username).ToList();
            foreach (User user in users)
            {
                _idUser = user.IdUser;
                _userRole = user.Role;
                fioLab.Text = $"{user.FirstName} {user.LastName} {user.PatronymicName}";
                roleLab.Text = user.Role;
            }
            if (_userRole == "Менеджер" || _userRole == "Администратор")
            {
                orderBtn.Visible = true;
            }
            else
            {
                orderBtn.Visible = false;
            }
            this.Text = $"\"Чудо Обувь\": Список товаров";
            titleLab.Text = "Список товаров";
            AddCategoryCB();
            categoryComboBox.SelectedIndex = 0;
            ShowProduct();
        }
        private void AddCategoryCB()
        {
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.Add("Все категории");
            List<Product> products = Program.context.Product.ToList();
            foreach (Product product in products)
            {
                bool categ = false; 
                int count = categoryComboBox.Items.Count;
                for(int i = 0; i<count; i++)
                {
                    if (product.Category == categoryComboBox.Items[i].ToString())
                    {
                        categ = true;
                        break;
                    }
                    else
                    {
                        categ = false;
                    }
                }
                if(categ == false)
                {
                    categoryComboBox.Items.Add(product.Category);
                }
            }
        }
        private decimal GetProductFinalPrice(Product product)
        {
            bool aprilOrder = false;
            List<OrderProduct> orderProducts = Program.context.OrderProduct.Where(op => op.ProductId == product.IdProduct).ToList();

            foreach (OrderProduct orderProduct in orderProducts)
            {
                List<Order> orders = Program.context.Order.Where(o => o.IdOrder == orderProduct.OrderId).ToList();

                foreach (Order order in orders)
                {
                    if (order.Date.Month == 4 && order.Date.Year == DateTime.Now.Year)
                    {
                        aprilOrder = true;
                    }
                }
            }

            if (aprilOrder == true)
            {
                return product.ProductPrice;
            }

            return Math.Round(product.ProductPrice * 0.75m, 2);
        }
        private void ShowProduct()
        {
            List<Product> products = Program.context.Product.OrderBy(p=>p.IdProduct).ToList();
            foreach (Product product in products)
            {
                flowLayoutPanel1.Controls.Add(new BootsUserControl(product, _idUser));
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_isSelectForOrder == false)
            {
                this.Hide();
                if (this.Owner != null)
                    this.Owner.Show();
            }
        }

        private void priceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortProduct();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortProduct();
        }

        private void searchTxb_TextChanged(object sender, EventArgs e)
        {
            SortProduct();
        }
        private void ClearProduct()
        {
            flowLayoutPanel1.Controls.Clear();
        }
        public void UpdateProduct()
        {
            ClearProduct();
            ShowProduct();
        }
        private void SortProduct()
        {
            List<Product> products = Program.context.Product.ToList();
            if (categoryComboBox.SelectedIndex == 0)
                products = Program.context.Product.OrderBy(p=>p.IdProduct).ToList();
            else
            {
                products = products.Where(p => p.Category == categoryComboBox.Text).ToList();
            }
            if (priceComboBox.SelectedIndex == 0)
                products = products.OrderBy(p => GetProductFinalPrice(p)).ToList();
            if (priceComboBox.SelectedIndex == 1)
                products = products.OrderByDescending(p => GetProductFinalPrice(p)).ToList();
            products = products.Where(p => (p.ProductName != null && p.ProductName.ToLower().Contains(searchTxb.Text.ToLower())) || (p.Description != null && p.Description.ToLower().Contains(searchTxb.Text.ToLower()))).ToList();
            ClearProduct();
            foreach (Product product in products)
            {
                flowLayoutPanel1.Controls.Add(new BootsUserControl(product, _idUser));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (_isSelectForOrder == true)
            {
                this.Close();
                return;
            }
            this.Hide();
            if (this.Owner != null)
                this.Owner.Show();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm(_idUser,_userRole);
            ordersForm.ShowDialog();
            ShowProduct();
        }
    }
}
