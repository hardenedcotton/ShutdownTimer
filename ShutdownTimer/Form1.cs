using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ShutdownTimer
{

    public partial class Form1 : Form
    {
        int TimeInSeconds = 15;
        
      



        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            rbMinutes.Checked = true;
        }

             

        private void button1_Click(object sender, EventArgs e)
        {
            hoursToSeconds(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hoursToSeconds(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hoursToSeconds(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hoursToSeconds(4);
        }

        private void button5h_Click(object sender, EventArgs e)
        {
            hoursToSeconds(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hoursToSeconds(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hoursToSeconds(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hoursToSeconds(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hoursToSeconds(9);
        }

        private void button10h_Click(object sender, EventArgs e)
        {
            hoursToSeconds(10);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            minutesToSeconds(5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            minutesToSeconds(10);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            minutesToSeconds(15);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            minutesToSeconds(20);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            minutesToSeconds(30);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            minutesToSeconds(45);
        }



        public void setTime()
        {
            if (rbMinutes.Checked)
            {
                TimeInSeconds = ((int)numericManual.Value * 60);
            }
            if (rbHours.Checked)
            {
                TimeInSeconds = ((int)numericManual.Value * 3600);
            }
            label5.Text = TimeInSeconds.ToString();
            progressBar1.Value = 0;
            progressBar1.Maximum = TimeInSeconds;
            textSetTime.Visible = false;
        }

        public void hoursToSeconds(int hours)
        {
            numericManual.Value = hours;
            rbHours.Checked = true;
            setTime();
        }
        public void minutesToSeconds(int minutes)
        {
            numericManual.Value = minutes;
            rbMinutes.Checked = true;
            setTime();
        }


        private void buttonExecute_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            buttonCancelProcess.Visible = true;
            tableLayoutPanel1.Enabled = false;
            buttonExecute.Enabled = false;
            panel1.Enabled = false;

           
            timer1.Start();
            label5.Text = TimeInSeconds.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeInSeconds--;
            progressBar1.Increment(1);

            if (TimeInSeconds == 0)
            {
                timer1.Stop();
                System.Diagnostics.Process.Start("shutdown", "-s -t 0");
            }


            label5.Text = TimeInSeconds.ToString();

        }

        private void buttonCancelProcess_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            //TimeInSeconds = -1;

            buttonExecute.Enabled = true;
            tableLayoutPanel1.Enabled = true;
            panel1.Enabled = true;
            buttonCancelProcess.Visible = false;
            progressBar1.Visible = false;
            MessageBox.Show("Shutdown Process Sucsessfully Canceled");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAbout_MouseEnter(object sender, EventArgs e)
        {
            textAbout.Visible = true;
        }

        private void buttonAbout_MouseLeave(object sender, EventArgs e)
        {
            textAbout.Visible = false;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.instagram.com/hardenedcotton");
        }

        private void buttonSetTime_Click(object sender, EventArgs e)
        {
            setTime();
        }

        private void rbClick(object sender, EventArgs e)
        {
            textSetTime.Visible = true;
        }
    }
}
