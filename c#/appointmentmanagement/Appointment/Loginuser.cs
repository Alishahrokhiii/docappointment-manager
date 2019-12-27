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
    public partial class Loginuser : Form

    {
        matabEntities3 db = new matabEntities3();

        public Loginuser()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            List<GetAlluser_Result> result = db.GetAlluser().ToList();

            foreach (GetAlluser_Result item in result)
            {
                if (txtUser11.Text.Equals(item.username) && txtPass11.Text.Equals(item.Password))
                {

                    MessageBox.Show("Dear Admin , Welcome", "Successful login !");
                    Menu_Form menu = new Menu_Form();
                    this.Hide();
                    menu.ShowDialog();
                }
                    
                else
                {
                    MessageBox.Show("The username or password is incorrect!", "Failed!");
                }
            }

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
