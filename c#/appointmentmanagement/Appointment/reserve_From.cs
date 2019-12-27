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
    public partial class reserve_From : Form
    {
        matabEntities3 db = new matabEntities3();
        private  List<Showres_Result> Result;
        public reserve_From()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_reserve rsv = new add_reserve();
            this.Close();
            rsv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            add_reserve rsv = new add_reserve();
            this.Close();
            rsv.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_Form menu = new Menu_Form();
            this.Hide();
            menu.ShowDialog();
        }

        private void reserve_From_Load(object sender, EventArgs e)
        {
            
            List<Showres_Result> Result = db.Showres().ToList<Showres_Result>();
            dataGridView1.DataSource = Result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            add_reserve rsv = new add_reserve();
            this.Close();
            rsv.ShowDialog();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
