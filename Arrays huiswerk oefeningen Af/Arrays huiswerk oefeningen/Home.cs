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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            Timer Time = new Timer();

            Time.Interval = 1000;
            Time.Tick += new EventHandler(Time_Tick);
            Time.Start();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn7Numbers_Click(object sender, EventArgs e)
        {
            Form _7Numbers = new frm7Numbers();
            _7Numbers.Show();

            Form Home = new frmHome();
            this.Hide();
        }

        private void btn7RandomNumbers_Click(object sender, EventArgs e)
        {
            Form _7RandomNumbers = new frmRandom7Numbers();
            _7RandomNumbers.Show();

            Form Home = new frmHome();
            this.Hide();
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            Form Fruit = new frmFruit();
            Fruit.Show();

            Form Home = new frmHome();
            this.Hide();
        }
    }
}