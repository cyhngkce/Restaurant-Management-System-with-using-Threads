namespace threadsRestaurantManagement
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
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            masa1 = new Button();
            masa2 = new Button();
            masa3 = new Button();
            masa4 = new Button();
            masa5 = new Button();
            masa6 = new Button();
            garson1 = new Button();
            garson3 = new Button();
            garson2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bekleyenMusteri = new Label();
            label5 = new Label();
            asci2 = new Button();
            asci1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(324, 26);
            button1.Name = "button1";
            button1.Size = new Size(66, 29);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(665, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(436, 584);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 4;
            label1.Text = "Müşteri Sayısını Giriniz:";
            // 
            // masa1
            // 
            masa1.BackColor = Color.White;
            masa1.Location = new Point(27, 227);
            masa1.Name = "masa1";
            masa1.Size = new Size(94, 77);
            masa1.TabIndex = 5;
            masa1.UseVisualStyleBackColor = false;
            // 
            // masa2
            // 
            masa2.BackColor = Color.White;
            masa2.Location = new Point(165, 227);
            masa2.Name = "masa2";
            masa2.Size = new Size(94, 77);
            masa2.TabIndex = 6;
            masa2.UseVisualStyleBackColor = false;
            masa2.Click += button3_Click;
            // 
            // masa3
            // 
            masa3.BackColor = Color.White;
            masa3.Location = new Point(27, 318);
            masa3.Name = "masa3";
            masa3.Size = new Size(94, 77);
            masa3.TabIndex = 7;
            masa3.UseVisualStyleBackColor = false;
            masa3.Click += button4_Click;
            // 
            // masa4
            // 
            masa4.BackColor = Color.White;
            masa4.Location = new Point(165, 318);
            masa4.Name = "masa4";
            masa4.Size = new Size(94, 77);
            masa4.TabIndex = 8;
            masa4.UseVisualStyleBackColor = false;
            // 
            // masa5
            // 
            masa5.BackColor = Color.White;
            masa5.Location = new Point(27, 411);
            masa5.Name = "masa5";
            masa5.Size = new Size(94, 77);
            masa5.TabIndex = 9;
            masa5.UseVisualStyleBackColor = false;
            // 
            // masa6
            // 
            masa6.BackColor = Color.White;
            masa6.Location = new Point(165, 411);
            masa6.Name = "masa6";
            masa6.Size = new Size(94, 77);
            masa6.TabIndex = 10;
            masa6.UseVisualStyleBackColor = false;
            // 
            // garson1
            // 
            garson1.BackColor = Color.White;
            garson1.Location = new Point(416, 145);
            garson1.Name = "garson1";
            garson1.Size = new Size(94, 77);
            garson1.TabIndex = 11;
            garson1.UseVisualStyleBackColor = false;
            garson1.Click += garson1_Click;
            // 
            // garson3
            // 
            garson3.BackColor = Color.White;
            garson3.Location = new Point(505, 240);
            garson3.Name = "garson3";
            garson3.Size = new Size(94, 73);
            garson3.TabIndex = 12;
            garson3.UseVisualStyleBackColor = false;
            garson3.Click += garson3_Click;
            // 
            // garson2
            // 
            garson2.BackColor = Color.White;
            garson2.Location = new Point(327, 240);
            garson2.Name = "garson2";
            garson2.Size = new Size(94, 73);
            garson2.TabIndex = 13;
            garson2.UseVisualStyleBackColor = false;
            garson2.Click += garson2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 148);
            label2.Name = "label2";
            label2.Size = new Size(172, 46);
            label2.TabIndex = 14;
            label2.Text = "MASALAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(358, 96);
            label3.Name = "label3";
            label3.Size = new Size(213, 46);
            label3.TabIndex = 15;
            label3.Text = "GARSONLAR";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(414, 23);
            label4.Name = "label4";
            label4.Size = new Size(245, 28);
            label4.TabIndex = 16;
            label4.Text = "BEKLEYEN MÜŞTERİ SAYISI";
            label4.Click += label4_Click;
            // 
            // bekleyenMusteri
            // 
            bekleyenMusteri.AutoSize = true;
            bekleyenMusteri.Location = new Point(523, 60);
            bekleyenMusteri.Name = "bekleyenMusteri";
            bekleyenMusteri.Size = new Size(17, 20);
            bekleyenMusteri.TabIndex = 17;
            bekleyenMusteri.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(391, 349);
            label5.Name = "label5";
            label5.Size = new Size(149, 46);
            label5.TabIndex = 21;
            label5.Text = "AŞÇILAR";
            // 
            // asci2
            // 
            asci2.BackColor = Color.White;
            asci2.Location = new Point(327, 413);
            asci2.Name = "asci2";
            asci2.Size = new Size(94, 73);
            asci2.TabIndex = 20;
            asci2.UseVisualStyleBackColor = false;
            // 
            // asci1
            // 
            asci1.BackColor = Color.White;
            asci1.Location = new Point(505, 411);
            asci1.Name = "asci1";
            asci1.Size = new Size(94, 77);
            asci1.TabIndex = 18;
            asci1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 641);
            Controls.Add(label5);
            Controls.Add(asci2);
            Controls.Add(asci1);
            Controls.Add(bekleyenMusteri);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(garson2);
            Controls.Add(garson3);
            Controls.Add(garson1);
            Controls.Add(masa6);
            Controls.Add(masa5);
            Controls.Add(masa4);
            Controls.Add(masa3);
            Controls.Add(masa2);
            Controls.Add(masa1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Button masa1;
        private Button masa2;
        private Button masa3;
        private Button masa4;
        private Button masa5;
        private Button masa6;
        private Button garson1;
        private Button garson3;
        private Button garson2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label bekleyenMusteri;
        private Label label5;
        private Button asci2;
        private Button asci1;
    }
}