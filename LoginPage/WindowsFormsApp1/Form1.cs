using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string dbName = "users.db";
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = users.db");
        public Form1()
        {
            InitializeComponent();
        }

        public void createDatabase()
        {
            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = "CREATE TABLE users(id INTEGER PRIMARY KEY, email varchar(255) not null, password varchar(255) not null, name varchar(255) not null,  address varchar(255) not null,age INTEGER not null)";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = "insert into users(email,password,name,age,address) values(@email, @password, @name, @age, @address)";
                cmd.Parameters.AddWithValue("@email", txtMail.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);
                cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = "select * from users where email=@email AND password=@password";
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                SQLiteDataReader dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    MessageBox.Show("Email or password is incorrect!");
                    return;
                }
                dr.Read();
                Users user1 = new Users(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5));

                Kullanici frm2 = new Kullanici();
                frm2.user = user1;
                this.Visible = false;
                frm2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}