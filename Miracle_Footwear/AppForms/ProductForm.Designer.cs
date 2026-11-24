namespace Miracle_Footwear.AppForms
{
    partial class ProductForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addToOrderBtn = new System.Windows.Forms.Button();
            this.sizeRowLab = new System.Windows.Forms.Label();
            this.descriptionLab = new System.Windows.Forms.Label();
            this.compositionLab = new System.Windows.Forms.Label();
            this.priceLab = new System.Windows.Forms.Label();
            this.categoryLab = new System.Windows.Forms.Label();
            this.manProLab = new System.Windows.Forms.Label();
            this.availableSizesLab = new System.Windows.Forms.Label();
            this.addToCardBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(434, 450);
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
            this.panel1.Size = new System.Drawing.Size(434, 70);
            this.panel1.TabIndex = 2;
            // 
            // roleLab
            // 
            this.roleLab.Location = new System.Drawing.Point(187, 23);
            this.roleLab.Name = "roleLab";
            this.roleLab.Size = new System.Drawing.Size(154, 13);
            this.roleLab.TabIndex = 4;
            this.roleLab.Text = "label4";
            // 
            // fioLab
            // 
            this.fioLab.Location = new System.Drawing.Point(187, 10);
            this.fioLab.Name = "fioLab";
            this.fioLab.Size = new System.Drawing.Size(154, 13);
            this.fioLab.TabIndex = 4;
            this.fioLab.Text = "label4";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.exitButton.Location = new System.Drawing.Point(347, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Назад";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLab
            // 
            this.titleLab.Location = new System.Drawing.Point(66, 13);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(115, 47);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.availableSizesLab);
            this.panel2.Controls.Add(this.amountNumeric);
            this.panel2.Controls.Add(this.sizeComboBox);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.addToCardBtn);
            this.panel2.Controls.Add(this.addToOrderBtn);
            this.panel2.Controls.Add(this.sizeRowLab);
            this.panel2.Controls.Add(this.descriptionLab);
            this.panel2.Controls.Add(this.compositionLab);
            this.panel2.Controls.Add(this.priceLab);
            this.panel2.Controls.Add(this.categoryLab);
            this.panel2.Controls.Add(this.manProLab);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 376);
            this.panel2.TabIndex = 0;
            // 
            // amountNumeric
            // 
            this.amountNumeric.Location = new System.Drawing.Point(221, 279);
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(120, 20);
            this.amountNumeric.TabIndex = 20;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(69, 279);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.sizeComboBox.TabIndex = 19;
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(286, 324);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Выйти";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addToOrderBtn
            // 
            this.addToOrderBtn.Location = new System.Drawing.Point(28, 324);
            this.addToOrderBtn.Name = "addToOrderBtn";
            this.addToOrderBtn.Size = new System.Drawing.Size(119, 23);
            this.addToOrderBtn.TabIndex = 17;
            this.addToOrderBtn.Text = "Подтвердить заказ";
            this.addToOrderBtn.UseVisualStyleBackColor = true;
            this.addToOrderBtn.Click += new System.EventHandler(this.addToOrderBtn_Click);
            // 
            // sizeRowLab
            // 
            this.sizeRowLab.AutoSize = true;
            this.sizeRowLab.Location = new System.Drawing.Point(25, 192);
            this.sizeRowLab.Name = "sizeRowLab";
            this.sizeRowLab.Size = new System.Drawing.Size(35, 13);
            this.sizeRowLab.TabIndex = 16;
            this.sizeRowLab.Text = "label6";
            // 
            // descriptionLab
            // 
            this.descriptionLab.Location = new System.Drawing.Point(25, 138);
            this.descriptionLab.Name = "descriptionLab";
            this.descriptionLab.Size = new System.Drawing.Size(380, 54);
            this.descriptionLab.TabIndex = 15;
            this.descriptionLab.Text = "label5";
            // 
            // compositionLab
            // 
            this.compositionLab.Location = new System.Drawing.Point(25, 88);
            this.compositionLab.Name = "compositionLab";
            this.compositionLab.Size = new System.Drawing.Size(380, 50);
            this.compositionLab.TabIndex = 14;
            this.compositionLab.Text = "label4";
            // 
            // priceLab
            // 
            this.priceLab.AutoSize = true;
            this.priceLab.Location = new System.Drawing.Point(25, 64);
            this.priceLab.Name = "priceLab";
            this.priceLab.Size = new System.Drawing.Size(35, 13);
            this.priceLab.TabIndex = 13;
            this.priceLab.Text = "label3";
            // 
            // categoryLab
            // 
            this.categoryLab.AutoSize = true;
            this.categoryLab.Location = new System.Drawing.Point(25, 39);
            this.categoryLab.Name = "categoryLab";
            this.categoryLab.Size = new System.Drawing.Size(35, 13);
            this.categoryLab.TabIndex = 12;
            this.categoryLab.Text = "label2";
            // 
            // manProLab
            // 
            this.manProLab.AutoSize = true;
            this.manProLab.Location = new System.Drawing.Point(25, 16);
            this.manProLab.Name = "manProLab";
            this.manProLab.Size = new System.Drawing.Size(35, 13);
            this.manProLab.TabIndex = 11;
            this.manProLab.Text = "label1";
            // 
            // availableSizesLab
            // 
            this.availableSizesLab.AutoSize = true;
            this.availableSizesLab.Location = new System.Drawing.Point(25, 226);
            this.availableSizesLab.Name = "availableSizesLab";
            this.availableSizesLab.Size = new System.Drawing.Size(35, 13);
            this.availableSizesLab.TabIndex = 21;
            this.availableSizesLab.Text = "label6";
            // 
            // addToCardBtn
            // 
            this.addToCardBtn.Location = new System.Drawing.Point(158, 324);
            this.addToCardBtn.Name = "addToCardBtn";
            this.addToCardBtn.Size = new System.Drawing.Size(119, 23);
            this.addToCardBtn.TabIndex = 17;
            this.addToCardBtn.Text = "Добавить в заказ";
            this.addToCardBtn.UseVisualStyleBackColor = true;
            this.addToCardBtn.Click += new System.EventHandler(this.addToCardBtn_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addToOrderBtn;
        private System.Windows.Forms.Label sizeRowLab;
        private System.Windows.Forms.Label descriptionLab;
        private System.Windows.Forms.Label compositionLab;
        private System.Windows.Forms.Label priceLab;
        private System.Windows.Forms.Label categoryLab;
        private System.Windows.Forms.Label manProLab;
        private System.Windows.Forms.Label availableSizesLab;
        private System.Windows.Forms.Button addToCardBtn;
    }
}