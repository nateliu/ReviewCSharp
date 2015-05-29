namespace CABCustomer.Control.View
{
    partial class CustomerListForm
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
            this.customerList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // customerList
            // 
            this.customerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(0, 0);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(284, 262);
            this.customerList.TabIndex = 0;
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerList);
            this.Name = "CustomerListForm";
            this.Size = new System.Drawing.Size(284, 262);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox customerList;
    }
}