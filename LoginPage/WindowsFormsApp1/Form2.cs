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


namespace WindowsFormsApp1
{
    public partial class Kullanici : Form
    {
        public User user;
        public Kullanici()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblId.Text = user.id.ToString();
            lblEmail.Text = user.email;
            lblPassword.Text = user.password;
            lblName.Text = user.name;
            lblAddress.Text = user.address;
            lblAge.Text = user.age.ToString();


        }
    }
}