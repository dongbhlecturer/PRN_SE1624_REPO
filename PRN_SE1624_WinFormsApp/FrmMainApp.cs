using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_SE1624_WinFormsApp
{
    public partial class FrmMainApp : Form
    {
        public FrmMainApp()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitCtrEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. create and initial Object Form Add
            FrmAddProduct f = new FrmAddProduct();
            f.MdiParent = this;

            //2. show
            f.Show();
        }
    }
}
