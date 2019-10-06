namespace Arrays_huiswerk_oefeningen
{
    partial class frmRandom7Numbers
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
            this.lbxList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.Location = new System.Drawing.Point(98, 33);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(70, 95);
            this.lbxList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lengte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoogste rij-index:";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(122, 194);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.ReadOnly = true;
            this.txtIndex.Size = new System.Drawing.Size(100, 20);
            this.txtIndex.TabIndex = 3;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(122, 168);
            this.txtLength.Name = "txtLength";
            this.txtLength.ReadOnly = true;
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 4;
            // 
            // frmRandom7Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 381);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxList);
            this.Name = "frmRandom7Numbers";
            this.Text = "7 random getallen";
            this.Load += new System.EventHandler(this.frmRandom7Numbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtLength;
    }
}