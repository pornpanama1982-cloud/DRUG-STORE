namespace WinFormsApp2
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
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            button3 = new Button();
            textBox7 = new TextBox();
            label8 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 25F);
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(740, 70);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "ร้านค้ายา ของน้องแตม";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 537);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลสินค้า";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "ชื่อสินค้า";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 28);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "แบรนด์";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 5;
            label3.Text = "ราคา";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 7;
            label4.Text = "จำนวนสินค้า";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 27);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(12, 247);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "ขาย";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 251);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "จำนวน";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(209, 247);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(209, 291);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 27);
            textBox5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 295);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 13;
            label6.Text = "จำนวน";
            // 
            // button2
            // 
            button2.Location = new Point(12, 291);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "ขาย";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(209, 338);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(97, 27);
            textBox6.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(134, 342);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 13;
            label7.Text = "จำนวน";
            // 
            // button3
            // 
            button3.Location = new Point(12, 338);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "ขาย";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(209, 386);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(97, 27);
            textBox7.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(134, 390);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 16;
            label8.Text = "จำนวน";
            // 
            // button4
            // 
            button4.Location = new Point(12, 386);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 15;
            button4.Text = "ขาย";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 434);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 18;
            button5.Text = "ลบสินค้า";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(209, 434);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 19;
            button6.Text = "ล้าง";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 482);
            button7.Name = "button7";
            button7.Size = new Size(144, 29);
            button7.TabIndex = 20;
            button7.Text = "ขาย";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(159, 482);
            button8.Name = "button8";
            button8.Size = new Size(144, 29);
            button8.TabIndex = 21;
            button8.Text = "ขาย";
            button8.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(408, 526);
            dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 678);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private Label label6;
        private Button button2;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private TextBox textBox7;
        private Label label8;
        private Button button4;
        private TextBox textBox6;
        private Label label7;
        private Button button3;
        private DataGridView dataGridView1;
    }
}
