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
    public partial class OrdersForm : ParentForm
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private int _idUser;
        private string _userRole;

        public OrdersForm(int idUser, string userRole)
        {
            InitializeComponent();
            _idUser = idUser;
            _userRole = userRole;

            List<User> users = Program.context.User.Where(u => u.IdUser == _idUser).ToList();
            foreach (User user in users)
            {
                fioLab.Text = $"{user.FirstName} {user.LastName} {user.PatronymicName}";
                roleLab.Text = user.Role;
            }

            this.Text = "\"Чудо Обувь\": Список заказов";
            titleLab.Text = "Список заказов";
            LoadOrders();
        }
        private void LoadOrders()
        {
            orderDataGridView.Rows.Clear();
            List<Order> orders = Program.context.Order.OrderByDescending(o => o.IdOrder).ToList();

            foreach (Order order in orders)
            {
                string clientFio = "";
                List<User> users = Program.context.User.Where(u => u.IdUser == order.UserId).ToList();
                foreach (User u in users)
                {
                    clientFio = $"{u.LastName} {u.FirstName} {u.PatronymicName}";
                }

                orderDataGridView.Rows.Add(order.IdOrder, order.Date.ToShortDateString(), clientFio, order.Status);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            string currentUsername = "";
            List<User> users = Program.context.User.Where(u => u.IdUser == _idUser).ToList();
            foreach (User user in users)
            {
                currentUsername = user.Username;
            }
            ProductForm.TempOrderItems.Clear();
            MainForm catalogForm = new MainForm(currentUsername, true);
            catalogForm.ShowDialog();
            LoadOrders();
        }

        private void deleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (orderDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idOrder = Convert.ToInt32(orderDataGridView.SelectedRows[0].Cells[0].Value);
            DialogResult res = MessageBox.Show("Вы действительно хотите удалить выбранный заказ?","Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                List<OrderProduct> items = Program.context.OrderProduct.Where(op => op.OrderId == idOrder).ToList();
                foreach (OrderProduct item in items)
                {
                    List<ProductSize> sizes = Program.context.ProductSize.Where(ps => ps.ProductId == item.ProductId && ps.Size == item.Size).ToList();
                    foreach (ProductSize ps in sizes)
                    {
                        ps.Stock += item.Amount;
                    }
                    Program.context.OrderProduct.Remove(item);
                }

                List<Order> orders = Program.context.Order.Where(o => o.IdOrder == idOrder).ToList();
                foreach (Order o in orders)
                {
                    Program.context.Order.Remove(o);
                }

                Program.context.SaveChanges();
                LoadOrders();
            }
        }

        private void detailsOrderBtn_Click(object sender, EventArgs e)
        {
            if (orderDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ из списка!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idOrder = Convert.ToInt32(orderDataGridView.SelectedRows[0].Cells[0].Value);
            OrderDetailsForm detailsForm = new OrderDetailsForm(idOrder, _idUser, _userRole);
            detailsForm.ShowDialog();

            LoadOrders();
        }
        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
