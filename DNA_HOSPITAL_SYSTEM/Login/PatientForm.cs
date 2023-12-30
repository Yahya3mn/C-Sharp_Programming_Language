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


namespace Login
{
    public partial class PatientForm : Form
    {
        private readonly string connectionString = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\DNAHS.accdb";
        public PatientForm()
        {
            InitializeComponent();
        }
        //Show Data
        private void showPatInfo()
        {
            listView1.Items.Clear();
            using(var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using(var cmd = new  OleDbCommand("SELECT * FROM patient",con))
                {
                    using(var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                ListViewItem addNew = new ListViewItem();
                                addNew.Text = dr["PatId"].ToString();
                                addNew.SubItems.Add(dr["PatName"].ToString());
                                addNew.SubItems.Add(dr["PatAddress"].ToString());
                                addNew.SubItems.Add(dr["PatPhone"].ToString());
                                addNew.SubItems.Add(dr["PatAge"].ToString());
                                addNew.SubItems.Add(dr["PatGender"].ToString());
                                addNew.SubItems.Add(dr["BloodGroup"].ToString());
                                addNew.SubItems.Add(dr["MajorDisease"].ToString());

                                listView1.Items.Add(addNew);
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Error loading data into ListView: " + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }


        // Inserting Data
        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new OleDbCommand("INSERT INTO patient(PatId,PatName,PatAddress,PatPhone,PatAge,PatGender,BloodGroup,MajorDisease) " +
                    "VALUES(@PatId, @PatName, @PatAddress, @PatPhone, @PatAge, @PatGender, @BloodGroup, @MajorDisease)", connection))
                {
                    try
                    {
                        string ID = PatIdtxt.Text;
                        string NAME = PatNametxt.Text;
                        string ADDRESS = Addresstxt.Text;
                        string PHONE = Phonetxt.Text;
                        string AGE = Agetxt.Text;
                        string GENDER = GenderBox.Text;
                        string BLOOD_GROUP = BloodGRPBox.Text;
                        string MAJOR_DISEASE = MjDiseasetxt.Text;

                        cmd.Parameters.AddWithValue("@PatId", ID);
                        cmd.Parameters.AddWithValue("@PatName", NAME);
                        cmd.Parameters.AddWithValue("@PatAddress", ADDRESS);
                        cmd.Parameters.AddWithValue("@PatPhone", PHONE);
                        cmd.Parameters.AddWithValue("@PatAge", AGE);
                        cmd.Parameters.AddWithValue("@PatGender", GENDER);
                        cmd.Parameters.AddWithValue("@BloodGroup", BLOOD_GROUP);
                        cmd.Parameters.AddWithValue("@MajorDisease", MAJOR_DISEASE);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Patient successfully added");

                        showPatInfo();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot insert data. Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        //Updating Data
        private void button2_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand("UPDATE patient SET PatName=?, PatAddress=?, PatPhone=?, PatAge=?, PatGender=?, BloodGroup=?, MajorDisease=? WHERE PatId=?", con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@PatName", PatNametxt.Text);
                        cmd.Parameters.AddWithValue("@PatAddress", Addresstxt.Text);
                        cmd.Parameters.AddWithValue("@PatPhone", Phonetxt.Text);
                        cmd.Parameters.AddWithValue("@PatAge", Agetxt.Text);
                        cmd.Parameters.AddWithValue("@PatGender", GenderBox.Text);
                        cmd.Parameters.AddWithValue("@BloodGroup", BloodGRPBox.Text);
                        cmd.Parameters.AddWithValue("@MajorDisease", MjDiseasetxt.Text);
                        cmd.Parameters.AddWithValue("@PatId", PatIdtxt.Text);

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Patient updated successfully");

                            showPatInfo();
                        }
                        else
                        {
                            MessageBox.Show("No matching record found for the provided Patient Id");
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot update data. Error: " + ex.Message);
                    }
                    finally
                    {
                        con?.Close();
                    }

                }
            }
        }

        //Deleting Data
        private void button4_Click(object sender, EventArgs e)
        {
            if (PatNametxt.Text == "")
            {
                MessageBox.Show("Please enter patient Id");
            }
            else
            {
                using (var con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    using (var cmd = new OleDbCommand("DELETE FROM patient WHERE PatId=@PatId", con))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@PatId", PatIdtxt.Text);
                            int rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Patient successfully deleted");
                                showPatInfo();
                            }
                            else
                            {
                                MessageBox.Show("No matching record found with the provided Patient Id");
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

        //Selected Columns
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                string selectedId = listView1.SelectedItems[0].SubItems[0].Text;
                string selectedName = listView1.SelectedItems[0].SubItems[1].Text;
                string selectedAddress = listView1.SelectedItems[0].SubItems[2].Text;
                string selectedPhone = listView1.SelectedItems[0].SubItems[3].Text;
                string selectedAge = listView1.SelectedItems[0].SubItems[4].Text;
                string selectedGender = listView1.SelectedItems[0].SubItems[5].Text;
                string selectedBloodGroup = listView1.SelectedItems[0].SubItems[6].Text;
                string selectedMajorDisease = listView1.SelectedItems[0].SubItems[7].Text;

                PatIdtxt.Text = selectedId;
                PatNametxt.Text = selectedName;
                Addresstxt.Text = selectedAddress;
                Phonetxt.Text = selectedPhone;
                Agetxt.Text = selectedAge;
                GenderBox.Text = selectedGender;
                BloodGRPBox.Text = selectedBloodGroup;
                MjDiseasetxt.Text = selectedMajorDisease;
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            showPatInfo();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
