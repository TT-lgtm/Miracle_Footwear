namespace Miracle_Footwear.AppForms
{
    partial class MainForm
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
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roleLab = new System.Windows.Forms.Label();
            this.fioLab = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLab = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderBtn = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.priceComboBox = new System.Windows.Forms.ComboBox();
            this.searchTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 326);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.orderBtn);
            this.panel2.Controls.Add(this.categoryComboBox);
            this.panel2.Controls.Add(this.priceComboBox);
            this.panel2.Controls.Add(this.searchTxb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 1;
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.orderBtn.Location = new System.Drawing.Point(713, 14);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 23);
            this.orderBtn.TabIndex = 3;
            this.orderBtn.Text = "Заказы";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(256, 16);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 2;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // priceComboBox
            // 
            this.priceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceComboBox.FormattingEnabled = true;
            this.priceComboBox.Items.AddRange(new object[] {
            "Больше",
            "Меньше"});
            this.priceComboBox.Location = new System.Drawing.Point(51, 16);
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(121, 21);
            this.priceComboBox.TabIndex = 2;
            this.priceComboBox.SelectedIndexChanged += new System.EventHandler(this.priceComboBox_SelectedIndexChanged);
            // 
            // searchTxb
            // 
            this.searchTxb.Location = new System.Drawing.Point(442, 17);
            this.searchTxb.Name = "searchTxb";
            this.searchTxb.Size = new System.Drawing.Size(120, 20);
            this.searchTxb.TabIndex = 1;
            this.searchTxb.TextChanged += new System.EventHandler(this.searchTxb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Категория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label titleLab;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label roleLab;
        private System.Windows.Forms.Label fioLab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox priceComboBox;
        private System.Windows.Forms.TextBox searchTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}