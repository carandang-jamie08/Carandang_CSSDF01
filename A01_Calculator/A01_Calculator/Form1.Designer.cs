namespace A01_Calculator
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
            textEquation = new TextBox();
            textDisplay = new TextBox();
            btnEqual = new Button();
            btnMinus = new Button();
            btnDivide = new Button();
            btnTimes = new Button();
            btnErase = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btn2 = new Button();
            btnDot = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btnSettings = new Button();
            txtHistory = new TextBox();
            lblHistory = new Label();
            SuspendLayout();
            // 
            // textEquation
            // 
            textEquation.BackColor = Color.Silver;
            textEquation.BorderStyle = BorderStyle.FixedSingle;
            textEquation.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEquation.Location = new Point(12, 32);
            textEquation.Name = "textEquation";
            textEquation.Size = new Size(204, 31);
            textEquation.TabIndex = 0;
            // 
            // textDisplay
            // 
            textDisplay.BorderStyle = BorderStyle.FixedSingle;
            textDisplay.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDisplay.Location = new Point(12, 71);
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(204, 40);
            textDisplay.TabIndex = 1;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 192, 192);
            btnEqual.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btnEqual.Location = new Point(170, 302);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(46, 38);
            btnEqual.TabIndex = 11;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 192, 192);
            btnMinus.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btnMinus.Location = new Point(170, 258);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(46, 38);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += Operator;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 192, 192);
            btnDivide.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btnDivide.Location = new Point(170, 214);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(46, 38);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += Operator;
            // 
            // btnTimes
            // 
            btnTimes.BackColor = Color.FromArgb(255, 192, 192);
            btnTimes.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btnTimes.Location = new Point(170, 170);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(46, 38);
            btnTimes.TabIndex = 14;
            btnTimes.Text = "*";
            btnTimes.UseVisualStyleBackColor = false;
            btnTimes.Click += Operator;
            // 
            // btnErase
            // 
            btnErase.BackColor = Color.FromArgb(255, 192, 192);
            btnErase.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btnErase.Location = new Point(170, 126);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(46, 38);
            btnErase.TabIndex = 15;
            btnErase.Text = "⌫";
            btnErase.UseVisualStyleBackColor = false;
            btnErase.Click += btnErase_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btnDelete.Location = new Point(118, 126);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(46, 38);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "C";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 192);
            btnClear.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(66, 126);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(46, 38);
            btnClear.TabIndex = 17;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(255, 192, 192);
            btn9.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btn9.Location = new Point(118, 170);
            btn9.Name = "btn9";
            btn9.Size = new Size(46, 38);
            btn9.TabIndex = 18;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Load_Key;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(255, 192, 192);
            btn8.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btn8.Location = new Point(66, 170);
            btn8.Name = "btn8";
            btn8.Size = new Size(46, 38);
            btn8.TabIndex = 19;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Load_Key;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(255, 192, 192);
            btn7.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btn7.Location = new Point(14, 170);
            btn7.Name = "btn7";
            btn7.Size = new Size(46, 38);
            btn7.TabIndex = 20;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Load_Key;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(255, 192, 192);
            btn6.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btn6.Location = new Point(118, 214);
            btn6.Name = "btn6";
            btn6.Size = new Size(46, 38);
            btn6.TabIndex = 21;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Load_Key;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(255, 192, 192);
            btn5.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btn5.Location = new Point(66, 214);
            btn5.Name = "btn5";
            btn5.Size = new Size(46, 38);
            btn5.TabIndex = 22;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Load_Key;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(255, 192, 192);
            btn4.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btn4.Location = new Point(14, 214);
            btn4.Name = "btn4";
            btn4.Size = new Size(46, 38);
            btn4.TabIndex = 23;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Load_Key;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(255, 192, 192);
            btn3.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btn3.Location = new Point(118, 258);
            btn3.Name = "btn3";
            btn3.Size = new Size(46, 38);
            btn3.TabIndex = 24;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Load_Key;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 192, 192);
            btnPlus.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btnPlus.Location = new Point(118, 302);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(46, 38);
            btnPlus.TabIndex = 25;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += Operator;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(255, 192, 192);
            btn2.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btn2.Location = new Point(66, 258);
            btn2.Name = "btn2";
            btn2.Size = new Size(46, 38);
            btn2.TabIndex = 26;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Load_Key;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(255, 192, 192);
            btnDot.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btnDot.Location = new Point(66, 302);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(46, 38);
            btnDot.TabIndex = 27;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += Load_Key;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(255, 192, 192);
            btn1.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btn1.Location = new Point(14, 258);
            btn1.Name = "btn1";
            btn1.Size = new Size(46, 38);
            btn1.TabIndex = 28;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Load_Key;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(255, 192, 192);
            btn0.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold);
            btn0.Location = new Point(14, 302);
            btn0.Name = "btn0";
            btn0.Size = new Size(46, 38);
            btn0.TabIndex = 29;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Load_Key;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Impact", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(183, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(33, 23);
            btnSettings.TabIndex = 30;
            btnSettings.Text = "☰";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // txtHistory
            // 
            txtHistory.BackColor = Color.FromArgb(255, 128, 128);
            txtHistory.Location = new Point(222, 32);
            txtHistory.Multiline = true;
            txtHistory.Name = "txtHistory";
            txtHistory.Size = new Size(129, 308);
            txtHistory.TabIndex = 31;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Lucida Calligraphy", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistory.Location = new Point(225, 12);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(95, 20);
            lblHistory.TabIndex = 32;
            lblHistory.Text = "HISTORY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(355, 352);
            Controls.Add(lblHistory);
            Controls.Add(txtHistory);
            Controls.Add(btnSettings);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btnDot);
            Controls.Add(btn2);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnErase);
            Controls.Add(btnTimes);
            Controls.Add(btnDivide);
            Controls.Add(btnMinus);
            Controls.Add(btnEqual);
            Controls.Add(textDisplay);
            Controls.Add(textEquation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "CALCULATOR";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textEquation;
        private TextBox textDisplay;
        private Button btnEqual;
        private Button btnMinus;
        private Button btnDivide;
        private Button btnTimes;
        private Button btnErase;
        private Button btnDelete;
        private Button btnClear;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btnPlus;
        private Button btn2;
        private Button btnDot;
        private Button btn1;
        private Button btn0;
        private Button btnSettings;
        private TextBox txtHistory;
        private Label lblHistory;
    }
}
