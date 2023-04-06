namespace OrderManagement
{
    partial class OperateForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectOperation = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddOrder = new System.Windows.Forms.Button();
            this.UpdateOrder = new System.Windows.Forms.Button();
            this.InputOrder = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.SearchOrder = new System.Windows.Forms.Button();
            this.OutputOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.SelectOperation);
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 102);
            this.panel1.TabIndex = 0;
            // 
            // SelectOperation
            // 
            this.SelectOperation.AutoSize = true;
            this.SelectOperation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.SelectOperation.Location = new System.Drawing.Point(3, 67);
            this.SelectOperation.Name = "SelectOperation";
            this.SelectOperation.Size = new System.Drawing.Size(212, 27);
            this.SelectOperation.TabIndex = 1;
            this.SelectOperation.Text = "请选择你要进行的操作";
            // 
            // Welcome
            // 
            this.Welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Welcome.Location = new System.Drawing.Point(324, 21);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(243, 30);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "欢迎使用订单管理系统";
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(357, 102);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(488, 379);
            this.panel3.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AddOrder);
            this.flowLayoutPanel1.Controls.Add(this.UpdateOrder);
            this.flowLayoutPanel1.Controls.Add(this.InputOrder);
            this.flowLayoutPanel1.Controls.Add(this.DeleteOrder);
            this.flowLayoutPanel1.Controls.Add(this.SearchOrder);
            this.flowLayoutPanel1.Controls.Add(this.OutputOrder);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 379);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // AddOrder
            // 
            this.AddOrder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddOrder.Location = new System.Drawing.Point(3, 3);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(105, 52);
            this.AddOrder.TabIndex = 0;
            this.AddOrder.Text = "添加订单";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // UpdateOrder
            // 
            this.UpdateOrder.Location = new System.Drawing.Point(114, 3);
            this.UpdateOrder.Name = "UpdateOrder";
            this.UpdateOrder.Size = new System.Drawing.Size(108, 52);
            this.UpdateOrder.TabIndex = 1;
            this.UpdateOrder.Text = "修改订单";
            this.UpdateOrder.UseVisualStyleBackColor = true;
            this.UpdateOrder.Click += new System.EventHandler(this.UpdateOrder_Click);
            // 
            // InputOrder
            // 
            this.InputOrder.Location = new System.Drawing.Point(228, 3);
            this.InputOrder.Name = "InputOrder";
            this.InputOrder.Size = new System.Drawing.Size(105, 53);
            this.InputOrder.TabIndex = 5;
            this.InputOrder.Text = "导入订单";
            this.InputOrder.UseVisualStyleBackColor = true;
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(3, 62);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(105, 52);
            this.DeleteOrder.TabIndex = 2;
            this.DeleteOrder.Text = "删除订单";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // SearchOrder
            // 
            this.SearchOrder.Location = new System.Drawing.Point(114, 62);
            this.SearchOrder.Name = "SearchOrder";
            this.SearchOrder.Size = new System.Drawing.Size(105, 53);
            this.SearchOrder.TabIndex = 3;
            this.SearchOrder.Text = "查询订单";
            this.SearchOrder.UseVisualStyleBackColor = true;
            this.SearchOrder.Click += new System.EventHandler(this.SearchOrder_Click);
            // 
            // OutputOrder
            // 
            this.OutputOrder.Location = new System.Drawing.Point(225, 62);
            this.OutputOrder.Name = "OutputOrder";
            this.OutputOrder.Size = new System.Drawing.Size(108, 53);
            this.OutputOrder.TabIndex = 4;
            this.OutputOrder.Text = "导出订单";
            this.OutputOrder.UseVisualStyleBackColor = true;
            // 
            // OperateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 481);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "OperateForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button UpdateOrder;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button SearchOrder;
        private System.Windows.Forms.Button OutputOrder;
        private System.Windows.Forms.Button InputOrder;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label SelectOperation;
    }
}

