namespace NET_lab3_Macierze
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
            this.thread_calculate = new System.Windows.Forms.Button();
            this.A_textBox = new System.Windows.Forms.TextBox();
            this.B_textBox = new System.Windows.Forms.TextBox();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.times_textBox = new System.Windows.Forms.TextBox();
            this.losowe_macierze_button = new System.Windows.Forms.Button();
            this.row_A = new System.Windows.Forms.TextBox();
            this.column_A = new System.Windows.Forms.TextBox();
            this.row_B = new System.Windows.Forms.TextBox();
            this.column_B = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.parallel_calculate = new System.Windows.Forms.Button();
            this.thread_parallel_comparision = new System.Windows.Forms.Button();
            this.number_of_threads = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thread_calculate
            // 
            this.thread_calculate.Location = new System.Drawing.Point(513, 173);
            this.thread_calculate.Name = "thread_calculate";
            this.thread_calculate.Size = new System.Drawing.Size(97, 41);
            this.thread_calculate.TabIndex = 0;
            this.thread_calculate.Text = "Oblicz Thread";
            this.thread_calculate.UseVisualStyleBackColor = true;
            this.thread_calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // A_textBox
            // 
            this.A_textBox.Location = new System.Drawing.Point(12, 85);
            this.A_textBox.Multiline = true;
            this.A_textBox.Name = "A_textBox";
            this.A_textBox.Size = new System.Drawing.Size(234, 365);
            this.A_textBox.TabIndex = 1;
            // 
            // B_textBox
            // 
            this.B_textBox.Location = new System.Drawing.Point(264, 85);
            this.B_textBox.Multiline = true;
            this.B_textBox.Name = "B_textBox";
            this.B_textBox.Size = new System.Drawing.Size(234, 365);
            this.B_textBox.TabIndex = 2;
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(625, 85);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.Size = new System.Drawing.Size(234, 365);
            this.result_textBox.TabIndex = 3;
            // 
            // times_textBox
            // 
            this.times_textBox.Location = new System.Drawing.Point(865, 85);
            this.times_textBox.Multiline = true;
            this.times_textBox.Name = "times_textBox";
            this.times_textBox.Size = new System.Drawing.Size(234, 365);
            this.times_textBox.TabIndex = 4;
            // 
            // losowe_macierze_button
            // 
            this.losowe_macierze_button.Location = new System.Drawing.Point(85, 13);
            this.losowe_macierze_button.Name = "losowe_macierze_button";
            this.losowe_macierze_button.Size = new System.Drawing.Size(331, 23);
            this.losowe_macierze_button.TabIndex = 5;
            this.losowe_macierze_button.Text = "Generuj losowe macierze";
            this.losowe_macierze_button.UseVisualStyleBackColor = true;
            this.losowe_macierze_button.Click += new System.EventHandler(this.losowe_macierze_button_Click);
            // 
            // row_A
            // 
            this.row_A.Location = new System.Drawing.Point(67, 465);
            this.row_A.Name = "row_A";
            this.row_A.Size = new System.Drawing.Size(100, 23);
            this.row_A.TabIndex = 6;
            this.row_A.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // column_A
            // 
            this.column_A.Location = new System.Drawing.Point(67, 510);
            this.column_A.Name = "column_A";
            this.column_A.Size = new System.Drawing.Size(100, 23);
            this.column_A.TabIndex = 7;
            // 
            // row_B
            // 
            this.row_B.Location = new System.Drawing.Point(338, 465);
            this.row_B.Name = "row_B";
            this.row_B.Size = new System.Drawing.Size(100, 23);
            this.row_B.TabIndex = 8;
            // 
            // column_B
            // 
            this.column_B.Location = new System.Drawing.Point(338, 510);
            this.column_B.Name = "column_B";
            this.column_B.Size = new System.Drawing.Size(100, 23);
            this.column_B.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wynik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(881, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Średnia arytmetyczna pomiarów czasów";
            // 
            // parallel_calculate
            // 
            this.parallel_calculate.Location = new System.Drawing.Point(513, 242);
            this.parallel_calculate.Name = "parallel_calculate";
            this.parallel_calculate.Size = new System.Drawing.Size(97, 41);
            this.parallel_calculate.TabIndex = 14;
            this.parallel_calculate.Text = "Oblicz Parallel";
            this.parallel_calculate.UseVisualStyleBackColor = true;
            this.parallel_calculate.Click += new System.EventHandler(this.parallel_calculate_Click);
            // 
            // thread_parallel_comparision
            // 
            this.thread_parallel_comparision.Location = new System.Drawing.Point(513, 324);
            this.thread_parallel_comparision.Name = "thread_parallel_comparision";
            this.thread_parallel_comparision.Size = new System.Drawing.Size(106, 41);
            this.thread_parallel_comparision.TabIndex = 15;
            this.thread_parallel_comparision.Text = "Porównaj Thread i Parallel";
            this.thread_parallel_comparision.UseVisualStyleBackColor = true;
            this.thread_parallel_comparision.Click += new System.EventHandler(this.thread_parallel_comparision_Click);
            // 
            // number_of_threads
            // 
            this.number_of_threads.Location = new System.Drawing.Point(513, 47);
            this.number_of_threads.Multiline = true;
            this.number_of_threads.Name = "number_of_threads";
            this.number_of_threads.Size = new System.Drawing.Size(105, 23);
            this.number_of_threads.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Podaj liczbę wątków!!!!!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rzędy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rzędy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kolumny";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Kolumny";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 542);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.number_of_threads);
            this.Controls.Add(this.thread_parallel_comparision);
            this.Controls.Add(this.parallel_calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.column_B);
            this.Controls.Add(this.row_B);
            this.Controls.Add(this.column_A);
            this.Controls.Add(this.row_A);
            this.Controls.Add(this.losowe_macierze_button);
            this.Controls.Add(this.times_textBox);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.B_textBox);
            this.Controls.Add(this.A_textBox);
            this.Controls.Add(this.thread_calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button thread_calculate;
        private TextBox A_textBox;
        private TextBox B_textBox;
        private TextBox result_textBox;
        private TextBox times_textBox;
        private Button losowe_macierze_button;
        private TextBox row_A;
        private TextBox column_A;
        private TextBox row_B;
        private TextBox column_B;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button parallel_calculate;
        private Button thread_parallel_comparision;
        private TextBox number_of_threads;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}