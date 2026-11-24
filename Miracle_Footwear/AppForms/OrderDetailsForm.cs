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
    public partial class OrderDetailsForm : ParentForm
    {
        private int _idOrder;
        private int _idUser;
        private string _userRole;

        public OrderDetailsForm(int idOrder, int idUser, string userRole)
        {
            InitializeComponent();
            _idOrder = idOrder;
            _idUser = idUser;
            _userRole = userRole;

            List<User> users = Program.context.User.Where(u => u.IdUser == _idUser).ToList();
            foreach (User user in users)
            {
                fioLab.Text = $"{user.FirstName} {user.LastName} {user.PatronymicName}";
                roleLab.Text = user.Role;
            }

            this.Text = $"\"Чудо Обувь\": Состав заказа №{_idOrder}";
            titleLab.Text = $"Состав заказа №{_idOrder}";

            if (_userRole == "Администратор")
            {
                orderDatePicker.Enabled = true;
                deleteItemBtn.Visible = true;
                saveBtn.Visible = true;
            }
            else
            {
                orderDatePicker.Enabled = false;
                deleteItemBtn.Visible = false;
                saveBtn.Visible = false;
            }

            LoadDetails();
        }
        private void LoadDetails()
        {
            orderProductDataGridView.Rows.Clear();
            decimal totalSum = 0;

            List<Order> orders = Program.context.Order.Where(o => o.IdOrder == _idOrder).ToList();
            foreach (Order o in orders)
            {
                orderDatePicker.Value = o.Date;
            }

            List<OrderProduct> orderProducts = Program.context.OrderProduct.Where(op => op.OrderId == _idOrder).ToList();

            foreach (OrderProduct op in orderProducts)
            {
                string modelText = "";
                List<Product> products = Program.context.Product.Where(p => p.IdProduct == op.ProductId).ToList();
                foreach (Product p in products)
                {
                    string manName = "";
                    List<Manufacturer> mans = Program.context.Manufacturer
                        .Where(m => m.IdManufacturer == p.ManufacturerId).ToList();
                    foreach (Manufacturer m in mans)
                    {
                        manName = m.ManufacturerName;
                    }
                    modelText = $"{p.ProductName}, {manName}";
                }

                totalSum += op.OrderProductPrice * op.Amount;
                orderProductDataGridView.Rows.Add(op.IdOrderProduct, modelText, op.Size, op.Amount, op.OrderProductPrice);
            }

            totalSumLab.Text = $"Итого по заказу: {totalSum} руб.";
        }
        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            if (orderProductDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите позицию для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idOrderProduct = Convert.ToInt32(orderProductDataGridView.SelectedRows[0].Cells[0].Value);
            DialogResult res = MessageBox.Show("Вы действительно хотите удалить выбранную позицию из заказа?","Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            if(res == DialogResult.Yes)
            {
                try
                {
                    List<OrderProduct> items = Program.context.OrderProduct.Where(op => op.IdOrderProduct == idOrderProduct).ToList();

                    foreach (OrderProduct item in items)
                    {
                        List<ProductSize> sizes = Program.context.ProductSize.Where(ps => ps.ProductId == item.ProductId && ps.Size == item.Size).ToList();
                        foreach (ProductSize ps in sizes)
                        {
                            ps.Stock += item.Amount;
                        }

                        Program.context.OrderProduct.Remove(item);
                    }

                    Program.context.SaveChanges();
                    LoadDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            List<Order> orders = Program.context.Order.Where(o => o.IdOrder == _idOrder).ToList();
            foreach (Order o in orders)
            {
                o.Date = orderDatePicker.Value;
            }

            Program.context.SaveChanges();
            MessageBox.Show("Дата заказа обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
