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
    public partial class add_reserve : Form
    {
        matabEntities3 db = new matabEntities3();

        public add_reserve()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ID = textBox1.Text;
            String Sh_bimar = textBox2.Text;
            String date = textBox3.Text;
            String az_hour = textBox4.Text;
            String ta_hour = textBox5.Text;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                db.AddRes(ID, Sh_bimar, date, az_hour, ta_hour);
                MessageBox.Show("Done", "Welcome");
                reserve_From add_user = new reserve_From();
                this.Hide();
                add_user.ShowDialog();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            reserve_From add_user = new reserve_From();
            this.Hide();
            add_user.ShowDialog();
        }

        private void add_reserve_Load(object sender, EventArgs e)
        {

        }
    }
}
