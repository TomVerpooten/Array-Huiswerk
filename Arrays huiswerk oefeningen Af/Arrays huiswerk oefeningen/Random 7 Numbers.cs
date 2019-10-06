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
    public partial class frmRandom7Numbers : Form
    {
        List<int> arrRandomNumbers = new List<int>();

        public frmRandom7Numbers()
        {
            InitializeComponent();
        }

        private void frmRandom7Numbers_Load(object sender, EventArgs e)
        {
            int intOutput, intLimit, intMaxValue;

            Random rdNumber = new Random();

            for (intLimit = 0; intLimit < 7; intLimit++)
            {
                intOutput = rdNumber.Next(0, 11);
                lbxList.Items.Add(intOutput);
            }

            arrRandomNumbers.Add(Convert.ToInt32(lbxList.Text));

            intMaxValue = arrRandomNumbers.Max();

            txtIndex.Text = arrRandomNumbers.ToList().IndexOf(intMaxValue).ToString();            

            txtLength.Text = intLimit.ToString();
        }
    }
}