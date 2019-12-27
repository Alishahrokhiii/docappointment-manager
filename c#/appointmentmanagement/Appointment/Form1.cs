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

namespace Appointment
{
    //SqlConnection myconnection;

    public partial class Form1 : Form
    {
        
        SqlConnection myconnection = new SqlConnection("SERVER = desktop-l2q031a; DATABASE = appointment" );
        SqlCommand mycommand = new SqlCommand("SELECT * FROM Login");
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter(mycommand);
            mycommand.Connection = myconnection;
            da.Fill(ds);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
