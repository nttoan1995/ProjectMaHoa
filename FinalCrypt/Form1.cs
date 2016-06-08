using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dangki_Click(object sender, EventArgs e)
        {
            this.Hide();
            _dangki dk = new _dangki();
            dk.ShowDialog();
            this.Show();
        }
    }
}
