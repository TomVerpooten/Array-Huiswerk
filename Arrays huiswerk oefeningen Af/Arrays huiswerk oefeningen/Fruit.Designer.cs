namespace Arrays_huiswerk_oefeningen
{
    partial class frmFruit
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbxFruit = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lbxSortedFruit = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(118, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Toevoegen";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbxFruit
            // 
            this.lbxFruit.FormattingEnabled = true;
            this.lbxFruit.Location = new System.Drawing.Point(12, 51);
            this.lbxFruit.Name = "lbxFruit";
            this.lbxFruit.Size = new System.Drawing.Size(100, 95);
            this.lbxFruit.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(118, 51);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sorteren";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lbxSortedFruit
            // 
            this.lbxSortedFruit.FormattingEnabled = true;
            this.lbxSortedFruit.Location = new System.Drawing.Point(199, 51);
            this.lbxSortedFruit.Name = "lbxSortedFruit";
            this.lbxSortedFruit.Size = new System.Drawing.Size(100, 95);
            this.lbxSortedFruit.TabIndex = 4;
            this.lbxSortedFruit.Visible = false;
            // 
            // frmFruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 381);
            this.Controls.Add(this.lbxSortedFruit);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lbxFruit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInput);
            this.Name = "frmFruit";
            this.Text = "Fruit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lbxFruit;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lbxSortedFruit;
    }
}