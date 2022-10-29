using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class Form3 : Form
    {
        DataTable table = new DataTable("table");
        int forms;
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            forms = e.RowIndex;
            DataGridViewRow appoint = dataGridView1.Rows[forms];
            NAME.Text = appoint.Cells[0].Value.ToString();
            ID.Text = appoint.Cells[1].Value.ToString();
            COURSE.Text = appoint.Cells[2].Value.ToString();
            YEAR.Text = appoint.Cells[3].Value.ToString();
            CNUMBER.Text = appoint.Cells[4].Value.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            table.Columns.Add("Name",Type.GetType("System.String"));
            table.Columns.Add("ID",Type.GetType("System.Int32"));
            table.Columns.Add("Course", Type.GetType("System.String"));
            table.Columns.Add("TIME", Type.GetType("System.String"));
            table.Columns.Add("Number", Type.GetType("System.String"));
            dataGridView1.DataSource = table;

        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            
            table.Rows.Add(NAME.Text, ID.Text, COURSE.Text, YEAR.Text, CNUMBER.Text);
            MessageBox.Show("APPOINTED");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NAME.Clear();
            ID.Clear(); 
            COURSE.Clear();
            YEAR.Clear(); 
            CNUMBER.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forms = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(forms);
            MessageBox.Show("APPOINTMENT REMOVE");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow Appointment = dataGridView1.Rows[forms];
            Appointment.Cells[0].Value = NAME.Text;
            Appointment.Cells[1].Value = ID.Text;
            Appointment.Cells[2].Value = COURSE.Text;
            Appointment.Cells[3].Value = YEAR.Text;
            Appointment.Cells[4].Value = CNUMBER.Text;
            MessageBox.Show("APPOINTMENT UPDATED : " + YEAR.Text );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 forrrm = new Form2();
            forrrm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns[3], ListSortDirection.Ascending);
        }
    }
}
