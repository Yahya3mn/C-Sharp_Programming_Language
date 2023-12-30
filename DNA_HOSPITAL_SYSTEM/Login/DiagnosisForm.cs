using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;
using System.Xml.Linq;

namespace Login
{

    public partial class DiagnosisForm : Form
    {
        private readonly string connectionString = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\DNAHS.accdb";
        public DiagnosisForm()
        {
            InitializeComponent();
        }

        // Fetch Patient ID
        void Fetch_Patient_Id()
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand("SELECT * FROM patient", con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("PatId", typeof(int));
                            dt.Load(dr);

                            PatIdbox.DisplayMember = "PatId";
                            PatIdbox.ValueMember = "PatId";
                            PatIdbox.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Fetch Error: " + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        //Fetch Patient Name

        string patientName;

        void Fetch_Patient_Name()
        {
            OleDbConnection con = null;

            try
            {
                if (PatIdbox.SelectedValue != null)
                {
                    using (con = new OleDbConnection(connectionString))
                    {
                        con.Open();
                        using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM patient WHERE PatId = @PatId", con))
                        {
                            cmd.Parameters.AddWithValue("@PatId", PatIdbox.SelectedValue.ToString());
                            DataTable dt = new DataTable();
                            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                            da.Fill(dt);

                            foreach (DataRow dr in dt.Rows)
                            {
                                patientName = dr["PatName"].ToString();
                                PatientNametxt.Text = patientName;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("PatIdbox.SelectedValue is null.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fetch Error: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        //Show Data

        private void showDiagInfo()
        {
            listView1.Items.Clear();
            using(var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using(var cmd = new OleDbCommand("SELECT * FROM diagnosis",con))
                {
                    using(var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while(dr.Read())
                            {
                                ListViewItem addNew = new ListViewItem();
                                addNew.Text = dr["DiagId"].ToString();
                                addNew.SubItems.Add(dr["PatId"].ToString());
                                addNew.SubItems.Add(dr["PatName"].ToString());
                                addNew.SubItems.Add(dr["Symptoms"].ToString());
                                addNew.SubItems.Add(dr["Diagnosis"].ToString());
                                addNew.SubItems.Add(dr["Medicines"].ToString());

                                listView1.Items.Add(addNew);
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Error loading data into ListView:" + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        //Inserting Data
        private void button1_Click(object sender, EventArgs e)
        {
           using(var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using(var cmd = new  OleDbCommand("INSERT INTO diagnosis(DiagId,PatId,PatName,Symptoms,Diagnosis,Medicines) VALUES(@DiagId,@PatId,@PatName,@Symptoms,@Diagnosis,@Medicines)", con))
                {
                    try
                    {
                        string DIAG_ID = DiagnosisIDtxt.Text;
                        string PAT_ID = PatIdbox.Text;
                        string PAT_NAME = PatientNametxt.Text;
                        string SYMPTOMS = Symptomstxt.Text;
                        string DIAGNOSIS = Diagnosistxt.Text;
                        string MEDICINES = Medicinestxt.Text;

                        cmd.Parameters.AddWithValue("@DiagId", DIAG_ID);
                        cmd.Parameters.AddWithValue("@PatId", PAT_ID);
                        cmd.Parameters.AddWithValue("@PatName", PAT_NAME);
                        cmd.Parameters.AddWithValue("@Symptoms", SYMPTOMS);
                        cmd.Parameters.AddWithValue("@Diagnosis", DIAGNOSIS);
                        cmd.Parameters.AddWithValue("@Medicines", MEDICINES);

                        cmd.ExecuteNonQuery();

                        ListViewItem newItem = new ListViewItem(DIAG_ID);
                        newItem.SubItems.Add(PAT_ID);
                        newItem.SubItems.Add(PAT_NAME);
                        newItem.SubItems.Add(SYMPTOMS);
                        newItem.SubItems.Add(DIAGNOSIS);
                        newItem.SubItems.Add(MEDICINES);


                        MessageBox.Show("Doctor successfully added");

                        showDiagInfo();
                    }
                    catch (Exception ex)
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

        // Updating Data
        private void button2_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand("UPDATE diagnosis SET Symptoms=?, Diagnosis=?, Medicines=? WHERE DiagId=?", con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Symptoms", Symptomstxt.Text);
                        cmd.Parameters.AddWithValue("@Diagnosis", Diagnosistxt.Text);
                        cmd.Parameters.AddWithValue("@Medicines", Medicinestxt.Text);
                        cmd.Parameters.AddWithValue("@DiagId", DiagnosisIDtxt.Text);

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Diagnosis updated successfully");

                            showDiagInfo();
                        }
                        else
                        {
                            MessageBox.Show("No matching record found for the provided Diagnosis Id");
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
        private void button3_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();

                using (var cmd = new OleDbCommand("DELETE FROM diagnosis WHERE DiagId=@DiagId", con))
                {

                    try
                    {
                        cmd.Parameters.AddWithValue("@DiagId", DiagnosisIDtxt.Text);
                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Diagnosis successfully deleted.");
                            showDiagInfo();
                        }
                        else
                        {
                            MessageBox.Show("No matching record found with the provided Diagnosis Id");
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

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            Fetch_Patient_Id();
            showDiagInfo();
        }

        private void PatIdbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fetch_Patient_Name();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                if (int.TryParse(selectedItem.SubItems[0].Text, out int selectedId) &&
                    int.TryParse(selectedItem.SubItems[1].Text, out int selectedPatId))
                {
                    DiagnosisIDtxt.Text = selectedId.ToString();
                    PatIdbox.Text = selectedPatId.ToString();
                    PatientNametxt.Text = selectedItem.SubItems[2].Text;
                    Symptomstxt.Text = selectedItem.SubItems[3].Text;
                    Diagnosistxt.Text = selectedItem.SubItems[4].Text;
                    Medicinestxt.Text = selectedItem.SubItems[5].Text;
                    Patientlbl.Text = selectedItem.SubItems[2].Text;
                    Symptomslbl.Text = selectedItem.SubItems[3].Text;
                    Diagnosislbl.Text = selectedItem.SubItems[4].Text;
                    Medicineslbl.Text = selectedItem.SubItems[5].Text;
                    
                }
                else
                {
                    Console.WriteLine("Error parsing selected values.");
                }
            }
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label3.Text , new Font("Century Gothic",25,FontStyle.Bold),Brushes.Red, new Point(230));
            e.Graphics.DrawString(label5.Text + "\t" +Patientlbl.Text+ "\n" +label6.Text+ "\t" +Symptomslbl.Text+ "\n" +label7.Text+ "\t" +Medicineslbl.Text+ "\n" +label8.Text+ "\t" +Diagnosislbl.Text+ "\n\n\n\n\n\n",new Font("Century Gothic",15,FontStyle.Regular),Brushes.Black, new Point(130,150));
            e.Graphics.DrawString(label4.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230,500));
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
