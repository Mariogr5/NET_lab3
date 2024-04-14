namespace NET_lab3_obrazyy
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
            this.circular_image = new System.Windows.Forms.PictureBox();
            this.threshold_image = new System.Windows.Forms.PictureBox();
            this.grayscale_image = new System.Windows.Forms.PictureBox();
            this.flipped_image = new System.Windows.Forms.PictureBox();
            this.original = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.process = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.circular_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshold_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscale_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flipped_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.original)).BeginInit();
            this.SuspendLayout();
            // 
            // circular_image
            // 
            this.circular_image.Location = new System.Drawing.Point(786, 37);
            this.circular_image.Name = "circular_image";
            this.circular_image.Size = new System.Drawing.Size(246, 247);
            this.circular_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circular_image.TabIndex = 0;
            this.circular_image.TabStop = false;
            // 
            // threshold_image
            // 
            this.threshold_image.Location = new System.Drawing.Point(443, 37);
            this.threshold_image.Name = "threshold_image";
            this.threshold_image.Size = new System.Drawing.Size(246, 247);
            this.threshold_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.threshold_image.TabIndex = 1;
            this.threshold_image.TabStop = false;
            // 
            // grayscale_image
            // 
            this.grayscale_image.Location = new System.Drawing.Point(443, 381);
            this.grayscale_image.Name = "grayscale_image";
            this.grayscale_image.Size = new System.Drawing.Size(246, 247);
            this.grayscale_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grayscale_image.TabIndex = 2;
            this.grayscale_image.TabStop = false;
            // 
            // flipped_image
            // 
            this.flipped_image.Location = new System.Drawing.Point(786, 381);
            this.flipped_image.Name = "flipped_image";
            this.flipped_image.Size = new System.Drawing.Size(246, 247);
            this.flipped_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flipped_image.TabIndex = 3;
            this.flipped_image.TabStop = false;
            // 
            // original
            // 
            this.original.Location = new System.Drawing.Point(60, 202);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(246, 247);
            this.original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.original.TabIndex = 4;
            this.original.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Wybierz Zdjęcie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(110, 594);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(135, 23);
            this.process.TabIndex = 6;
            this.process.Text = "Przetwórz";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 698);
            this.Controls.Add(this.process);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.original);
            this.Controls.Add(this.flipped_image);
            this.Controls.Add(this.grayscale_image);
            this.Controls.Add(this.threshold_image);
            this.Controls.Add(this.circular_image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.circular_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshold_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscale_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flipped_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.original)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox circular_image;
        private PictureBox threshold_image;
        private PictureBox grayscale_image;
        private PictureBox flipped_image;
        private PictureBox original;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Button process;
    }
}