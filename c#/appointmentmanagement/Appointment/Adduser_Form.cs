using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment
{
    public partial class Adduser_Form : Form
    {
        matabEntities3 db = new matabEntities3();
        public Adduser_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ID = textBox1.Text;
            String Sh_bimar = textBox2.Text;
            String Firstname = textBox3.Text;
            String Lastname = textBox4.Text;
            String mobile = textBox5.Text;
            String age = textBox6.Text;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                db.CreatePatient(ID, Sh_bimar, Firstname, Lastname, mobile, age);
                MessageBox.Show("Done", "Welcome");
                patients_form add_user = new patients_form();
                this.Hide();
                add_user.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patients_form add_user = new patients_form();
            this.Hide();
            add_user.ShowDialog();
        }
    }
}
