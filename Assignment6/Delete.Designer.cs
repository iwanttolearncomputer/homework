namespace OrderManagement
{
    partial class Delete
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
            this.DeleteID = new System.Windows.Forms.TextBox();
            this.ConfirmDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "：请出入要删除订单的订单号";
            // 
            // DeleteID
            // 
            this.DeleteID.Location = new System.Drawing.Point(259, 87);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Size = new System.Drawing.Size(100, 25);
            this.DeleteID.TabIndex = 1;
            // 
            // ConfirmDelete
            // 
            this.ConfirmDelete.Location = new System.Drawing.Point(169, 159);
            this.ConfirmDelete.Name = "ConfirmDelete";
            this.ConfirmDelete.Size = new System.Drawing.Size(75, 23);
            this.ConfirmDelete.TabIndex = 2;
            this.ConfirmDelete.Text = "确认删除";
            this.ConfirmDelete.UseVisualStyleBackColor = true;
            this.ConfirmDelete.Click += new System.EventHandler(this.ConfirmDelete_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmDelete);
            this.Controls.Add(this.DeleteID);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteID;
        private System.Windows.Forms.Button ConfirmDelete;
    }
}