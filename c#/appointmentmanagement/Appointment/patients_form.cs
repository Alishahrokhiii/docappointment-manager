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
    public partial class patients_form : Form
    {
        matabEntities3 db = new matabEntities3();
        public patients_form()
        {
            InitializeComponent();
        }
        

       

        private void button1_Click(object sender, EventArgs e)
        {
            Adduser_Form add_user = new Adduser_Form();
          this.Close();
          add_user.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adduser_Form add_user = new Adduser_Form();
            this.Close();
            add_user.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_Form menu = new Menu_Form();
            this.Hide();
            menu.ShowDialog();
        }

        private void patients_form_Load(object sender, EventArgs e)
        {
            List<Show_Result> Result = db.Show().ToList<Show_Result>();
            dataGridView1.DataSource = Result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
