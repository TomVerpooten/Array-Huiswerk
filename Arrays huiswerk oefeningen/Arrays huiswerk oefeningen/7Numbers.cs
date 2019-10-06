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
    public partial class frm7Numbers : Form
    {
        public List<int> arrNumber = new List<int>();

        public frm7Numbers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strNumber;
            int intNumber, intCountedNumber;

            strNumber = txtNumber.Text;

            if (strNumber.Count() == 2)
            {
                intNumber = Convert.ToInt32(strNumber.Substring(0, 2));
                arrNumber.Add(intNumber);
            }

            else
            {
                if (strNumber.Count() == 1)
                {
                    intNumber = Convert.ToInt32(strNumber.Substring(0, 1));
                    arrNumber.Add(intNumber);
                }

                else
                {
                    MessageBox.Show("Gelieve een getal in te vullen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            txtNumber.Text = string.Empty;

            if (arrNumber.Count() == 7)
            {
                intCountedNumber = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Het hoeveelste getal van de 7 wil je terug zien?", "Numbers", "", 0, 0)) - 1;
                intCountedNumber = arrNumber[intCountedNumber];

                MessageBox.Show("Het " + intCountedNumber.ToString() + " getal dat je hebt opgegeven is " + intCountedNumber.ToString(), "Getal", MessageBoxButtons.OK);
            }
        }
    }
}