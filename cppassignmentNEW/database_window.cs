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
    public partial class database_window : Form
    {
        public database_window()
        {
            InitializeComponent();
        }

        private void ready(object sender, EventArgs e)
        {

            dataGridView1.DataSource = queryDB.selectTable("select * from student_info");
        }

        private void cancelledfromtwitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void newTuple_Click(object sender, EventArgs e)
        {
            queryDB.insert("Student_No", "Student_info");
            dataGridView1.DataSource = queryDB.selectTable("select * from student_info");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (column_name.Text != "" && where_param.Text != "")
            {
                queryDB.query("delete from student_info Where " + column_name.Text + " = '" + where_param.Text + "'");
                queryDB.cmd.ExecuteNonQuery();

                dataGridView1.DataSource = queryDB.selectTable("select * from student_info");


            }
            else
            {
                dataGridView1.DataSource = queryDB.selectTable("select * from student_info");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (column_name.Text != "" && where_param.Text != "")
            {
                dataGridView1.DataSource = queryDB.selectTable("select * from student_info");
                dataGridView1.DataSource = queryDB.selectTable("select * from student_info HAVING " + column_name.Text + " = '" + where_param.Text + "'");


            }
            else
            {
                dataGridView1.DataSource = queryDB.selectTable("select * from student_info");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = queryDB.selectTable("select * from student_info");
        }
    }
}
