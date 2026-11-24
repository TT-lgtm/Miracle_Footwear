namespace Miracle_Footwear.AppForms
{
    partial class OrdersForm
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
            this.detailsOrderBtn = new System.Windows.Forms.Button();
            this.deleteOrderBtn = new System.Windows.Forms.Button();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.IdOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
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
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.detailsOrderBtn);
            this.splitContainer1.Panel2.Controls.Add(this.deleteOrderBtn);
            this.splitContainer1.Panel2.Controls.Add(this.addOrderBtn);
            this.splitContainer1.Panel2.Controls.Add(this.orderDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 4;
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
            // detailsOrderBtn
            // 
            this.detailsOrderBtn.Location = new System.Drawing.Point(299, 346);
            this.detailsOrderBtn.Name = "detailsOrderBtn";
            this.detailsOrderBtn.Size = new System.Drawing.Size(111, 23);
            this.detailsOrderBtn.TabIndex = 1;
            this.detailsOrderBtn.Text = "Состав заказа";
            this.detailsOrderBtn.UseVisualStyleBackColor = true;
            this.detailsOrderBtn.Click += new System.EventHandler(this.detailsOrderBtn_Click);
            // 
            // deleteOrderBtn
            // 
            this.deleteOrderBtn.Location = new System.Drawing.Point(155, 346);
            this.deleteOrderBtn.Name = "deleteOrderBtn";
            this.deleteOrderBtn.Size = new System.Drawing.Size(111, 23);
            this.deleteOrderBtn.TabIndex = 1;
            this.deleteOrderBtn.Text = "Удалить заказ";
            this.deleteOrderBtn.UseVisualStyleBackColor = true;
            this.deleteOrderBtn.Click += new System.EventHandler(this.deleteOrderBtn_Click);
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Location = new System.Drawing.Point(12, 346);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(111, 23);
            this.addOrderBtn.TabIndex = 1;
            this.addOrderBtn.Text = "Добавить заказ";
            this.addOrderBtn.UseVisualStyleBackColor = true;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrder,
            this.dateOrder,
            this.clientFio,
            this.status});
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.Size = new System.Drawing.Size(800, 340);
            this.orderDataGridView.TabIndex = 0;
            // 
            // IdOrder
            // 
            this.IdOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdOrder.HeaderText = "Код заказа";
            this.IdOrder.Name = "IdOrder";
            this.IdOrder.ReadOnly = true;
            this.IdOrder.Visible = false;
            // 
            // dateOrder
            // 
            this.dateOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOrder.HeaderText = "Дата заказа";
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.ReadOnly = true;
            // 
            // clientFio
            // 
            this.clientFio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientFio.HeaderText = "ФИО клиента";
            this.clientFio.Name = "clientFio";
            this.clientFio.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
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
        private System.Windows.Forms.Button detailsOrderBtn;
        private System.Windows.Forms.Button deleteOrderBtn;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}