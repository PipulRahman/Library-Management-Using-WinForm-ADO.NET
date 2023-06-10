using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Library_Managment
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=Libarary;Trusted_Connection=True");
        private object txtName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT id,name FROM Publisher";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            colpublisher.DataSource = ds.Tables[0];
            colpublisher.DisplayMember = "name";
            colpublisher.ValueMember = "id";
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlTransaction ts = con.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = ts;
                cmd.CommandText = "INSERT INTO Book(name,Price) VALUES(@name,@Price) SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("@name", textBook.Text);
                cmd.Parameters.AddWithValue("@Price", textPrice.Text);
                int id = Convert.ToInt32(cmd.ExecuteScalar());

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["colpublisher"].Value != null && dataGridView1.Rows[i].Cells["colstock"].Value != null)
                    {
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;
                        cmd2.Transaction = ts;
                        cmd2.CommandText = "INSERT INTO Stock(BookId,PublisherId,Stock) VALUES(@BookId,@PublisherId,@Stock)";
                        cmd2.Parameters.AddWithValue("@BookId", id);
                        cmd2.Parameters.AddWithValue("@PublisherId", dataGridView1.Rows[i].Cells["colpublisher"].Value);
                        cmd2.Parameters.AddWithValue("@Stock", dataGridView1.Rows[i].Cells["colstock"].Value);
                        cmd2.ExecuteNonQuery();
                    }
                }
                ts.Commit();
                MessageBox.Show("Data Inserted successfully!!!");
            }
            catch (Exception ex)
            {
                ts.Rollback();
                MessageBox.Show(ex.Message + "\nData not saved!!!");
            }
            con.Close();
            ClearAll();
        }

        private void ClearAll()
        {
            textBook.Text = "";
            textPrice.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
