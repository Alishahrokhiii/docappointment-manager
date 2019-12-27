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
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            patients_form menu = new patients_form();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnreserve_Click(object sender, EventArgs e)
        {
            reserve_From menu = new reserve_From();
            this.Hide();
            menu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginuser menu = new Loginuser();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
