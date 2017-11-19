namespace WindowsFormsApp5
{
    partial class Form1
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
            this.box1 = new System.Windows.Forms.TextBox();
            this.No1 = new System.Windows.Forms.Button();
            this.No2 = new System.Windows.Forms.Button();
            this.No3 = new System.Windows.Forms.Button();
            this.No4 = new System.Windows.Forms.Button();
            this.No5 = new System.Windows.Forms.Button();
            this.No6 = new System.Windows.Forms.Button();
            this.No7 = new System.Windows.Forms.Button();
            this.No8 = new System.Windows.Forms.Button();
            this.No9 = new System.Windows.Forms.Button();
            this.No0 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button_leftB = new System.Windows.Forms.Button();
            this.button_rightB = new System.Windows.Forms.Button();
            this.button_ec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.box1.Enabled = false;
            this.box1.Font = new System.Drawing.Font("Digital-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box1.Location = new System.Drawing.Point(29, 12);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(237, 34);
            this.box1.TabIndex = 0;
            this.box1.Text = "0";
            this.box1.TextChanged += new System.EventHandler(this.box1_TextChanged);
            // 
            // No1
            // 
            this.No1.Location = new System.Drawing.Point(29, 62);
            this.No1.Name = "No1";
            this.No1.Size = new System.Drawing.Size(75, 23);
            this.No1.TabIndex = 1;
            this.No1.Text = "1";
            this.No1.UseVisualStyleBackColor = true;
            this.No1.Click += new System.EventHandler(this.No1_Click);
            // 
            // No2
            // 
            this.No2.Location = new System.Drawing.Point(110, 62);
            this.No2.Name = "No2";
            this.No2.Size = new System.Drawing.Size(75, 23);
            this.No2.TabIndex = 2;
            this.No2.Text = "2";
            this.No2.UseVisualStyleBackColor = true;
            this.No2.Click += new System.EventHandler(this.No2_Click);
            // 
            // No3
            // 
            this.No3.Location = new System.Drawing.Point(191, 62);
            this.No3.Name = "No3";
            this.No3.Size = new System.Drawing.Size(75, 23);
            this.No3.TabIndex = 3;
            this.No3.Text = "3";
            this.No3.UseVisualStyleBackColor = true;
            this.No3.Click += new System.EventHandler(this.No3_Click);
            // 
            // No4
            // 
            this.No4.Location = new System.Drawing.Point(29, 91);
            this.No4.Name = "No4";
            this.No4.Size = new System.Drawing.Size(75, 23);
            this.No4.TabIndex = 4;
            this.No4.Text = "4";
            this.No4.UseVisualStyleBackColor = true;
            this.No4.Click += new System.EventHandler(this.No4_Click);
            // 
            // No5
            // 
            this.No5.Location = new System.Drawing.Point(110, 91);
            this.No5.Name = "No5";
            this.No5.Size = new System.Drawing.Size(75, 23);
            this.No5.TabIndex = 5;
            this.No5.Text = "5";
            this.No5.UseVisualStyleBackColor = true;
            this.No5.Click += new System.EventHandler(this.No5_Click);
            // 
            // No6
            // 
            this.No6.Location = new System.Drawing.Point(191, 91);
            this.No6.Name = "No6";
            this.No6.Size = new System.Drawing.Size(75, 23);
            this.No6.TabIndex = 6;
            this.No6.Text = "6";
            this.No6.UseVisualStyleBackColor = true;
            this.No6.Click += new System.EventHandler(this.No6_Click);
            // 
            // No7
            // 
            this.No7.Location = new System.Drawing.Point(29, 120);
            this.No7.Name = "No7";
            this.No7.Size = new System.Drawing.Size(75, 23);
            this.No7.TabIndex = 7;
            this.No7.Text = "7";
            this.No7.UseVisualStyleBackColor = true;
            this.No7.Click += new System.EventHandler(this.No7_Click);
            // 
            // No8
            // 
            this.No8.Location = new System.Drawing.Point(110, 120);
            this.No8.Name = "No8";
            this.No8.Size = new System.Drawing.Size(75, 23);
            this.No8.TabIndex = 8;
            this.No8.Text = "8";
            this.No8.UseVisualStyleBackColor = true;
            this.No8.Click += new System.EventHandler(this.No8_Click);
            // 
            // No9
            // 
            this.No9.Location = new System.Drawing.Point(191, 120);
            this.No9.Name = "No9";
            this.No9.Size = new System.Drawing.Size(75, 23);
            this.No9.TabIndex = 9;
            this.No9.Text = "9";
            this.No9.UseVisualStyleBackColor = true;
            this.No9.Click += new System.EventHandler(this.No9_Click);
            // 
            // No0
            // 
            this.No0.Location = new System.Drawing.Point(29, 152);
            this.No0.Name = "No0";
            this.No0.Size = new System.Drawing.Size(75, 23);
            this.No0.TabIndex = 10;
            this.No0.Text = "0";
            this.No0.UseVisualStyleBackColor = true;
            this.No0.Click += new System.EventHandler(this.No0_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(110, 152);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 11;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(191, 152);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 23);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(29, 181);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(110, 181);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(75, 23);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(192, 210);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(74, 56);
            this.buttonEqual.TabIndex = 15;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // erase
            // 
            this.erase.Location = new System.Drawing.Point(30, 239);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(156, 27);
            this.erase.TabIndex = 16;
            this.erase.Text = "C";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDecimal.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonDecimal.Location = new System.Drawing.Point(191, 181);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(75, 23);
            this.buttonDecimal.TabIndex = 17;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonDecimal_Click);
            // 
            // button_leftB
            // 
            this.button_leftB.Location = new System.Drawing.Point(30, 210);
            this.button_leftB.Name = "button_leftB";
            this.button_leftB.Size = new System.Drawing.Size(75, 23);
            this.button_leftB.TabIndex = 18;
            this.button_leftB.Text = "(";
            this.button_leftB.UseVisualStyleBackColor = true;
            this.button_leftB.Click += new System.EventHandler(this.button_leftB_Click);
            // 
            // button_rightB
            // 
            this.button_rightB.Location = new System.Drawing.Point(111, 210);
            this.button_rightB.Name = "button_rightB";
            this.button_rightB.Size = new System.Drawing.Size(75, 23);
            this.button_rightB.TabIndex = 19;
            this.button_rightB.Text = ")";
            this.button_rightB.UseVisualStyleBackColor = true;
            this.button_rightB.Click += new System.EventHandler(this.button_rightB_Click);
            // 
            // button_ec
            // 
            this.button_ec.Location = new System.Drawing.Point(30, 272);
            this.button_ec.Name = "button_ec";
            this.button_ec.Size = new System.Drawing.Size(236, 42);
            this.button_ec.TabIndex = 20;
            this.button_ec.Text = "ec";
            this.button_ec.UseVisualStyleBackColor = true;
            this.button_ec.Click += new System.EventHandler(this.button_ec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 323);
            this.Controls.Add(this.button_ec);
            this.Controls.Add(this.button_rightB);
            this.Controls.Add(this.button_leftB);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.No0);
            this.Controls.Add(this.No9);
            this.Controls.Add(this.No8);
            this.Controls.Add(this.No7);
            this.Controls.Add(this.No6);
            this.Controls.Add(this.No5);
            this.Controls.Add(this.No4);
            this.Controls.Add(this.No3);
            this.Controls.Add(this.No2);
            this.Controls.Add(this.No1);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калкулатор by Veljko Stefanović";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.Button No1;
        private System.Windows.Forms.Button No2;
        private System.Windows.Forms.Button No3;
        private System.Windows.Forms.Button No4;
        private System.Windows.Forms.Button No5;
        private System.Windows.Forms.Button No6;
        private System.Windows.Forms.Button No7;
        private System.Windows.Forms.Button No8;
        private System.Windows.Forms.Button No9;
        private System.Windows.Forms.Button No0;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button button_leftB;
        private System.Windows.Forms.Button button_rightB;
        private System.Windows.Forms.Button button_ec;
    }
}

