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
    public partial class frmPublisher : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=Libarary;Trusted_Connection=True");
        private object txtName;
        public frmPublisher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPublisher_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT id,name FROM Publisher";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Publisher(name) VALUES('" + textName.Text + "')", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Inserted successfully!!!";
            LoadGrid();
            con.Close();
            ClearAll();

        }

        private void ClearAll()
        {
            textId.Text = "";
            textName.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Publisher WHERE id=" + textId.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                textName.Text = dt.Rows[0][1].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Publisher SET name='" + textName.Text + "'", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Updated successfully!!!";
            LoadGrid();
            con.Close();
            ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Publisher WHERE id=" + textId.Text + "", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Deleted successfully!!!";
            LoadGrid();
            con.Close();
            ClearAll();
        }
    }
    
}
