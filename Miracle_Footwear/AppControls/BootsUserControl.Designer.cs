namespace Miracle_Footwear
{
    partial class BootsUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.priceLab = new System.Windows.Forms.Label();
            this.manProLab = new System.Windows.Forms.Label();
            this.categoryLab = new System.Windows.Forms.Label();
            this.countLab = new System.Windows.Forms.Label();
            this.compositionLab = new System.Windows.Forms.Label();
            this.photoPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // priceLab
            // 
            this.priceLab.AutoSize = true;
            this.priceLab.Location = new System.Drawing.Point(617, 56);
            this.priceLab.Name = "priceLab";
            this.priceLab.Size = new System.Drawing.Size(35, 13);
            this.priceLab.TabIndex = 1;
            this.priceLab.Text = "label1";
            this.priceLab.Click += new System.EventHandler(this.photoPicBox_Click);
            // 
            // manProLab
            // 
            this.manProLab.Location = new System.Drawing.Point(126, 20);
            this.manProLab.Name = "manProLab";
            this.manProLab.Size = new System.Drawing.Size(485, 36);
            this.manProLab.TabIndex = 2;
            this.manProLab.Text = "label1";
            this.manProLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.manProLab.Click += new System.EventHandler(this.photoPicBox_Click);
            // 
            // categoryLab
            // 
            this.categoryLab.AutoSize = true;
            this.categoryLab.Location = new System.Drawing.Point(126, 56);
            this.categoryLab.Name = "categoryLab";
            this.categoryLab.Size = new System.Drawing.Size(35, 13);
            this.categoryLab.TabIndex = 1;
            this.categoryLab.Text = "label1";
            this.categoryLab.Click += new System.EventHandler(this.photoPicBox_Click);
            // 
            // countLab
            // 
            this.countLab.AutoSize = true;
            this.countLab.Location = new System.Drawing.Point(126, 69);
            this.countLab.Name = "countLab";
            this.countLab.Size = new System.Drawing.Size(35, 13);
            this.countLab.TabIndex = 1;
            this.countLab.Text = "label1";
            this.countLab.Click += new System.EventHandler(this.photoPicBox_Click);
            // 
            // compositionLab
            // 
            this.compositionLab.Location = new System.Drawing.Point(126, 82);
            this.compositionLab.Name = "compositionLab";
            this.compositionLab.Size = new System.Drawing.Size(485, 38);
            this.compositionLab.TabIndex = 1;
            this.compositionLab.Text = "label1";
            this.compositionLab.Click += new System.EventHandler(this.photoPicBox_Click);
            // 
            // photoPicBox
            // 
            this.photoPicBox.Location = new System.Drawing.Point(20, 20);
            this.photoPicBox.Name = "photoPicBox";
            this.photoPicBox.Size = new System.Drawing.Size(100, 100);
            this.photoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPicBox.TabIndex = 0;
            this.photoPicBox.TabStop = false;
            this.photoPicBox.Click += new System.EventHandler(this.photoPicBox_Click);
            // 
            // BootsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.manProLab);
            this.Controls.Add(this.compositionLab);
            this.Controls.Add(this.countLab);
            this.Controls.Add(this.categoryLab);
            this.Controls.Add(this.priceLab);
            this.Controls.Add(this.photoPicBox);
            this.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.Name = "BootsUserControl";
            this.Size = new System.Drawing.Size(738, 138);
            this.Click += new System.EventHandler(this.photoPicBox_Click);
            ((System.ComponentModel.ISupportInitialize)(this.photoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox photoPicBox;
        private System.Windows.Forms.Label priceLab;
        private System.Windows.Forms.Label manProLab;
        private System.Windows.Forms.Label categoryLab;
        private System.Windows.Forms.Label countLab;
        private System.Windows.Forms.Label compositionLab;
    }
}
