namespace Araç_Kullanimlari2
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            listBox2 = new ListBox();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa", "Ankara", "Balıkesir", "İzmir", "Malatya", "İstanbul" });
            comboBox1.Location = new Point(37, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 32);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 1;
            label1.Text = "Şehirler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 36);
            label2.Name = "label2";
            label2.Size = new Size(59, 24);
            label2.TabIndex = 2;
            label2.Text = "Şehir:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 32);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(397, 90);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 4;
            button1.Text = "Şehir ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "öğretmen", "doktor ", "mühendis" });
            listBox1.Location = new Point(711, 164);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 100);
            listBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(755, 288);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(726, 99);
            button3.Name = "button3";
            button3.Size = new Size(153, 29);
            button3.TabIndex = 7;
            button3.Text = "meslek ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(666, 60);
            label3.Name = "label3";
            label3.Size = new Size(75, 24);
            label3.TabIndex = 8;
            label3.Text = "meslek:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(764, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 32);
            textBox2.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(120, 164);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 32);
            maskedTextBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 164);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 11;
            label4.Text = "Tel no";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 230);
            label5.Name = "label5";
            label5.Size = new Size(38, 24);
            label5.TabIndex = 13;
            label5.Text = "TC:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(120, 230);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 32);
            maskedTextBox2.TabIndex = 12;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 288);
            label6.Name = "label6";
            label6.Size = new Size(58, 24);
            label6.TabIndex = 15;
            label6.Text = "Tarih:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(120, 288);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(125, 32);
            maskedTextBox3.TabIndex = 14;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(352, 154);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(205, 196);
            listBox2.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(120, 354);
            button4.Name = "button4";
            button4.Size = new Size(125, 46);
            button4.TabIndex = 17;
            button4.Text = "kaydet";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(120, 469);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(61, 566);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 32);
            dateTimePicker1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1100, 704);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(listBox2);
            Controls.Add(label6);
            Controls.Add(maskedTextBox3);
            Controls.Add(label5);
            Controls.Add(maskedTextBox2);
            Controls.Add(label4);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Araç Kullanımları";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Label label3;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private MaskedTextBox maskedTextBox3;
        private ListBox listBox2;
        private Button button4;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
    }
}
