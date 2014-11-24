using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moveobject
{
    public partial class Form1 : Form
    {
        int redWins, blueWins, totRaces;
        bool red = false;
        bool blue = false;

        public Form1()
        {
            InitializeComponent();

            pictureBox2.Image = Properties.Resources.animated_blue_stick_start;
            pictureBox1.Image = Properties.Resources.animated_red_stick_start;

           

        }



        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.animated_red_stick;
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            pictureBox2.Image = Properties.Resources.animated_blue_stick;
            timer2.Enabled = true;
            timer2.Interval = 20;
            timer2.Tick += timer2_Tick;
            timer2.Start();

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int r = new Random().Next(1, 12);
            pictureBox1.Left += r;

            if ((pictureBox1.Left + pictureBox1.Width) > this.Width)
            { pictureBox1.Location = new Point(this.Width - (pictureBox1.Width), pictureBox1.Top); }


            if (pictureBox1.Left > 599 && pictureBox2.Left < 599)
            {
                pictureBox1.Image = Properties.Resources.animated_red_stick_win;
                pictureBox2.Image = Properties.Resources.animated_blue_stick_lose;

                timer1.Enabled = false;
                MessageBox.Show("Red Stick Wins!");
                red = true;
                if (red == true)
                {

                    redWins += 1;
                    lblRedWins.Text = redWins.ToString();
                    totRaces += 1;

                } 

            }

           

           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            int x = new Random().Next(1,12);
            pictureBox2.Left += x;

            if ((pictureBox2.Left + pictureBox2.Width) > this.Width)
            { pictureBox2.Location = new Point(this.Width - (pictureBox1.Width), pictureBox2.Top); }

            if (pictureBox2.Left > 599 && pictureBox1.Left < 599)
            {
                pictureBox2.Image = Properties.Resources.animated_blue_stick_win;

                pictureBox1.Image = Properties.Resources.animated_red_stick_lose;

                timer2.Enabled = false;
                MessageBox.Show("Blue Stick Wins!");
                blue = true;
                if (blue == true)
                {

                    blueWins += 1;
                    lblBlueWins.Text = blueWins.ToString();

                } 
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.animated_blue_stick_start;
            pictureBox1.Image = Properties.Resources.animated_red_stick_start;
            pictureBox1.Left = 90;
            pictureBox2.Left = 90;
            timer1.Enabled = false;
            timer2.Enabled = false;

        }

        
    }
}
        



    

