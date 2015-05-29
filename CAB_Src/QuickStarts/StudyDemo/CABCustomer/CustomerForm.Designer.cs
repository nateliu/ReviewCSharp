namespace CABCustomer
{
    partial class CustomerForm
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
            this.MainWorkspace = new Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace();
            this.LeftNavWorkspace = new Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace();
            this.SuspendLayout();
            // 
            // MainWorkspace
            // 
            this.MainWorkspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainWorkspace.Location = new System.Drawing.Point(154, 0);
            this.MainWorkspace.Name = "MainWorkspace";
            this.MainWorkspace.Size = new System.Drawing.Size(335, 262);
            this.MainWorkspace.TabIndex = 0;
            this.MainWorkspace.Text = "MainWorkspace";
            // 
            // LeftNavWorkspace
            // 
            this.LeftNavWorkspace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftNavWorkspace.Location = new System.Drawing.Point(0, 0);
            this.LeftNavWorkspace.Name = "LeftNavWorkspace";
            this.LeftNavWorkspace.Size = new System.Drawing.Size(148, 262);
            this.LeftNavWorkspace.TabIndex = 1;
            this.LeftNavWorkspace.Text = "LeftNavWorkspace";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 262);
            this.Controls.Add(this.LeftNavWorkspace);
            this.Controls.Add(this.MainWorkspace);
            this.Name = "CustomerForm";
            this.Text = "CompositeUI Application Block";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace MainWorkspace;
        private Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace LeftNavWorkspace;
    }
}

