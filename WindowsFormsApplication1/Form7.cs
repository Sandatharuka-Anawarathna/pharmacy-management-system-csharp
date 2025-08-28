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
    public partial class Form7 : Form
    {
        public Form7()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("This will delete your data . Confirm ?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete from Sales where MoneyID = " + textBox2.Text + "";

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

                cmd.CommandText = "select * from Sales";

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
            SqlCommand cmd = new SqlCommand("INSERT INTO Sales VALUES (@MoneyID,@Benefit,@Income,@Spent)", con);

            cmd.Parameters.AddWithValue("@MoneyID", textBox5.Text);
            cmd.Parameters.AddWithValue("@Benefit", textBox8.Text);
            cmd.Parameters.AddWithValue("@Income", textBox3.Text);
            cmd.Parameters.AddWithValue("@Spent", textBox4.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved...");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                SqlConnection Con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;

                cmd.CommandText = "Select * from Sales where MoneyID  = " + textBox7.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
