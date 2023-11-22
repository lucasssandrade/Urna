namespace Votos
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
            btn1 = new Button();
            pictureBox1 = new PictureBox();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            lbl1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(122, 415);
            btn1.Name = "btn1";
            btn1.Size = new Size(127, 48);
            btn1.TabIndex = 0;
            btn1.Text = "Mpabbe";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.principal;
            pictureBox1.Location = new Point(122, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(457, 342);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn2
            // 
            btn2.Location = new Point(452, 415);
            btn2.Name = "btn2";
            btn2.Size = new Size(127, 48);
            btn2.TabIndex = 2;
            btn2.Text = "lulinha";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(122, 517);
            btn3.Name = "btn3";
            btn3.Size = new Size(127, 48);
            btn3.TabIndex = 3;
            btn3.Text = "moraes";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(452, 517);
            btn4.Name = "btn4";
            btn4.Size = new Size(127, 48);
            btn4.TabIndex = 4;
            btn4.Text = "felicidade";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(661, 88);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 5;
            lbl1.Text = "label1";
            lbl1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 586);
            Controls.Add(lbl1);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(pictureBox1);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private PictureBox pictureBox1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Label lbl1;
    }
}