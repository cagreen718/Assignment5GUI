namespace Payroll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            Exitbtn = new Button();
            Clearbtn = new Button();
            Compbtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            FICAtext = new TextBox();
            Fedtext = new TextBox();
            Statetext = new TextBox();
            NetPaytext = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(604, 355);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = SystemColors.ActiveCaption;
            Exitbtn.Location = new Point(719, 477);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(112, 34);
            Exitbtn.TabIndex = 1;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += button1_Click;
            // 
            // Clearbtn
            // 
            Clearbtn.BackColor = SystemColors.ActiveCaption;
            Clearbtn.Location = new Point(398, 477);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(112, 34);
            Clearbtn.TabIndex = 2;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = false;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // Compbtn
            // 
            Compbtn.BackColor = SystemColors.ActiveCaption;
            Compbtn.Location = new Point(42, 478);
            Compbtn.Name = "Compbtn";
            Compbtn.Size = new Size(162, 34);
            Compbtn.TabIndex = 3;
            Compbtn.Text = "Compute Taxes";
            Compbtn.UseVisualStyleBackColor = false;
            Compbtn.Click += Compbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(719, 36);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 4;
            label1.Text = "Payroll Calculator";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(733, 82);
            label2.Name = "label2";
            label2.Size = new Size(98, 50);
            label2.TabIndex = 5;
            label2.Text = "Paycheck \r\nCalculation";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 404);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 6;
            label3.Text = "Enter Gross Pay:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 555);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 7;
            label4.Text = "FICA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 552);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 8;
            label5.Text = "Federal Tax:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(719, 555);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 9;
            label6.Text = "State Tax:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(271, 614);
            label7.Name = "label7";
            label7.Size = new Size(184, 25);
            label7.TabIndex = 10;
            label7.Text = "Net Paycheck Income:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(516, 404);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FICAtext
            // 
            FICAtext.Location = new Point(113, 558);
            FICAtext.Name = "FICAtext";
            FICAtext.Size = new Size(150, 31);
            FICAtext.TabIndex = 12;
            FICAtext.TextChanged += FICAtext_TextChanged;
            // 
            // Fedtext
            // 
            Fedtext.Location = new Point(480, 552);
            Fedtext.Name = "Fedtext";
            Fedtext.Size = new Size(150, 31);
            Fedtext.TabIndex = 13;
            Fedtext.TextChanged += Fedtext_TextChanged;
            // 
            // Statetext
            // 
            Statetext.Location = new Point(818, 552);
            Statetext.Name = "Statetext";
            Statetext.Size = new Size(150, 31);
            Statetext.TabIndex = 14;
            Statetext.TextChanged += Statetext_TextChanged;
            // 
            // NetPaytext
            // 
            NetPaytext.Location = new Point(455, 616);
            NetPaytext.Name = "NetPaytext";
            NetPaytext.Size = new Size(150, 31);
            NetPaytext.TabIndex = 15;
            NetPaytext.TextChanged += NetPaytext_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 687);
            Controls.Add(NetPaytext);
            Controls.Add(Statetext);
            Controls.Add(Fedtext);
            Controls.Add(FICAtext);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Compbtn);
            Controls.Add(Clearbtn);
            Controls.Add(Exitbtn);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Payroll Every Two Weeks";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Exitbtn;
        private Button Clearbtn;
        private Button Compbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox FICAtext;
        private TextBox Fedtext;
        private TextBox Statetext;
        private TextBox NetPaytext;
    }
}
