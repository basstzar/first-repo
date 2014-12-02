namespace SetBounds
{
    partial class frmHorseRace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnNewrace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcsharptime = new System.Windows.Forms.Label();
            this.lblRubytime = new System.Windows.Forms.Label();
            this.lblPythontime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSeesharpiewins = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRubywins = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lblPythonwins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(368, 11);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(50, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "They\'re Off!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SetBounds.Properties.Resources.horse;
            this.pictureBox1.Location = new System.Drawing.Point(11, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SetBounds.Properties.Resources.horse;
            this.pictureBox2.Location = new System.Drawing.Point(11, 220);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SetBounds.Properties.Resources.horse;
            this.pictureBox3.Location = new System.Drawing.Point(11, 376);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnNewrace
            // 
            this.btnNewrace.Location = new System.Drawing.Point(505, 10);
            this.btnNewrace.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewrace.Name = "btnNewrace";
            this.btnNewrace.Size = new System.Drawing.Size(50, 38);
            this.btnNewrace.TabIndex = 4;
            this.btnNewrace.Text = "New Race";
            this.btnNewrace.UseVisualStyleBackColor = true;
            this.btnNewrace.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CeeSharpie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruby Baby:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Python\'ll Bite:";
            // 
            // lblcsharptime
            // 
            this.lblcsharptime.AutoSize = true;
            this.lblcsharptime.Location = new System.Drawing.Point(381, 512);
            this.lblcsharptime.Name = "lblcsharptime";
            this.lblcsharptime.Size = new System.Drawing.Size(13, 13);
            this.lblcsharptime.TabIndex = 8;
            this.lblcsharptime.Text = "0";
            // 
            // lblRubytime
            // 
            this.lblRubytime.AutoSize = true;
            this.lblRubytime.Location = new System.Drawing.Point(525, 512);
            this.lblRubytime.Name = "lblRubytime";
            this.lblRubytime.Size = new System.Drawing.Size(13, 13);
            this.lblRubytime.TabIndex = 9;
            this.lblRubytime.Text = "0";
            // 
            // lblPythontime
            // 
            this.lblPythontime.AutoSize = true;
            this.lblPythontime.Location = new System.Drawing.Point(656, 512);
            this.lblPythontime.Name = "lblPythontime";
            this.lblPythontime.Size = new System.Drawing.Size(13, 13);
            this.lblPythontime.TabIndex = 10;
            this.lblPythontime.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wins:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "See Sharpie";
            // 
            // lblSeesharpiewins
            // 
            this.lblSeesharpiewins.AutoSize = true;
            this.lblSeesharpiewins.Location = new System.Drawing.Point(695, 24);
            this.lblSeesharpiewins.Name = "lblSeesharpiewins";
            this.lblSeesharpiewins.Size = new System.Drawing.Size(13, 13);
            this.lblSeesharpiewins.TabIndex = 13;
            this.lblSeesharpiewins.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(729, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ruby Baby";
            // 
            // lblRubywins
            // 
            this.lblRubywins.AutoSize = true;
            this.lblRubywins.Location = new System.Drawing.Point(794, 24);
            this.lblRubywins.Name = "lblRubywins";
            this.lblRubywins.Size = new System.Drawing.Size(13, 13);
            this.lblRubywins.TabIndex = 15;
            this.lblRubywins.Text = "0";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(813, 24);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(67, 13);
            this.l.TabIndex = 16;
            this.l.Text = "Python\'ll Bite";
            // 
            // lblPythonwins
            // 
            this.lblPythonwins.AutoSize = true;
            this.lblPythonwins.Location = new System.Drawing.Point(886, 24);
            this.lblPythonwins.Name = "lblPythonwins";
            this.lblPythonwins.Size = new System.Drawing.Size(13, 13);
            this.lblPythonwins.TabIndex = 17;
            this.lblPythonwins.Text = "0";
            // 
            // frmHorseRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 550);
            this.Controls.Add(this.lblPythonwins);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lblRubywins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSeesharpiewins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPythontime);
            this.Controls.Add(this.lblRubytime);
            this.Controls.Add(this.lblcsharptime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewrace);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHorseRace";
            this.Text = "SCC Downs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnNewrace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcsharptime;
        private System.Windows.Forms.Label lblRubytime;
        private System.Windows.Forms.Label lblPythontime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSeesharpiewins;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRubywins;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lblPythonwins;
    }
}

