using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_huiswerk_oefeningen
{
    public partial class frmFruit : Form
    {
        public frmFruit()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strInput;

            strInput = txtInput.Text;

            lbxFruit.Items.Add(strInput);
            lbxSortedFruit.Items.Add(strInput);

            txtInput.Text = string.Empty;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lbxSortedFruit.Show();

            lbxSortedFruit.Sorted = true;
        }
    }
}