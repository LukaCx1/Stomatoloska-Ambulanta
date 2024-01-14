namespace Stomatoloska_ambulanta_demo_1
{
    partial class Form2
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button5 = new Button();
            dateTimePicker3 = new DateTimePicker();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(865, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(270, 290);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(811, 79);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 1;
            label1.Text = "Opis:";
            // 
            // button1
            // 
            button1.Location = new Point(-3, 202);
            button1.Name = "button1";
            button1.Size = new Size(205, 76);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(-1, 307);
            button4.Name = "button4";
            button4.Size = new Size(203, 76);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(-1, 411);
            button2.Name = "button2";
            button2.Size = new Size(203, 76);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 592);
            button3.Name = "button3";
            button3.Size = new Size(203, 70);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(406, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(406, 128);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(292, 23);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(406, 169);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(292, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(406, 223);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(292, 23);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(325, 84);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 12;
            label2.Text = "Pacijent:";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(335, 130);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 13;
            label3.Text = "Datum:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(325, 171);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 14;
            label4.Text = "Početak:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumSlateBlue;
            label5.Location = new Point(334, 223);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 15;
            label5.Text = "Usluga:";
            // 
            // button5
            // 
            button5.BackColor = Color.MediumSeaGreen;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(471, 318);
            button5.Name = "button5";
            button5.Size = new Size(136, 37);
            button5.TabIndex = 16;
            button5.Text = "Završi pregled";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(471, 409);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(236, 23);
            dateTimePicker3.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(352, 411);
            label6.Name = "label6";
            label6.Size = new Size(113, 17);
            label6.TabIndex = 18;
            label6.Text = "Raspored za dan:";
            label6.Click += label6_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1147, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 661);
            Controls.Add(label6);
            Controls.Add(dateTimePicker3);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button5;
        private DateTimePicker dateTimePicker3;
        private Label label6;
        private MenuStrip menuStrip1;
    }
}