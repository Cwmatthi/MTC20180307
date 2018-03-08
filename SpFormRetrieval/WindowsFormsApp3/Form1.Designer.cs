namespace WindowsFormsApp3
{
    partial class Form1
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
            this.VendorGrid = new System.Windows.Forms.DataGridView();
            this.LoadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VendorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // VendorGrid
            // 
            this.VendorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendorGrid.Location = new System.Drawing.Point(13, 13);
            this.VendorGrid.Name = "VendorGrid";
            this.VendorGrid.Size = new System.Drawing.Size(472, 232);
            this.VendorGrid.TabIndex = 0;
            this.VendorGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendorGrid_CellContentClick);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(395, 260);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(90, 25);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Load Data";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 297);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.VendorGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VendorGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VendorGrid;
        private System.Windows.Forms.Button LoadBtn;
    }
}

