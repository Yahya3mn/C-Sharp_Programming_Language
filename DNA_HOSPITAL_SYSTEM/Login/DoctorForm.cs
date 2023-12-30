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
    public partial class DoctorForm : Form
    {

        private readonly string connectionString = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\DNAHS.accdb";
        public DoctorForm()
        {
            InitializeComponent();
        }

        //Show Data
        private void showInfo()
        {
            listView1.Items.Clear();
            using(var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using(var cmd = new  OleDbCommand("SELECT * FROM doctor", con))
                {
                    using(var dr =  cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                ListViewItem addNew = new ListViewItem();
                                addNew.Text = dr["DocId"].ToString();
                                addNew.SubItems.Add(dr["DocName"].ToString());
                                addNew.SubItems.Add(dr["Experience"].ToString());
                                addNew.SubItems.Add(dr["DoctorPass"].ToString());

                                listView1.Items.Add(addNew);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error loading data into ListView:" +ex.Message);
                        }
                        finally { con.Close(); }
                        
                    }
                }
            }
        }
       
        //Inserting Data
        private void button1_Click(object sender, EventArgs e)
        {
           using(var con = new OleDbConnection(connectionString))
            {
                con.Open() ;
                using(var cmd = new OleDbCommand("INSERT INTO doctor(DocId,DocName,Experience,DoctorPass) VALUES(@DocId,@DocName,@Experience,@DoctorPass)",con))
                {
                    try
                    {
                        string ID = DocIdtxt.Text;
                        string NAME = DocNametxt.Text;
                        string EXPERIENCE = DocExptxt.Text;
                        string PASSWORD = Passwordtxt.Text;

                        // Hash the password
                        string hashedPassword = ComputeHash(PASSWORD);

                        cmd.Parameters.AddWithValue("@DocId", ID);
                        cmd.Parameters.AddWithValue("@DocName", NAME);
                        cmd.Parameters.AddWithValue("@Experience", EXPERIENCE);
                        cmd.Parameters.AddWithValue("@DoctorPass", hashedPassword);

                        cmd.ExecuteNonQuery();

                        ListViewItem newItem = new ListViewItem(ID);
                        newItem.SubItems.Add(NAME);
                        newItem.SubItems.Add(EXPERIENCE);
                        newItem.SubItems.Add(hashedPassword); // Store hashed password in the ListView

                        MessageBox.Show("Doctor successfully added");

                        showInfo();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Cannot insert data. Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
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


        //Update Data
        private void button2_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand("UPDATE doctor SET DocName=?, Experience=?, DoctorPass=? WHERE DocId=?", con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@DocName", DocNametxt.Text);
                        cmd.Parameters.AddWithValue("@Experience", DocExptxt.Text);
                        cmd.Parameters.AddWithValue("@DoctorPass", Passwordtxt.Text);
                        cmd.Parameters.AddWithValue("@DocId", DocIdtxt.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Doctor updated successfully");

                            showInfo();
                        }
                        else
                        {
                            MessageBox.Show("No matching record found for the provided Doctor Id");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot update data. Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }



        //Delete Codes
        private void button4_Click(object sender, EventArgs e)
        {
            if (DocIdtxt.Text == "")
            {
                MessageBox.Show("Please enter doctor Id");
            }
            else
            {
                using (var con = new OleDbConnection(connectionString))
                {
                    con.Open();

                    using (var cmd = new OleDbCommand("DELETE FROM doctor WHERE DocId=@DocId", con))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@DocId", DocIdtxt.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Doctor successfully deleted");
                                showInfo();
                            }
                            else
                            {
                                MessageBox.Show("No matching record found with the provided Doctor Id");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Cannot delete data. Error: " + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            showInfo(); 
        }

       

        //Selected Columns
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                
                string selectedId = listView1.SelectedItems[0].SubItems[0].Text;
                string selectedName = listView1.SelectedItems[0].SubItems[1].Text;
                string selectedExperience = listView1.SelectedItems[0].SubItems[2].Text;
                string selectedPassword = listView1.SelectedItems[0].SubItems[3].Text;

                
                DocIdtxt.Text = selectedId;
                DocNametxt.Text = selectedName;
                DocExptxt.Text = selectedExperience;
                Passwordtxt.Text = selectedPassword;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
