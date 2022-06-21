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

namespace library_management
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        string Conn = "Data Source=localhost;Initial Catalog=library;User ID=sa;Password=111967";
        Dashboard db = new Dashboard();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtPassword_DoubleClick(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Clear();
                txtPass.PasswordChar = '*';
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUame.Text == "Username")
            {
                txtUame.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUame.Text == "" && txtPass.Text == "")
                {
                    MessageBox.Show("Please Enter The User Name & Password ");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Conn);
                    SqlCommand cmd = new SqlCommand(" select * from loginforms where Name=@UserName and Pass=@UserPass", con);
                    cmd.Parameters.AddWithValue("@UserName", txtUame.Text);
                    cmd.Parameters.AddWithValue("@UserPass", txtPass.Text);

                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();

                    int count = ds.Tables[0].Rows.Count;


                    if (count == 1)
                    {

                        MessageBox.Show("Succesfully Login, Welcome to Our DashBoard's Library Management");
                        this.Hide();
                        db.Show();

                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password!!! Please Input Again");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

       
    }
}

