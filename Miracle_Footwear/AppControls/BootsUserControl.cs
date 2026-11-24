using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miracle_Footwear.AppForms;
using Miracle_Footwear.Models;

namespace Miracle_Footwear
{
    public partial class BootsUserControl : UserControl
    {
        private int _idUser;
        private Product _product;
        public BootsUserControl(Product product, int idUser)
        {
            InitializeComponent();
            _product = product;
            _idUser = idUser;
            ShowProduct();
        }
        private void ShowProduct()
        {
            string photoPath = $@"img\{_product.Photo}";
            if(!string.IsNullOrEmpty(_product.Photo) && File.Exists(photoPath))
            {
                photoPicBox.ImageLocation = photoPath;
            }
            else
            {
                photoPicBox.ImageLocation = $@"img\picture.png";
            }
            List<Manufacturer> manufacturers = Program.context.Manufacturer.Where(m => m.IdManufacturer == _product.ManufacturerId).ToList();
            foreach (Manufacturer manufacturer in manufacturers)
            {
                manProLab.Text = $"{manufacturer.ManufacturerName} ";
            }
            manProLab.Text = $"{manProLab.Text}| {_product.ProductName}";
            categoryLab.Text = "Категория: "+_product.Category;
            List<ProductSize> productSizes = Program.context.ProductSize.Where(ps=>ps.ProductId == _product.IdProduct).ToList();
            int totalStock = 0;
            foreach (ProductSize productSize in productSizes)
            {
                totalStock += productSize.Stock;
            }
            if (totalStock > 5)
            {
                countLab.Text = "Количество: много";
            }
            else if(totalStock <= 5)
            {
                countLab.Text = "Количество: мало";
            }
            if (totalStock <= 3)
            {
                this.BackColor = Color.LightCoral;
            }
            compositionLab.Text = "Состав: "+_product.Сomposition;
            bool aprilOrder = false;
            List<OrderProduct> orderProducts = Program.context.OrderProduct.Where(op => op.ProductId == _product.IdProduct).ToList();
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
                priceLab.Text = "Цена: " + _product.ProductPrice.ToString() + " руб.";
            }
            else
            {
                decimal ini = _product.ProductPrice;
                ini *= 0.75m;
                priceLab.Text = "Цена: " + Math.Round(ini,2) + " руб.";
            }
        }

        private void photoPicBox_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(_product, _idUser);
            DialogResult result = productForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MainForm mainForm = this.FindForm() as MainForm;
                if(mainForm != null)
                {
                    mainForm.UpdateProduct();
                }
            }
        }
    }
}
