namespace first
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
            boxbin = new ComboBox();
            boxvaris = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            boxsaat = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txttc = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            veriler = new ListBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            buttondegis = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            txtadsoy = new TextBox();
            panel1 = new Panel();
            label16 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // boxbin
            // 
            boxbin.FormattingEnabled = true;
            boxbin.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya", "Çanakkale", "Erzurum", "Gaziantep", "Edirne" });
            boxbin.Location = new Point(117, 256);
            boxbin.Name = "boxbin";
            boxbin.Size = new Size(142, 28);
            boxbin.TabIndex = 0;
            boxbin.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // boxvaris
            // 
            boxvaris.FormattingEnabled = true;
            boxvaris.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya", "Çanakkale", "Erzurum", "Gaziantep", "Edirne" });
            boxvaris.Location = new Point(117, 290);
            boxvaris.Name = "boxvaris";
            boxvaris.Size = new Size(142, 28);
            boxvaris.TabIndex = 1;
            boxvaris.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 259);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "Biniş Yeri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 293);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 3;
            label2.Text = "Varış Yeri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 194);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 5;
            label3.Text = "Uçuş Tarihi";
            // 
            // boxsaat
            // 
            boxsaat.FormattingEnabled = true;
            boxsaat.Items.AddRange(new object[] { "05.00", "06.00", "07.00", "08.00", "09.00", "10.00", "11.00", "12.00", "13.00", "14.00", "15.00", "16.00" });
            boxsaat.Location = new Point(117, 222);
            boxsaat.Name = "boxsaat";
            boxsaat.Size = new Size(142, 28);
            boxsaat.TabIndex = 6;
            boxsaat.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 225);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "Uçuş Saati";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 95);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 9;
            label5.Text = "Ad-Soyad";
            // 
            // txttc
            // 
            txttc.Location = new Point(119, 125);
            txttc.MaxLength = 11;
            txttc.Name = "txttc";
            txttc.Size = new Size(157, 27);
            txttc.TabIndex = 10;
            txttc.TextChanged += textBox2_TextChanged;
            txttc.KeyPress += txttc_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 128);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 11;
            label6.Text = "TC Kimlik";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 159);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 13;
            label7.Text = "Telefon ";
            // 
            // button1
            // 
            button1.Location = new Point(198, 334);
            button1.Name = "button1";
            button1.Size = new Size(87, 32);
            button1.TabIndex = 14;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // veriler
            // 
            veriler.FormattingEnabled = true;
            veriler.Location = new Point(438, 92);
            veriler.Name = "veriler";
            veriler.Size = new Size(184, 244);
            veriler.TabIndex = 17;
            veriler.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(436, 55);
            label8.Name = "label8";
            label8.Size = new Size(62, 35);
            label8.TabIndex = 18;
            label8.Text = "Bilet";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(356, 94);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 19;
            label9.Text = "Ad-Soyad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(356, 114);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 20;
            label10.Text = "TC Kimlik:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(356, 134);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 21;
            label11.Text = "Telefon:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(356, 154);
            label12.Name = "label12";
            label12.Size = new Size(71, 20);
            label12.TabIndex = 22;
            label12.Text = "Biniş Yeri:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(356, 174);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 23;
            label13.Text = "Varış Yeri:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(356, 194);
            label14.Name = "label14";
            label14.Size = new Size(82, 20);
            label14.TabIndex = 24;
            label14.Text = "Uçuş Tarihi:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(356, 214);
            label15.Name = "label15";
            label15.Size = new Size(80, 20);
            label15.TabIndex = 25;
            label15.Text = "Uçuş Saati:";
            // 
            // buttondegis
            // 
            buttondegis.Font = new Font("Segoe UI", 20F);
            buttondegis.ImageAlign = ContentAlignment.TopCenter;
            buttondegis.Location = new Point(265, 262);
            buttondegis.Name = "buttondegis";
            buttondegis.Size = new Size(62, 51);
            buttondegis.TabIndex = 26;
            buttondegis.Text = "↑↓";
            buttondegis.UseVisualStyleBackColor = true;
            buttondegis.Click += buttondegis_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(119, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 27);
            dateTimePicker1.TabIndex = 27;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button2
            // 
            button2.Location = new Point(105, 334);
            button2.Name = "button2";
            button2.Size = new Size(87, 32);
            button2.TabIndex = 28;
            button2.Text = "Sıfırla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(119, 156);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(157, 27);
            maskedTextBox1.TabIndex = 29;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txtadsoy
            // 
            txtadsoy.Location = new Point(119, 92);
            txtadsoy.Name = "txtadsoy";
            txtadsoy.Size = new Size(157, 27);
            txtadsoy.TabIndex = 30;
            txtadsoy.TextChanged += txtadsoy_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label16);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(66, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 57);
            panel1.TabIndex = 31;
            panel1.Paint += panel1_Paint;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 22F);
            label16.Location = new Point(53, 3);
            label16.Name = "label16";
            label16.Size = new Size(269, 50);
            label16.TabIndex = 33;
            label16.Text = "Turkish Airlines";
            label16.Click += label16_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.indir2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 56);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 381);
            Controls.Add(panel1);
            Controls.Add(txtadsoy);
            Controls.Add(maskedTextBox1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttondegis);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(veriler);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txttc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(boxsaat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(boxvaris);
            Controls.Add(boxbin);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox boxbin;
        private ComboBox boxvaris;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox boxsaat;
        private Label label4;
        private Label label5;
        private TextBox txttc;
        private Label label6;
        private Label label7;
        private Button button1;
        private ListBox veriler;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button buttondegis;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtadsoy;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label16;
    }
}
