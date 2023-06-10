using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment
{
    public partial class frmWritterView : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=Libarary;Trusted_Connection=True");
        public frmWritterView()
        {
            InitializeComponent();
        }

        private void frmWritterView_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT w.writterId,w.writterName,w.writterContact,w.writterEmail,w.picture,p.name FROM writters w INNER JOIN Publisher p ON w.PublisherId=p.id", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
