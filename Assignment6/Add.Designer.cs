namespace OrderManagement
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.OrderDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GoodsName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GoodsAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GoodsPrice = new System.Windows.Forms.TextBox();
            this.ConfirmAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "：请输入订单号";
            // 
            // OrderID
            // 
            this.OrderID.Location = new System.Drawing.Point(181, 48);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(100, 25);
            this.OrderID.TabIndex = 1;
            this.OrderID.TextChanged += new System.EventHandler(this.OrderID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "：请输入客户名";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(181, 85);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(100, 25);
            this.ClientName.TabIndex = 3;
            // 
            // OrderDate
            // 
            this.OrderDate.Location = new System.Drawing.Point(181, 125);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(100, 25);
            this.OrderDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "：请输入交易时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "：请输入商品名称";
            // 
            // GoodsName
            // 
            this.GoodsName.Location = new System.Drawing.Point(181, 175);
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.Size = new System.Drawing.Size(100, 25);
            this.GoodsName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "：请输入商品数量";
            // 
            // GoodsAmount
            // 
            this.GoodsAmount.Location = new System.Drawing.Point(181, 222);
            this.GoodsAmount.Name = "GoodsAmount";
            this.GoodsAmount.Size = new System.Drawing.Size(100, 25);
            this.GoodsAmount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "：请输入商品价格";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // GoodsPrice
            // 
            this.GoodsPrice.Location = new System.Drawing.Point(181, 265);
            this.GoodsPrice.Name = "GoodsPrice";
            this.GoodsPrice.Size = new System.Drawing.Size(100, 25);
            this.GoodsPrice.TabIndex = 11;
            // 
            // ConfirmAdd
            // 
            this.ConfirmAdd.Location = new System.Drawing.Point(97, 334);
            this.ConfirmAdd.Name = "ConfirmAdd";
            this.ConfirmAdd.Size = new System.Drawing.Size(75, 23);
            this.ConfirmAdd.TabIndex = 12;
            this.ConfirmAdd.Text = "确认添加";
            this.ConfirmAdd.UseVisualStyleBackColor = true;
            this.ConfirmAdd.Click += new System.EventHandler(this.ConfirmAdd_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmAdd);
            this.Controls.Add(this.GoodsPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GoodsAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GoodsName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderID);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox OrderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GoodsName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GoodsAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GoodsPrice;
        private System.Windows.Forms.Button ConfirmAdd;
    }
}