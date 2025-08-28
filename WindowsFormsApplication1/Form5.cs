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

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Customer1 VALUES (@Name,@Email,@Id,@Address,@Mobile)", con);

            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox7.Text);
            cmd.Parameters.AddWithValue("@Id", textBox8.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.Parameters.AddWithValue("@Mobile", textBox6.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved...");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from Customer1 where Id = " + textBox2.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Customer1 set Name=@Name,Email=@Email,Id=@Id,Address=@Address,Mobile=@Mobile", con);

            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox7.Text);
            cmd.Parameters.AddWithValue("@Id", textBox8.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.Parameters.AddWithValue("@Mobile", textBox6.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated...");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Customer1 set Name=@Name,Email=@Email,Id=@Id,Address=@Address,Mobile=@Mobile", con);

            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox7.Text);
            cmd.Parameters.AddWithValue("@Id", textBox8.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.Parameters.AddWithValue("@Mobile", textBox6.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your data . Confirm ?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete from Customer1 where Id = " + textBox3.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
            else
            {
                this.Activate();
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Customer1";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }
    }
}
