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
using System.Reflection.Emit;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Path of database
        string path = "members.db";
        string cs = $"URI=file:{Application.StartupPath}\\members.db"; // Database created in the debug folder
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void data_show()
        {
            dataGridView1.Rows.Clear();

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                string sql = "SELECT * FROM member";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr["Id"], dr["Name"], dr["Surname"], dr["Mail"], dr["Level"]);
                        }
                    }
                }
            }
        }

        // Create database and table
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);

                using (var sqlite = new SQLiteConnection($"Data Source={path}"))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE member(Id varchar(50), Name varchar(20), Surname varchar(20), Mail varchar(20), [Level] varchar(20))";
                    using (var command = new SQLiteCommand(sql, sqlite))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                Console.WriteLine("Database already exists");
            }
        }

        // Insert Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("INSERT INTO member(Id,Name,Surname,Mail,[Level]) VALUES(@Id,@Name,@Surname,@Mail,@Level)", con))
                {
                    try
                    {
                        string ID = textId.Text;
                        string NAME = textName.Text;
                        string SURNAME = textSurname.Text;
                        string MAIL = textMail.Text;
                        string LEVEL = comboLevel.Text;

                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.Parameters.AddWithValue("@Name", NAME);
                        cmd.Parameters.AddWithValue("@Surname", SURNAME);
                        cmd.Parameters.AddWithValue("@Mail", MAIL);
                        cmd.Parameters.AddWithValue("@Level", LEVEL);

                        dataGridView1.ColumnCount = 5;
                        dataGridView1.Columns[0].Name = "Id";
                        dataGridView1.Columns[1].Name = "Name";
                        dataGridView1.Columns[2].Name = "Surname";
                        dataGridView1.Columns[3].Name = "Mail";
                        dataGridView1.Columns[4].Name = "Level";

                        string[] row = new string[] { ID, NAME, SURNAME, MAIL, LEVEL };
                        dataGridView1.Rows.Add(row);


                        cmd.ExecuteNonQuery();
                        data_show();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot insert data. Error: " + ex.Message);
                    }
                }
            }
        }

        // Update Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("UPDATE member SET Name=@Name, Surname=@Surname, Mail=@Mail, [Level]=@Level WHERE Id=@Id", con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Id", textId.Text);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@Surname", textSurname.Text);
                        cmd.Parameters.AddWithValue("@Mail", textMail.Text);
                        cmd.Parameters.AddWithValue("@Level", comboLevel.Text);

                        cmd.ExecuteNonQuery();
                        data_show();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot update data. Error: " + ex.Message);
                    }
                }
            }
        }

        // Delete Data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("DELETE FROM member WHERE Id=@Id", con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Id", textId.Text);

                        cmd.ExecuteNonQuery();
                        data_show();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot delete data. Error: " + ex.Message);
                    }
                }
            }
        }

        // Show Data
        private void btnShow_Click(object sender, EventArgs e)
        {
            data_show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
        }
    }
}