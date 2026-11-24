namespace Miracle_Footwear.AppForms
{
    partial class OrderDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roleLab = new System.Windows.Forms.Label();
            this.fioLab = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLab = new System.Windows.Forms.Label();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.totalSumLab = new System.Windows.Forms.Label();
            this.orderProductDataGridView = new System.Windows.Forms.DataGridView();
            this.orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.IdOrderProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.saveBtn);
            this.splitContainer1.Panel2.Controls.Add(this.deleteItemBtn);
            this.splitContainer1.Panel2.Controls.Add(this.totalSumLab);
            this.splitContainer1.Panel2.Controls.Add(this.orderProductDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.orderDatePicker);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.roleLab);
            this.panel1.Controls.Add(this.fioLab);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.titleLab);
            this.panel1.Controls.Add(this.logoPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 2;
            // 
            // roleLab
            // 
            this.roleLab.Location = new System.Drawing.Point(553, 26);
            this.roleLab.Name = "roleLab";
            this.roleLab.Size = new System.Drawing.Size(154, 13);
            this.roleLab.TabIndex = 4;
            this.roleLab.Text = "label4";
            // 
            // fioLab
            // 
            this.fioLab.Location = new System.Drawing.Point(553, 13);
            this.fioLab.Name = "fioLab";
            this.fioLab.Size = new System.Drawing.Size(154, 13);
            this.fioLab.TabIndex = 4;
            this.fioLab.Text = "label4";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.exitButton.Location = new System.Drawing.Point(713, 13);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Назад";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLab
            // 
            this.titleLab.AutoSize = true;
            this.titleLab.Location = new System.Drawing.Point(66, 13);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(35, 13);
            this.titleLab.TabIndex = 2;
            this.titleLab.Text = "label1";
            // 
            // logoPicBox
            // 
            this.logoPicBox.Image = global::Miracle_Footwear.Properties.Resources.logo;
            this.logoPicBox.Location = new System.Drawing.Point(10, 10);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(50, 50);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicBox.TabIndex = 0;
            this.logoPicBox.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(678, 13);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(110, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Сохранить дату";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Location = new System.Drawing.Point(536, 13);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(110, 23);
            this.deleteItemBtn.TabIndex = 3;
            this.deleteItemBtn.Text = "Удалить позицию";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // totalSumLab
            // 
            this.totalSumLab.AutoSize = true;
            this.totalSumLab.Location = new System.Drawing.Point(244, 18);
            this.totalSumLab.Name = "totalSumLab";
            this.totalSumLab.Size = new System.Drawing.Size(93, 13);
            this.totalSumLab.TabIndex = 2;
            this.totalSumLab.Text = "Итого по заказу:";
            // 
            // orderProductDataGridView
            // 
            this.orderProductDataGridView.AllowUserToAddRows = false;
            this.orderProductDataGridView.AllowUserToDeleteRows = false;
            this.orderProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrderProduct,
            this.modelText,
            this.Size,
            this.Amount,
            this.OrderProductPrice});
            this.orderProductDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderProductDataGridView.Location = new System.Drawing.Point(0, 45);
            this.orderProductDataGridView.Name = "orderProductDataGridView";
            this.orderProductDataGridView.ReadOnly = true;
            this.orderProductDataGridView.Size = new System.Drawing.Size(800, 331);
            this.orderProductDataGridView.TabIndex = 1;
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDatePicker.Location = new System.Drawing.Point(12, 12);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDatePicker.TabIndex = 0;
            // 
            // IdOrderProduct
            // 
            this.IdOrderProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdOrderProduct.HeaderText = "idOrderProduct";
            this.IdOrderProduct.Name = "IdOrderProduct";
            this.IdOrderProduct.ReadOnly = true;
            this.IdOrderProduct.Visible = false;
            // 
            // modelText
            // 
            this.modelText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelText.HeaderText = "Модель";
            this.modelText.Name = "modelText";
            this.modelText.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size.HeaderText = "Размер";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.HeaderText = "Количество";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // OrderProductPrice
            // 
            this.OrderProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderProductPrice.HeaderText = "Цена единицы";
            this.OrderProductPrice.Name = "OrderProductPrice";
            this.OrderProductPrice.ReadOnly = true;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label roleLab;
        private System.Windows.Forms.Label fioLab;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLab;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.DateTimePicker orderDatePicker;
        private System.Windows.Forms.DataGridView orderProductDataGridView;
        private System.Windows.Forms.Label totalSumLab;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrderProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderProductPrice;
    }
}