namespace TIcTacToe
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(217, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(199, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "СТОРОНА";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "O";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(39, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "X";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(199, 68);
            button1.TabIndex = 0;
            button1.Text = "Перезапустить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 56);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(95, 24);
            radioButton3.TabIndex = 1;
            radioButton3.Text = "СЛОЖНО";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(6, 26);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(75, 24);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "ЛЕГКО";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(422, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 80);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "СЛОЖНОСТЬ";
            // 
            // button2
            // 
            button2.Font = new Font("UD Digi Kyokasho NP-B", 90F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(16, 91);
            button2.Name = "button2";
            button2.Size = new Size(200, 200);
            button2.TabIndex = 3;
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("UD Digi Kyokasho NP-B", 90F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(216, 91);
            button3.Name = "button3";
            button3.Size = new Size(200, 200);
            button3.TabIndex = 4;
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("UD Digi Kyokasho NP-B", 90F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(416, 91);
            button4.Name = "button4";
            button4.Size = new Size(200, 200);
            button4.TabIndex = 5;
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("UD Digi Kyokasho NP-B", 90F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(16, 291);
            button5.Name = "button5";
            button5.Size = new Size(200, 200);
            button5.TabIndex = 6;
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("UD Digi Kyokasho NP-B", 90F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(216, 291);
            button6.Name = "button6";
            button6.Size = new Size(200, 200);
            button6.TabIndex = 7;
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("UD Digi Kyokasho NP-B", 90F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(416, 291);
            button7.Name = "button7";
            button7.Size = new Size(200, 200);
            button7.TabIndex = 8;
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("UD Digi Kyokasho NP-B", 90F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(16, 491);
            button8.Name = "button8";
            button8.Size = new Size(200, 200);
            button8.TabIndex = 9;
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("UD Digi Kyokasho NP-B", 90F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(216, 491);
            button9.Name = "button9";
            button9.Size = new Size(200, 200);
            button9.TabIndex = 10;
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("UD Digi Kyokasho NP-B", 90F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(416, 491);
            button10.Name = "button10";
            button10.Size = new Size(200, 200);
            button10.TabIndex = 11;
            button10.TextAlign = ContentAlignment.MiddleRight;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 703);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "TicTacToe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private List<Button> buttons;
        //private Button[,] Buttons;
    }
}