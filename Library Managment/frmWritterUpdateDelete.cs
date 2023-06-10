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

namespace Library_Managment
{
    public partial class frmWritterUpdateDelete : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=Libarary;Trusted_Connection=True");
        public frmWritterUpdateDelete()
        {
            InitializeComponent();
        }

        private void frmWritterUpdateDelete_Load(object sender, EventArgs e)
        {
            LoadPublish();
            
        }

        private void LoadPublish()
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
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicture.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);


            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE writters SET writterName=@n,writterContact=@c,writterEmail=@e,picture=@p,PublisherId=@s WHERE writterId=@i";
            cmd.Parameters.AddWithValue("@i", txtSearch.Text);
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@c", txtContact.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@s", cmbPublisher.SelectedValue);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Updated successfully!!!";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT writterId,writterName,writterContact,writterEmail,picture,PublisherId FROM writters WHERE writterId=@i";
            cmd.Parameters.AddWithValue("@i", txtSearch.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0][1].ToString();
                txtContact.Text = dt.Rows[0][2].ToString();
                txtEmail.Text = dt.Rows[0][3].ToString();
                cmbPublisher.SelectedValue = dt.Rows[0][5].ToString();
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][4]);
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicture.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);


            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM writters WHERE writterName=@n,writterContact=@c,writterEmail=@e,picture=@p,PublisherId=@s WHERE writterId=@i";
            cmd.Parameters.AddWithValue("@i", txtSearch.Text);
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@c", txtContact.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@s", cmbPublisher.SelectedValue);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Deleted successfully!!!";
            con.Close();
        }
    }
}
