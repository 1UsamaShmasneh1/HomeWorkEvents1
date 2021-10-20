namespace Question5and6._1
{
    partial class BankForm
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
            this.BankFormPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BankFormPanel
            // 
            this.BankFormPanel.Location = new System.Drawing.Point(2, 0);
            this.BankFormPanel.Name = "BankFormPanel";
            this.BankFormPanel.Size = new System.Drawing.Size(804, 491);
            this.BankFormPanel.TabIndex = 0;
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 490);
            this.Controls.Add(this.BankFormPanel);
            this.Name = "BankForm";
            this.Text = "BankForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BankFormPanel;
    }
}