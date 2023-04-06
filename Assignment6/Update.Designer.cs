namespace OrderManagement
{
    partial class Update
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDBefore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.Customer = new System.Windows.Forms.TextBox();
            this.OrderDate = new System.Windows.Forms.TextBox();
            this.GoodsName = new System.Windows.Forms.TextBox();
            this.GoodsAmount = new System.Windows.Forms.TextBox();
            this.GoodsPrice = new System.Windows.Forms.TextBox();
            this.ConfirmUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConfirmUpdate);
            this.panel1.Controls.Add(this.GoodsPrice);
            this.panel1.Controls.Add(this.GoodsAmount);
            this.panel1.Controls.Add(this.GoodsName);
            this.panel1.Controls.Add(this.OrderDate);
            this.panel1.Controls.Add(this.Customer);
            this.panel1.Controls.Add(this.OrderID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 368);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "修改界面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入要修改的订单号";
            // 
            // IDBefore
            // 
            this.IDBefore.Location = new System.Drawing.Point(186, 63);
            this.IDBefore.Name = "IDBefore";
            this.IDBefore.Size = new System.Drawing.Size(100, 25);
            this.IDBefore.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "请输入修改后的订单号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "请输入修改后的客户名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "请输入修改后的交易时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "请输入修改后的商品名称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "请输入修改后的商品数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "请输入修改后的商品价格";
            // 
            // OrderID
            // 
            this.OrderID.Location = new System.Drawing.Point(297, 36);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(100, 25);
            this.OrderID.TabIndex = 6;
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(297, 73);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(100, 25);
            this.Customer.TabIndex = 7;
            // 
            // OrderDate
            // 
            this.OrderDate.Location = new System.Drawing.Point(297, 116);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(100, 25);
            this.OrderDate.TabIndex = 8;
            // 
            // GoodsName
            // 
            this.GoodsName.Location = new System.Drawing.Point(297, 162);
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.Size = new System.Drawing.Size(100, 25);
            this.GoodsName.TabIndex = 9;
            // 
            // GoodsAmount
            // 
            this.GoodsAmount.Location = new System.Drawing.Point(297, 213);
            this.GoodsAmount.Name = "GoodsAmount";
            this.GoodsAmount.Size = new System.Drawing.Size(100, 25);
            this.GoodsAmount.TabIndex = 10;
            // 
            // GoodsPrice
            // 
            this.GoodsPrice.Location = new System.Drawing.Point(297, 249);
            this.GoodsPrice.Name = "GoodsPrice";
            this.GoodsPrice.Size = new System.Drawing.Size(100, 25);
            this.GoodsPrice.TabIndex = 11;
            // 
            // ConfirmUpdate
            // 
            this.ConfirmUpdate.Location = new System.Drawing.Point(174, 310);
            this.ConfirmUpdate.Name = "ConfirmUpdate";
            this.ConfirmUpdate.Size = new System.Drawing.Size(93, 41);
            this.ConfirmUpdate.TabIndex = 12;
            this.ConfirmUpdate.Text = "确认修改";
            this.ConfirmUpdate.UseVisualStyleBackColor = true;
            this.ConfirmUpdate.Click += new System.EventHandler(this.ConfirmUpdate_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDBefore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Update";
            this.Text = "Update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDBefore;
        private System.Windows.Forms.Button ConfirmUpdate;
        private System.Windows.Forms.TextBox GoodsPrice;
        private System.Windows.Forms.TextBox GoodsAmount;
        private System.Windows.Forms.TextBox GoodsName;
        private System.Windows.Forms.TextBox OrderDate;
        private System.Windows.Forms.TextBox Customer;
        private System.Windows.Forms.TextBox OrderID;
    }
}