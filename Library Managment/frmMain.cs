using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            frm.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPublisher fs = new frmPublisher();
            fs.Show();
            fs.MdiParent = this;
        }

        private void writterEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWritterEntry fte = new frmWritterEntry();
            fte.Show();
            fte.MdiParent = this;
        }

        private void writterUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWritterUpdateDelete fte = new frmWritterUpdateDelete();
            fte.Show();
            fte.MdiParent = this;
        }

        private void writterViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWritterView ft = new frmWritterView();
            ft.Show();
            ft.MdiParent = this;
        }

        private void writterInformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport fv = new frmReport();
            fv.Show();
            fv.MdiParent = this;
        }
    }
}
