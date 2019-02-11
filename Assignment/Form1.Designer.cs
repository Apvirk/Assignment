namespace Assignment
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAl = new System.Windows.Forms.TextBox();
            this.tbBob = new System.Windows.Forms.TextBox();
            this.tbJoe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numRacer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numAmt = new System.Windows.Forms.NumericUpDown();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 304);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 102);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 183);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(16, 264);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbAl);
            this.panel1.Controls.Add(this.tbBob);
            this.panel1.Controls.Add(this.tbJoe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numRacer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numAmt);
            this.panel1.Controls.Add(this.rbAl);
            this.panel1.Controls.Add(this.rbBob);
            this.panel1.Controls.Add(this.rbJoe);
            this.panel1.Location = new System.Drawing.Point(12, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 116);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Max amount $45";
            // 
            // tbAl
            // 
            this.tbAl.Enabled = false;
            this.tbAl.Location = new System.Drawing.Point(433, 70);
            this.tbAl.Name = "tbAl";
            this.tbAl.Size = new System.Drawing.Size(387, 20);
            this.tbAl.TabIndex = 10;
            // 
            // tbBob
            // 
            this.tbBob.Enabled = false;
            this.tbBob.Location = new System.Drawing.Point(433, 41);
            this.tbBob.Name = "tbBob";
            this.tbBob.Size = new System.Drawing.Size(387, 20);
            this.tbBob.TabIndex = 9;
            // 
            // tbJoe
            // 
            this.tbJoe.Enabled = false;
            this.tbJoe.Location = new System.Drawing.Point(433, 15);
            this.tbJoe.Name = "tbJoe";
            this.tbJoe.Size = new System.Drawing.Size(387, 20);
            this.tbJoe.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "on car number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "#";
            // 
            // numRacer
            // 
            this.numRacer.Location = new System.Drawing.Point(314, 75);
            this.numRacer.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numRacer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRacer.Name = "numRacer";
            this.numRacer.Size = new System.Drawing.Size(46, 20);
            this.numRacer.TabIndex = 5;
            this.numRacer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "$";
            // 
            // numAmt
            // 
            this.numAmt.Location = new System.Drawing.Point(314, 30);
            this.numAmt.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numAmt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmt.Name = "numAmt";
            this.numAmt.Size = new System.Drawing.Size(46, 20);
            this.numAmt.TabIndex = 3;
            this.numAmt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Location = new System.Drawing.Point(65, 73);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(34, 17);
            this.rbAl.TabIndex = 2;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "Al";
            this.rbAl.UseVisualStyleBackColor = true;
            this.rbAl.CheckedChanged += new System.EventHandler(this.rbAl_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Location = new System.Drawing.Point(65, 44);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(44, 17);
            this.rbBob.TabIndex = 1;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbBob_CheckedChanged);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Location = new System.Drawing.Point(65, 16);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(42, 17);
            this.rbJoe.TabIndex = 0;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.Location = new System.Drawing.Point(40, 470);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(229, 46);
            this.btnPlaceBet.TabIndex = 7;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = true;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(549, 484);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 46);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(714, 484);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(149, 46);
            this.btnRace.TabIndex = 9;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1041, 542);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceBet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRacer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbJoe;
        private System.Windows.Forms.TextBox tbAl;
        private System.Windows.Forms.TextBox tbBob;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}

