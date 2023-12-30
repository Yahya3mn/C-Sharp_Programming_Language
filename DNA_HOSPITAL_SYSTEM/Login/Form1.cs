using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;


namespace Login
{
    public partial class Form1 : Form
    {

        private readonly string connectionString = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\DNAHS.accdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nametxt.Text == "" || Passtxt.Text == "")
            {
                MessageBox.Show("Enter a User name and Password");
            }
            else
            {
                using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\yahya\Documents\DNAHS.accdb"))
                {
                    con.Open();

                    string query = "SELECT DoctorPass FROM doctor WHERE DocName=@DocName";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DocName", Nametxt.Text);

                        // Retrieve hashed password from the database
                        object hashedPassword = cmd.ExecuteScalar();

                        if (hashedPassword != null)
                        {
                            // Hash the entered password for comparison
                            string enteredPasswordHash = ComputeHash(Passtxt.Text);

                            // Compare the hashed entered password with the stored hash in the database
                            if (enteredPasswordHash == hashedPassword.ToString())
                            {
                                MessageBox.Show("Login Successful");

                                Home h = new Home();
                                h.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid User name or Password");
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid User name or Password");
                            con.Close();
                        }
                    }
                }
            }

        }

        // Function to compute SHA-256 hash
        private string ComputeHash(string input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }



        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Nametxt.Text = "";
            Passtxt.Text = "";
        }
    }
}
