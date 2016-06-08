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
    public partial class _dangki : Form
    {
        public _dangki()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            for (int i = 0; i <= 2000; i++)
            {
                // do something
                //.....
                //thi hành tăng ProgressBar
                progressBar1.PerformStep();
            }
            MessageBox.Show("Hoàn tất đăng kí và phát sinh khóa", "Info", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
