using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;


namespace SetBounds
{
    public partial class frmHorseRace : Form
    {
        int intStart = 12;
        int intEnd = 835;
        int csharpWins, rubyWins, pythonWins;
      

        double csharp, ruby, python;
        Random myRan = new Random();
       

        public frmHorseRace()


        {
            InitializeComponent();
            pictureBox4.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::SetBounds.Properties.Resources.csharp_animated_horse;
            this.pictureBox2.Image = global::SetBounds.Properties.Resources.animated_horse;
            this.pictureBox3.Image = global::SetBounds.Properties.Resources.animated_horse;
            pictureBox4.Visible = false;
            
            while (intStart < intEnd)
            {
                var sw1 = Stopwatch.StartNew();
                               
                int myMove = myRan.Next(0, 20);
                intStart = intStart + myMove;
                Thread.Sleep(100);
                               
                pictureBox1.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
                this.Refresh();
                if ((pictureBox1.Location.X >= intEnd)&&(pictureBox1.Location.X>pictureBox2.Location.X)&&(pictureBox1.Location.X > pictureBox3.Location.X))
                {
                    this.pictureBox1.Image = global::SetBounds.Properties.Resources.horse;
                    this.pictureBox2.Image = global::SetBounds.Properties.Resources.horse;
                    this.pictureBox3.Image = global::SetBounds.Properties.Resources.horse;
                    
                    MessageBox.Show("See Sharpie Wins!", "The Winner");

                    csharpWins += 1;
                    lblSeesharpiewins.Text = csharpWins.ToString();
                  
                   
                    break;}

                sw1.Stop();
                csharp = sw1.Elapsed.Milliseconds;
                lblcsharptime.Text = csharp.ToString();

                var sw2 = Stopwatch.StartNew();
              
                int myMove2 = myRan.Next(0, 20);
                intStart = intStart + myMove2;
                Thread.Sleep(100);
                
               
                pictureBox2.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
                this.Refresh();
                if ((pictureBox2.Location.X >= intEnd) && (pictureBox2.Location.X > pictureBox1.Location.X) && (pictureBox2.Location.X > pictureBox3.Location.X))
                {
                    this.pictureBox1.Image = global::SetBounds.Properties.Resources.horse;
                    this.pictureBox2.Image = global::SetBounds.Properties.Resources.horse;
                    this.pictureBox3.Image = global::SetBounds.Properties.Resources.horse;

                    MessageBox.Show("Ruby Baby Wins!", "The Winner");
                    rubyWins += 1;
                    lblRubywins.Text = rubyWins.ToString();
             
                    
                    break;}


                sw2.Stop();
                ruby = sw2.Elapsed.Milliseconds;
                lblRubytime.Text = ruby.ToString();

                var sw3 = Stopwatch.StartNew();
               
                int myMove3 = myRan.Next(0, 20);
                intStart = intStart + myMove3;
                Thread.Sleep(100);
                pictureBox3.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
                this.Refresh();

                if ((pictureBox3.Location.X >= intEnd) && (pictureBox3.Location.X > pictureBox2.Location.X) && (pictureBox3.Location.X > pictureBox1.Location.X))
                {
                   
                    this.pictureBox1.Image = global::SetBounds.Properties.Resources.horse;
                    this.pictureBox2.Image = global::SetBounds.Properties.Resources.horse;
                    this.pictureBox3.Image = global::SetBounds.Properties.Resources.horse;
                   
                    MessageBox.Show("Python'll Bite Wins!", "The Winner");
                    pythonWins += 1;
                    lblPythonwins.Text = pythonWins.ToString();
                
                    break;}

                sw3.Stop();
                python = sw3.Elapsed.Milliseconds;
                lblPythontime.Text = python.ToString();
                   
                    
                

               
                
            }
            
           
        
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            intEnd = this.Size.Width - 80;
            intStart = 12;
            pictureBox1.SetBounds(11, 42, 0, 0, BoundsSpecified.Location);

            intEnd = this.Size.Width - 80;
            intStart = 12;
            pictureBox2.SetBounds(11, 230, 0, 0, BoundsSpecified.Location);

            intEnd = this.Size.Width - 80;
            intStart = 12;
            pictureBox3.SetBounds(11, 505, 0, 0, BoundsSpecified.Location);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::SetBounds.Properties.Resources.horse;
            this.pictureBox2.Image = global::SetBounds.Properties.Resources.horse;
            this.pictureBox3.Image = global::SetBounds.Properties.Resources.horse;
            csharp = 0;
            ruby = 0;
            python = 0;
            intStart = 11;
            pictureBox1.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
            pictureBox2.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
            pictureBox3.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
            lblcsharptime.Text = csharp.ToString();
            lblPythontime.Text = python.ToString();
            lblRubytime.Text = ruby.ToString();
        }
    }
}
