namespace CABCustomer.Control.View
{
    partial class CustomerDetailForm
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
            this.components = new System.ComponentModel.Container();
            this.lbxFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lbxLastName = new System.Windows.Forms.Label();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.lbxFullName = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lbxAddress = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxFirstName
            // 
            this.lbxFirstName.AutoSize = true;
            this.lbxFirstName.Location = new System.Drawing.Point(32, 34);
            this.lbxFirstName.Name = "lbxFirstName";
            this.lbxFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbxFirstName.TabIndex = 0;
            this.lbxFirstName.Text = "First Name";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FirstName", true));
            this.tbxFirstName.Location = new System.Drawing.Point(101, 31);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(153, 20);
            this.tbxFirstName.TabIndex = 1;
            // 
            // tbxLastName
            // 
            this.tbxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "LastName", true));
            this.tbxLastName.Location = new System.Drawing.Point(101, 75);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(153, 20);
            this.tbxLastName.TabIndex = 3;
            // 
            // lbxLastName
            // 
            this.lbxLastName.AutoSize = true;
            this.lbxLastName.Location = new System.Drawing.Point(32, 78);
            this.lbxLastName.Name = "lbxLastName";
            this.lbxLastName.Size = new System.Drawing.Size(58, 13);
            this.lbxLastName.TabIndex = 2;
            this.lbxLastName.Text = "Last Name";
            // 
            // tbxFullName
            // 
            this.tbxFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FullName", true));
            this.tbxFullName.Location = new System.Drawing.Point(100, 121);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(153, 20);
            this.tbxFullName.TabIndex = 5;
            // 
            // lbxFullName
            // 
            this.lbxFullName.AutoSize = true;
            this.lbxFullName.Location = new System.Drawing.Point(31, 124);
            this.lbxFullName.Name = "lbxFullName";
            this.lbxFullName.Size = new System.Drawing.Size(54, 13);
            this.lbxFullName.TabIndex = 4;
            this.lbxFullName.Text = "Full Name";
            // 
            // tbxAddress
            // 
            this.tbxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.tbxAddress.Location = new System.Drawing.Point(101, 166);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(153, 20);
            this.tbxAddress.TabIndex = 7;
            // 
            // lbxAddress
            // 
            this.lbxAddress.AutoSize = true;
            this.lbxAddress.Location = new System.Drawing.Point(32, 169);
            this.lbxAddress.Name = "lbxAddress";
            this.lbxAddress.Size = new System.Drawing.Size(45, 13);
            this.lbxAddress.TabIndex = 6;
            this.lbxAddress.Text = "Address";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(CABCustomer.Model.Customer);
            // 
            // CustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lbxAddress);
            this.Controls.Add(this.tbxFullName);
            this.Controls.Add(this.lbxFullName);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lbxFirstName);
            this.Name = "CustomerDetailForm";
            this.Size = new System.Drawing.Size(284, 219);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbxFirstName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lbxLastName;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Label lbxFullName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lbxAddress;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}