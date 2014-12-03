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
            this.btnNewrace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcsharptime = new System.Windows.Forms.Label();
            this.lblRubytime = new System.Windows.Forms.Label();
            this.lblPythontime = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l = new System.Windows.Forms.Label();
            this.lblRubywins = new System.Windows.Forms.Label();
            this.lblPythonwins = new System.Windows.Forms.Label();
            this.lblSeesharpiewins = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 5;
            this.btnStart.Location = new System.Drawing.Point(59, 426);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "They\'re Off!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewrace
            // 
            this.btnNewrace.Location = new System.Drawing.Point(59, 469);
            this.btnNewrace.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewrace.Name = "btnNewrace";
            this.btnNewrace.Size = new System.Drawing.Size(98, 32);
            this.btnNewrace.TabIndex = 4;
            this.btnNewrace.Text = "&New Race";
            this.btnNewrace.UseVisualStyleBackColor = true;
            this.btnNewrace.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(326, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "See Sharpie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(499, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruby Baby:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(667, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Python\'ll Bite:";
            // 
            // lblcsharptime
            // 
            this.lblcsharptime.AutoSize = true;
            this.lblcsharptime.BackColor = System.Drawing.Color.Transparent;
            this.lblcsharptime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcsharptime.Location = new System.Drawing.Point(412, 479);
            this.lblcsharptime.Name = "lblcsharptime";
            this.lblcsharptime.Size = new System.Drawing.Size(14, 13);
            this.lblcsharptime.TabIndex = 8;
            this.lblcsharptime.Text = "0";
            // 
            // lblRubytime
            // 
            this.lblRubytime.AutoSize = true;
            this.lblRubytime.BackColor = System.Drawing.Color.Transparent;
            this.lblRubytime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRubytime.Location = new System.Drawing.Point(577, 479);
            this.lblRubytime.Name = "lblRubytime";
            this.lblRubytime.Size = new System.Drawing.Size(14, 13);
            this.lblRubytime.TabIndex = 9;
            this.lblRubytime.Text = "0";
            // 
            // lblPythontime
            // 
            this.lblPythontime.AutoSize = true;
            this.lblPythontime.BackColor = System.Drawing.Color.Transparent;
            this.lblPythontime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPythontime.Location = new System.Drawing.Point(758, 479);
            this.lblPythontime.Name = "lblPythontime";
            this.lblPythontime.Size = new System.Drawing.Size(14, 13);
            this.lblPythontime.TabIndex = 10;
            this.lblPythontime.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SetBounds.Properties.Resources.horse;
            this.pictureBox3.Location = new System.Drawing.Point(11, 311);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SetBounds.Properties.Resources.horse;
            this.pictureBox2.Location = new System.Drawing.Point(11, 187);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SetBounds.Properties.Resources.horse;
            this.pictureBox1.Location = new System.Drawing.Point(11, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox4.Location = new System.Drawing.Point(154, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(7, 373);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(59, 512);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 32);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox5.Location = new System.Drawing.Point(848, 48);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(7, 373);
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startRaceToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(425, 517);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
          
            // 
            // startRaceToolStripMenuItem
            // 
            this.startRaceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startRaceToolStripMenuItem.Name = "startRaceToolStripMenuItem";
            this.startRaceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.startRaceToolStripMenuItem.Text = "Start Race";
            this.startRaceToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.infoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l.Location = new System.Drawing.Point(634, 441);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(103, 17);
            this.l.TabIndex = 16;
            this.l.Text = "Python\'ll Bite";
            // 
            // lblRubywins
            // 
            this.lblRubywins.AutoSize = true;
            this.lblRubywins.BackColor = System.Drawing.Color.Transparent;
            this.lblRubywins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubywins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRubywins.Location = new System.Drawing.Point(607, 441);
            this.lblRubywins.Name = "lblRubywins";
            this.lblRubywins.Size = new System.Drawing.Size(17, 17);
            this.lblRubywins.TabIndex = 15;
            this.lblRubywins.Text = "0";
            // 
            // lblPythonwins
            // 
            this.lblPythonwins.AutoSize = true;
            this.lblPythonwins.BackColor = System.Drawing.Color.Transparent;
            this.lblPythonwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPythonwins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPythonwins.Location = new System.Drawing.Point(743, 441);
            this.lblPythonwins.Name = "lblPythonwins";
            this.lblPythonwins.Size = new System.Drawing.Size(17, 17);
            this.lblPythonwins.TabIndex = 17;
            this.lblPythonwins.Text = "0";
            // 
            // lblSeesharpiewins
            // 
            this.lblSeesharpiewins.AutoSize = true;
            this.lblSeesharpiewins.BackColor = System.Drawing.Color.Transparent;
            this.lblSeesharpiewins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeesharpiewins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeesharpiewins.Location = new System.Drawing.Point(488, 441);
            this.lblSeesharpiewins.Name = "lblSeesharpiewins";
            this.lblSeesharpiewins.Size = new System.Drawing.Size(17, 17);
            this.lblSeesharpiewins.TabIndex = 13;
            this.lblSeesharpiewins.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(385, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "See Sharpie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(337, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wins:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(515, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ruby Baby";
            // 
            // frmHorseRace
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SetBounds.Properties.Resources.race_bg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1032, 550);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox4);
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
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHorseRace";
            this.Text = "SCC Downs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lblRubywins;
        private System.Windows.Forms.Label lblPythonwins;
        private System.Windows.Forms.Label lblSeesharpiewins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        
    }
}

