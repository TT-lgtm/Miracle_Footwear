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
    public partial class ProductForm : ParentForm
    {
        public static List<OrderProduct> TempOrderItems = new List<OrderProduct>();
        private int _idUser;
        private Product _product;
        private ProductSize _selectedProductSize;
        public ProductForm(Product product, int idUser)
        {
            InitializeComponent();
            _product = product;
            _idUser = idUser;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            titleLab.Text = "Просмотр продукта";
            List<User> users = Program.context.User.Where(u => u.IdUser == _idUser).ToList();
            foreach (User user in users)
            {
                fioLab.Text = $"{user.FirstName} {user.LastName} {user.PatronymicName}";
                roleLab.Text = user.Role;
            }
            this.Text = $"\"Чудо Обувь\": Просмотр продукта";
            List<Manufacturer> manufacturers = Program.context.Manufacturer.Where(m => m.IdManufacturer == _product.ManufacturerId).ToList();
            foreach (Manufacturer manufacturer in manufacturers)
            {
                manProLab.Text = $"{manufacturer.ManufacturerName} ";
            }
            manProLab.Text = $"{manProLab.Text}| {_product.ProductName}";

            categoryLab.Text = "Категория: " + _product.Category;
            compositionLab.Text = "Состав: " + _product.Сomposition;
            descriptionLab.Text = "Описание: " + _product.Description;

            bool hasAprilOrder = false;
            List<OrderProduct> orderProducts = Program.context.OrderProduct.Where(op => op.ProductId == _product.IdProduct).ToList();
            foreach (OrderProduct orderProduct in orderProducts)
            {
                List<Order> orders = Program.context.Order.Where(o => o.IdOrder == orderProduct.OrderId).ToList();
                foreach (Order order in orders)
                {
                    if (order.Date.Month == 4 && order.Date.Year == DateTime.Now.Year)
                    {
                        hasAprilOrder = true;
                    }
                }
            }

            decimal finalPrice = _product.ProductPrice;
            if (!hasAprilOrder)
            {
                finalPrice=Math.Round(finalPrice*0.75m,2);
            }
            priceLab.Text = "Цена: " + finalPrice.ToString() + " руб.";
            List<ProductSize> allSizes = Program.context.ProductSize.Where(ps => ps.ProductId == _product.IdProduct).OrderBy(ps=>ps.Size).ToList();
            string sizeRowText = "";
            string availableSizesText = "";
            sizeComboBox.Items.Clear();
            foreach (ProductSize ps in allSizes)
            {
                sizeRowText += ps.Size.ToString() + "; ";
                int alreadyInOrder = 0;
                foreach (OrderProduct item in TempOrderItems)
                {
                    if (item.ProductId == _product.IdProduct && item.Size == ps.Size)
                    {
                        alreadyInOrder += item.Amount;
                    }
                }

                int availableStock = ps.Stock - alreadyInOrder;
                if (availableStock > 0)
                {
                    availableSizesText += $"{ps.Size} ({availableStock} шт.); ";
                    sizeComboBox.Items.Add(ps.Size);
                }
            }
            sizeRowLab.Text = "Размерный ряд: " + sizeRowText;
            availableSizesLab.Text = "Доступные для заказа размеры: " + availableSizesText;

            amountNumeric.Value = 1;
            amountNumeric.Maximum = 1;
            amountNumeric.Minimum = 1;
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sizeComboBox.SelectedItem == null) 
                return;

            double selectedSize = Convert.ToDouble(sizeComboBox.SelectedItem);

            List<ProductSize> sizes = Program.context.ProductSize.Where(ps => ps.ProductId == _product.IdProduct && ps.Size == selectedSize).ToList();

            foreach (ProductSize ps in sizes)
            {
                _selectedProductSize = ps;
                int alreadyInOrder = 0;
                foreach (OrderProduct item in TempOrderItems)
                {
                    if (item.ProductId == _product.IdProduct && item.Size == ps.Size)
                    {
                        alreadyInOrder += item.Amount;
                    }
                }

                amountNumeric.Maximum = ps.Stock - alreadyInOrder;
                amountNumeric.Value = 1;
            }
        }
        private void AddCurrentSelectionToTempList()
        {
            int orderedAmount = Convert.ToInt32(amountNumeric.Value);
            bool hasAprilOrder = false;
            List<OrderProduct> orderProducts = Program.context.OrderProduct.Where(op => op.ProductId == _product.IdProduct).ToList();
            foreach (OrderProduct orderProduct in orderProducts)
            {
                List<Order> orders = Program.context.Order.Where(o => o.IdOrder == orderProduct.OrderId).ToList();
                foreach (Order order in orders)
                {
                    if (order.Date.Month == 4 && order.Date.Year == 2026)
                    {
                        hasAprilOrder = true;
                    }
                }
            }

            decimal finalPrice = _product.ProductPrice;
            if (!hasAprilOrder)
            {
                finalPrice = Math.Round(finalPrice * 0.75m, 2);
            }

            bool found = false;
            foreach (OrderProduct item in TempOrderItems)
            {
                if (item.ProductId == _product.IdProduct && item.Size == _selectedProductSize.Size)
                {
                    item.Amount += orderedAmount;
                    found = true;
                }
            }

            if (!found)
            {
                OrderProduct newItem = new OrderProduct();
                newItem.ProductId = _product.IdProduct;
                newItem.Size = _selectedProductSize.Size;
                newItem.Amount = orderedAmount;
                newItem.OrderProductPrice = finalPrice;
                TempOrderItems.Add(newItem);
            }
        }
        private void addToCardBtn_Click(object sender, EventArgs e)
        {
            if (_selectedProductSize == null)
            {
                MessageBox.Show("Пожалуйста, выберите размер обуви из списка!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddCurrentSelectionToTempList();

            MessageBox.Show($"Товар добавлен в заказ (всего позиций: {TempOrderItems.Count}). Вы можете выбрать другие товары из каталога или подтвердить заказ.","Позиция добавлена", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void addToOrderBtn_Click(object sender, EventArgs e)
        {
            if (_selectedProductSize != null)
            {
                AddCurrentSelectionToTempList();
            }
            if (TempOrderItems.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите размер и количество товара для оформления заказа!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Order newOrder = new Order();
                newOrder.Date = DateTime.Now;
                newOrder.UserId = _idUser;
                newOrder.Status = "Подтвержден";

                Program.context.Order.Add(newOrder);
                Program.context.SaveChanges();

                foreach (OrderProduct item in TempOrderItems)
                {
                    item.OrderId = newOrder.IdOrder;
                    Program.context.OrderProduct.Add(item);
                    List<ProductSize> sizes = Program.context.ProductSize.Where(ps => ps.ProductId == item.ProductId && ps.Size == item.Size).ToList();

                    foreach (ProductSize ps in sizes)
                    {
                        ps.Stock -= item.Amount;
                    }
                }
                Program.context.SaveChanges();
                TempOrderItems.Clear();
                MessageBox.Show("Заказ успешно оформлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            TempOrderItems.Clear();
            MessageBox.Show("Оформление заказа отменено.", "Отмена заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}