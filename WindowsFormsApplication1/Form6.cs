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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2();
            frm.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2();
            frm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Drugs VALUES (@MedID,@MedName,@MedQty,@MedType,@DOB)", con);

            cmd.Parameters.AddWithValue("@MedID", textBox5.Text);
            cmd.Parameters.AddWithValue("@MedName", textBox2.Text);
            cmd.Parameters.AddWithValue("@MedQty", textBox1.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@MedType", comboBox1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                SqlConnection Con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;

                cmd.CommandText = "Select * from Drugs where MedID = " + textBox7.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Drugs set MedID=@MedID,MedName=@MedName,MedQty=@MedQty,MedType=@MedType,Date=@Date,", con);

            cmd.Parameters.AddWithValue("@MedID", textBox5.Text);
            cmd.Parameters.AddWithValue("@MedName", textBox2.Text);
            cmd.Parameters.AddWithValue("@MedQty", textBox1.Text);
            cmd.Parameters.AddWithValue("@MedType", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
           
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated...");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Drugs set MedID=@MedID,MedName=@MedName,MedQty=@MedQty,MedType=@MedType,Date=@Date,", con);

            cmd.Parameters.AddWithValue("@MedID", textBox5.Text);
            cmd.Parameters.AddWithValue("@MedName", textBox2.Text);
            cmd.Parameters.AddWithValue("@MedQty", textBox1.Text);
            cmd.Parameters.AddWithValue("@MedType", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated...");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {

                SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Drugs1 where MedID = " + textBox7.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];

            }
            else
            {
                MessageBox.Show("Pleace Enter Some ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your data . Confirm ?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-8OQF5TUK\\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete from Drugs where MedID = " + textBox3.Text + "";

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

                cmd.CommandText = "select * from Drugs";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }
    }
}
