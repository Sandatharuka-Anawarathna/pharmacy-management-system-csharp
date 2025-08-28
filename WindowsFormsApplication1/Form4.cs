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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from Employee1 where Id = " + textBox2.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Employee1 VALUES (@Name,@Address,@Id,@Email,@Phone,@DOB,@Marital)", con);

            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.Parameters.AddWithValue("@Id", textBox8.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Email", textBox7.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox6.Text);
            cmd.Parameters.AddWithValue("@Marital", comboBox1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved...");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Employee1 set Name=@Name,Address=@Address,Id=@Id,DOB=@DOB,Email=@Email,Phone=@phone,Marital=@marital", con);

            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.Parameters.AddWithValue("@Id", textBox8.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Email", textBox7.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox6.Text);
            cmd.Parameters.AddWithValue("@Marital", comboBox1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated...");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Employee1 set Name=@Name,Address=@Address,Id=@Id,DOB=@DOB,Email=@Email,Phone=@phone,Marital=@marital", con);

            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.Parameters.AddWithValue("@Id", textBox8.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Email", textBox7.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox6.Text);
            cmd.Parameters.AddWithValue("@Marital", comboBox1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated...");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your data . Confirm ?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete from Employee1 where Id = " + textBox4.Text + "";

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

                cmd.CommandText = "select * Employee1 from ";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }
    }
}
