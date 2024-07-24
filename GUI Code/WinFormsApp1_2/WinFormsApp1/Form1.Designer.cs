namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button9 = new Button();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 55);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(66, 129);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(110, 37);
            button1.TabIndex = 1;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(214, 129);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(110, 37);
            button2.TabIndex = 2;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(367, 129);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(118, 37);
            button3.TabIndex = 3;
            button3.Text = "Disconnect";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 65);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 4;
            label1.Text = "Disconnected";
            label1.Click += label1_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(66, 330);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(198, 39);
            button4.TabIndex = 6;
            button4.Text = "open the Enterance door";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 277);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(418, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(214, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(271, 27);
            textBox3.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button9
            // 
            button9.Location = new Point(285, 330);
            button9.Name = "button9";
            button9.Size = new Size(200, 39);
            button9.TabIndex = 14;
            button9.Text = "open the Exit door";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button5
            // 
            button5.Location = new Point(67, 413);
            button5.Name = "button5";
            button5.Size = new Size(197, 47);
            button5.TabIndex = 15;
            button5.Text = "fees paid";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(285, 413);
            button6.Name = "button6";
            button6.Size = new Size(200, 47);
            button6.TabIndex = 16;
            button6.Text = "fees not paid";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 219);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 17;
            label2.Text = "Free Slots :";
            label2.Click += label2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 545);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button9);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Garage System";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private Button button9;
        private Button button5;
        private Button button6;
        private Label label2;
    }
}