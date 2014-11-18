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
        Form2 myform2 = new Form2();

        public Form1()
        {
            InitializeComponent();

            pictureBox2.Image = Properties.Resources.animated_blue_stick_start;

        }
        public void One()
        {
            
            
            while ( pictureBox1.Location.X <950)

               
            {               
                pictureBox1.Location = new Point

                (pictureBox1.Location.X + 1, pictureBox1.Location.Y );

            if (pictureBox1.Location.X > 949 && pictureBox2.Location.X < 949)
            {
                MessageBox.Show("Pengu Won!");
                break;
            }
           }

        }

        public void Two()
        {
           

            while (pictureBox2.Location.X < 950)
            {
               
                pictureBox2.Location = new Point
                    (pictureBox2.Location.X + 1, pictureBox2.Location.Y);


                if (pictureBox2.Location.X > 949 && pictureBox1.Location.X < 949)
                {
                    pictureBox2.Image = Properties.Resources.animated_blue_stick_wins;
                   
                    break;
                   
                }

            }
         }
                    

        

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.animated_blue_stick;
            timer1.Enabled = true;
            timer1.Interval = 100;
            //timer1.Tick += timer1_Tick;
            timer1.Start();

            timer2.Enabled = true;
            timer2.Interval =100;
            //timer1.Tick += timer1_Tick;
            timer2.Start();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            One();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Two();
        }

        
       
}
       
       

}
        



    

