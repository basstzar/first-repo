using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace SetBounds
{
    public partial class Form1 : Form
    {
        int intStart = 12;
        int intEnd = 835;
      


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::SetBounds.Properties.Resources.animated_horse;
            
            while (intStart < intEnd)
            {
                Random myRan = new Random();
                int myMove = myRan.Next(0, 20);
                intStart = intStart + myMove;
                Thread.Sleep(200);
               
                pictureBox1.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
                this.Refresh();
            }
            this.pictureBox1.Image = global::SetBounds.Properties.Resources.horse;
            

        
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            intEnd = this.Size.Width - 35;
            intStart = 12;
            pictureBox1.SetBounds(11, 42, 0, 0, BoundsSpecified.Location);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
