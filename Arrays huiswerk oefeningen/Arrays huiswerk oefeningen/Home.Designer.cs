namespace Arrays_huiswerk_oefeningen
{
    partial class frmHome
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
            this.btn7Numbers = new System.Windows.Forms.Button();
            this.btn7RandomNumbers = new System.Windows.Forms.Button();
            this.btnFruit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn7Numbers
            // 
            this.btn7Numbers.Location = new System.Drawing.Point(12, 12);
            this.btn7Numbers.Name = "btn7Numbers";
            this.btn7Numbers.Size = new System.Drawing.Size(101, 50);
            this.btn7Numbers.TabIndex = 0;
            this.btn7Numbers.Text = "7 getallen";
            this.btn7Numbers.UseVisualStyleBackColor = true;
            this.btn7Numbers.Click += new System.EventHandler(this.btn7Numbers_Click);
            // 
            // btn7RandomNumbers
            // 
            this.btn7RandomNumbers.Location = new System.Drawing.Point(119, 12);
            this.btn7RandomNumbers.Name = "btn7RandomNumbers";
            this.btn7RandomNumbers.Size = new System.Drawing.Size(101, 50);
            this.btn7RandomNumbers.TabIndex = 1;
            this.btn7RandomNumbers.Text = "7 random getallen";
            this.btn7RandomNumbers.UseVisualStyleBackColor = true;
            this.btn7RandomNumbers.Click += new System.EventHandler(this.btn7RandomNumbers_Click);
            // 
            // btnFruit
            // 
            this.btnFruit.Location = new System.Drawing.Point(226, 12);
            this.btnFruit.Name = "btnFruit";
            this.btnFruit.Size = new System.Drawing.Size(101, 50);
            this.btnFruit.TabIndex = 2;
            this.btnFruit.Text = "Fruit";
            this.btnFruit.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(278, 160);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 13);
            this.lblTime.TabIndex = 51;
            this.lblTime.Text = "...";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 160);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(16, 13);
            this.lblDate.TabIndex = 50;
            this.lblDate.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 50);
            this.button1.TabIndex = 54;
            this.button1.Text = "Afsluiten";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnFruit);
            this.Controls.Add(this.btn7RandomNumbers);
            this.Controls.Add(this.btn7Numbers);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7Numbers;
        private System.Windows.Forms.Button btn7RandomNumbers;
        private System.Windows.Forms.Button btnFruit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button button1;
    }
}

