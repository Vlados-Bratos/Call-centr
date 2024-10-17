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
    public partial class Glavnya : Form
    {
        public Glavnya()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Authoriz f1 = new Authoriz();
            f1.Show();
            this.Hide();
        }
    }
}
