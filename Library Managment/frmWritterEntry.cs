using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Managment
{
    public partial class frmWritterEntry : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=Libarary;Trusted_Connection=True");
        public frmWritterEntry()
        {
            InitializeComponent();
        }

        private void frmWritterEntry_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT id,name FROM Publisher";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbPublisher.DataSource = ds.Tables[0];
            cmbPublisher.DisplayMember = "name";
            cmbPublisher.ValueMember = "id";
            con.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicture.Text = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicture.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);


            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO writters(writterName,writterContact,writterEmail,picture,PublisherId) VALUES(@n,@c,@e,@p,@s)";
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@c", txtContact.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@s", cmbPublisher.SelectedValue);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Inserted successfully!!!";
            con.Close();
            ClosedAll();
            
        }

        private void ClosedAll()
        {
            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            cmbPublisher.Text = "";
            txtPicture.Text = "";
            pictureBox1.Text = "";
        }
    }
}
