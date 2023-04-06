namespace OrderManagement
{
    partial class Search
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
            this.SearchKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Result = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowAll = new System.Windows.Forms.Button();
            this.SearchByID = new System.Windows.Forms.Button();
            this.SearchByClient = new System.Windows.Forms.Button();
            this.SearchByDate = new System.Windows.Forms.Button();
            this.SearchBySum = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.SearchKey);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 452);
            this.panel1.TabIndex = 0;
            // 
            // SearchKey
            // 
            this.SearchKey.Location = new System.Drawing.Point(155, 64);
            this.SearchKey.Name = "SearchKey";
            this.SearchKey.Size = new System.Drawing.Size(100, 25);
            this.SearchKey.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "：查询关键字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "请选择按什么查询";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Result);
            this.panel2.Location = new System.Drawing.Point(0, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 265);
            this.panel2.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result.Location = new System.Drawing.Point(3, 6);
            this.Result.Name = "Result";
            this.Result.RowHeadersWidth = 51;
            this.Result.RowTemplate.Height = 27;
            this.Result.Size = new System.Drawing.Size(796, 259);
            this.Result.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用查询功能";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.ShowAll);
            this.flowLayoutPanel1.Controls.Add(this.SearchByID);
            this.flowLayoutPanel1.Controls.Add(this.SearchByClient);
            this.flowLayoutPanel1.Controls.Add(this.SearchByDate);
            this.flowLayoutPanel1.Controls.Add(this.SearchBySum);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(799, 61);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(662, 3);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(134, 45);
            this.ShowAll.TabIndex = 0;
            this.ShowAll.Text = "显示所有订单";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // SearchByID
            // 
            this.SearchByID.Location = new System.Drawing.Point(546, 3);
            this.SearchByID.Name = "SearchByID";
            this.SearchByID.Size = new System.Drawing.Size(110, 45);
            this.SearchByID.TabIndex = 1;
            this.SearchByID.Text = "按订单号查询";
            this.SearchByID.UseVisualStyleBackColor = true;
            this.SearchByID.Click += new System.EventHandler(this.SearchByID_Click);
            // 
            // SearchByClient
            // 
            this.SearchByClient.Location = new System.Drawing.Point(420, 3);
            this.SearchByClient.Name = "SearchByClient";
            this.SearchByClient.Size = new System.Drawing.Size(120, 45);
            this.SearchByClient.TabIndex = 2;
            this.SearchByClient.Text = "按客户名查询";
            this.SearchByClient.UseVisualStyleBackColor = true;
            this.SearchByClient.Click += new System.EventHandler(this.SearchByClient_Click);
            // 
            // SearchByDate
            // 
            this.SearchByDate.Location = new System.Drawing.Point(274, 3);
            this.SearchByDate.Name = "SearchByDate";
            this.SearchByDate.Size = new System.Drawing.Size(140, 45);
            this.SearchByDate.TabIndex = 3;
            this.SearchByDate.Text = "按交易日期查询";
            this.SearchByDate.UseVisualStyleBackColor = true;
            this.SearchByDate.Click += new System.EventHandler(this.SearchByDate_Click);
            // 
            // SearchBySum
            // 
            this.SearchBySum.Location = new System.Drawing.Point(127, 3);
            this.SearchBySum.Name = "SearchBySum";
            this.SearchBySum.Size = new System.Drawing.Size(141, 45);
            this.SearchBySum.TabIndex = 4;
            this.SearchBySum.Text = "按订单金额查询";
            this.SearchBySum.UseVisualStyleBackColor = true;
            this.SearchBySum.Click += new System.EventHandler(this.SearchBySum_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Search";
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button SearchByID;
        private System.Windows.Forms.Button SearchByClient;
        private System.Windows.Forms.DataGridView Result;
        private System.Windows.Forms.Button SearchByDate;
        private System.Windows.Forms.Button SearchBySum;
        private System.Windows.Forms.TextBox SearchKey;
        private System.Windows.Forms.Label label3;
    }
}