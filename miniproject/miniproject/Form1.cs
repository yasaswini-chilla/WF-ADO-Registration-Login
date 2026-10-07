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

namespace miniproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
            private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }
            else if (radioButton3.Checked)
            {
                gender = "Others";
            }

            string languages = "";

            if (checkBox1.Checked)
            {
                languages = languages + "English ";
            }

            if (checkBox2.Checked)
            {
                languages = languages + "Telugu ";
            }

            if (checkBox3.Checked)
            {
                languages = languages + "Hindi";
            }

            if (textBox6.Text != textBox5.Text)
            {
                MessageBox.Show("Password and Confirm Password are not same");
                return;
            }


            SqlConnection con = new SqlConnection("Data source = yashuuuu; database = RegistrationDB; integrated security = yes");

            string query = "insert into Users values(@UserId,@FirstName,@LastName,@Username,@Gender,@Password,@ConfirmPassword,@Email,@Phone,@Address,@Age,@Languages,@Country)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@UserId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Username", textBox4.Text);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Password", textBox5.Text);
            cmd.Parameters.AddWithValue("@ConfirmPassword", textBox6.Text);
            cmd.Parameters.AddWithValue("@Email", textBox7.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox8.Text);
            cmd.Parameters.AddWithValue("@Address", textBox9.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Languages", languages);
            cmd.Parameters.AddWithValue("@Country", comboBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Form2 obj = new Form2();
            obj.Show();

            this.Hide();
        }
    }
    }

