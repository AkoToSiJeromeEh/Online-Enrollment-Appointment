The purpose of this system is to make our enrollment process easier and smoother by booking and making it easier for students to enroll. The advantage of this is that students will not have to wait because they already know their schedule. number if they are the next to enroll. It also sorts who are the first to book who will continue in the enrollment system held by the facilitators. This system also has a function to enter the student's name, ID, course, total payment and exchange. The function of this system starts at the entrance. If the 10 who have an appointment are not complete and do not arrive one after the other, the system will sort them and those who have already booked will still be first in line even if they arrive late. After the sorting is done, they can provide information to complete their enrollment.

PROGRAMMERS :

1 LEAD GASPAR , JEROME GABRIEL V.

2 FRANCISCO , VINCENT.

3 TORRESS , JERALD .

4 SAMBRANO , DEE .

DATE SUBMMITED : OCTOBER 29 , 2022

MINI PROJECT WHICH IS ENROLLMENT APPOINTMENT FUNCTION AND FEATURES

LOADING FORM

CODE : using System.Timers;

namespace F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void FRM_Splash_Load(object sender , EventArgs e)
        {
            panel2.Width = 0;
            Timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            for(int i = 0; i < 99; i++)
            {
                panel2.Width = panel2.Width + 6;
                Thread.Sleep(60);
            }
            Timer.Stop();
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
            
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

LOGIN FORM

CODE : using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace F1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "STUDENT" && txtPassword.Text == "12345")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INCORRECT USERNAME AND PASSWORD ! TRY AGAIN");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();

            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

APPOINTMENT DAY SELECTOR FUNCTION
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day;
            day = (TXT1.Text).ToString();
            if(day == "Monday")
            {
                TXT2.Text = "NOT AVAILABLE";
                MessageBox.Show("FULL APPOINTMENT");
            }
            else if(day == "Tuesday")
            {
                TXT2.Text = "AVAILABLE";
                MessageBox.Show("AVAILABLE");
                Form3 form = new Form3();
                form.Show();
                this.Hide();

            }
            else if (day == "Wednesday")
            {
                TXT2.Text = "NOT AVAILABLE";
                MessageBox.Show("FULL APPOINTMENT");

            }
            else if (day == "Thursday")
            {
                TXT2.Text = " AVAILABLE";
                MessageBox.Show("AVAILABLE");
                Form3 form = new Form3();
                form.Show();
                this.Hide();


            }
            else if (day == "FRIDAY")
            {
                TXT2.Text = "NOT AVAILABLE";
                MessageBox.Show("FULL APPOINTMENT");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXT1.Clear();
            TXT2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void TXT2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

CLEAR BUTTON WHICH IS REALLY ESSENTIAL ONE CLICK AND ALL OF THE TEXT IS GONE
 
 CODE :  private void button2_Click(object sender, EventArgs e)
        {
            TXT1.Clear();
            TXT2.Clear();
        }
        
BACK BUTTON WHICH BRING YOU BACK ON THE PAGE YOU ENTER BEFORE 

CODE :  private void button4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 forrrm = new Form2();
            forrrm.Show();
            this.Hide();
        }

ADD BUTTON WHICH ADDING THE APPOINTMENT 

  CODE : private void BTN1_Click(object sender, EventArgs e)
        {   
            table.Rows.Add(NAME.Text, ID.Text, COURSE.Text, YEAR.Text, CNUMBER.Text);
            MessageBox.Show("APPOINTED");
        }
UPDATE BUTTON WHICH UPDATING THE APPOINTMENT

CODE : private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow Appointment = dataGridView1.Rows[forms];
            Appointment.Cells[0].Value = NAME.Text;
            Appointment.Cells[1].Value = ID.Text;
            Appointment.Cells[2].Value = COURSE.Text;
            Appointment.Cells[3].Value = YEAR.Text;
            Appointment.Cells[4].Value = CNUMBER.Text;
            MessageBox.Show("APPOINTMENT UPDATED : " + YEAR.Text );
        }


REMOVE BUTTON WHICH REMOVING THE APPOINTMENT
 private void button2_Click(object sender, EventArgs e)
        {
            forms = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(forms);
            MessageBox.Show("APPOINTMENT REMOVE");

        }
ASCEND ALGORITHM BUTTON : ASCEND THE TIME ON WHAT USER WILL INPUT.

CODE : private void button5_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns[3], ListSortDirection.Ascending);
        }


APPOINTMENT UPDATE 
![Screenshot (834)](https://user-images.githubusercontent.com/114987334/198829898-005e656e-1f9b-4c37-b6c7-73608d795e80.png)

APPOINTMENT REMOVE 
![Screenshot (833)](https://user-images.githubusercontent.com/114987334/198829901-34419b5c-9363-42b2-b9ca-57ecba7e0d55.png)

ADDING APPOINTMENT
![Screenshot (832)](https://user-images.githubusercontent.com/114987334/198829907-fc61d608-147b-4b85-9ea7-3159160676ac.png)

ADDING APPOINTMENT
![Screenshot (831)](https://user-images.githubusercontent.com/114987334/198829917-5abce890-aaea-4fcd-8c9c-06b8becedcdd.png)

APPOINTMENT IS FULL ON THAT DAY !
![Screenshot (830)](https://user-images.githubusercontent.com/114987334/198829924-d6196964-54c3-428d-875c-54844f6ae360.png)

CHOOSE THE DAY YOU WANT TO APPOINTED
![Screenshot (829)](https://user-images.githubusercontent.com/114987334/198829930-ef2bced0-37f8-4c11-97f3-66e0e2cd40c7.png)

LOGIN PAGE
![Screenshot (828)](https://user-images.githubusercontent.com/114987334/198829939-ca634e80-70d5-4e89-971d-0d82254e2065.png)

LOADING PAGE
![Screenshot (835)](https://user-images.githubusercontent.com/114987334/198831517-9d0ab6fa-e76a-47c9-b79d-c9124a0eea08.png)
