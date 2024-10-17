using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_centr
{
    public partial class Authoriz : Form
    {
        public Authoriz()
        {
            InitializeComponent();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Vhod_button_Click(object sender, EventArgs e)
        {
            Glavnya f2 = new Glavnya();
            f2.Show();
            this.Hide();
        }
    }
}
