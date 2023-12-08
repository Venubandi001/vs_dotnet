namespace MyStore_CURD
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            I = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(276, 23);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 0;
            label1.Text = "CRUD Operation";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox1.Location = new Point(277, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 25);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(135, 155);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 3;
            label3.Text = "Item Name";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox3.Location = new Point(277, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 25);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(135, 208);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 5;
            label4.Text = "Desing";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Red", "White", "Blue", "Yellow", "Green" });
            comboBox1.Location = new Point(276, 255);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 25);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(135, 259);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 8;
            label5.Text = "Color";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(277, 304);
            button1.Name = "button1";
            button1.Size = new Size(83, 40);
            button1.TabIndex = 9;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 368);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(639, 156);
            dataGridView1.TabIndex = 10;
            // 
            // I
            // 
            I.AutoSize = true;
            I.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            I.Location = new Point(135, 97);
            I.Name = "I";
            I.Size = new Size(91, 21);
            I.TabIndex = 13;
            I.Text = "Product ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(791, 573);
            Controls.Add(I);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Button button1;
        private DataGridView dataGridView1;
        private Label I;
    }
}
