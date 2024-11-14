using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cppassignmentNEW
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void toRegister_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(new Form1());
        }

        private void toDatabase_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(new database_window());
        }

        private void KILL(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
