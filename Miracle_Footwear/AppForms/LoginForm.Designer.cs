namespace Miracle_Footwear.AppForms
{
    partial class LoginForm
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
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.loginLab = new System.Windows.Forms.Label();
            this.loginTxb = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.titleLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.loginBtn);
            this.splitContainer1.Panel2.Controls.Add(this.loginTxb);
            this.splitContainer1.Panel2.Controls.Add(this.loginLab);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.titleLab);
            this.panel1.Controls.Add(this.logoPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 2;
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
            // loginLab
            // 
            this.loginLab.AutoSize = true;
            this.loginLab.Location = new System.Drawing.Point(242, 154);
            this.loginLab.Name = "loginLab";
            this.loginLab.Size = new System.Drawing.Size(38, 13);
            this.loginLab.TabIndex = 0;
            this.loginLab.Text = "Логин";
            // 
            // loginTxb
            // 
            this.loginTxb.Location = new System.Drawing.Point(286, 151);
            this.loginTxb.Name = "loginTxb";
            this.loginTxb.Size = new System.Drawing.Size(248, 20);
            this.loginTxb.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.loginBtn.Location = new System.Drawing.Point(245, 191);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(289, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Вход";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // titleLab
            // 
            this.titleLab.AutoSize = true;
            this.titleLab.Location = new System.Drawing.Point(66, 13);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(35, 13);
            this.titleLab.TabIndex = 1;
            this.titleLab.Text = "label1";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.TextBox loginTxb;
        private System.Windows.Forms.Label loginLab;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label titleLab;
    }
}