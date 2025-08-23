namespace A01_Calculator
{
    partial class Calculator
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
            btn0 = new Button();
            btnDot = new Button();
            btnplus = new Button();
            btnEqual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMinus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            button6 = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtEquation = new TextBox();
            txtDisplay = new TextBox();
            btnSetting = new Button();
            txtHistory = new TextBox();
            lblHistory = new Label();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(255, 128, 128);
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(3, 343);
            btn0.Name = "btn0";
            btn0.Size = new Size(45, 43);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Load_Key;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(255, 128, 128);
            btnDot.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(54, 343);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(45, 43);
            btnDot.TabIndex = 1;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += Load_Key;
            // 
            // btnplus
            // 
            btnplus.BackColor = Color.FromArgb(255, 128, 128);
            btnplus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnplus.Location = new Point(105, 343);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(45, 43);
            btnplus.TabIndex = 2;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = false;
            btnplus.Click += Operator;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 128, 128);
            btnEqual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(156, 344);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(45, 43);
            btnEqual.TabIndex = 3;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(255, 128, 128);
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(3, 294);
            btn1.Name = "btn1";
            btn1.Size = new Size(45, 43);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Load_Key;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(255, 128, 128);
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(54, 294);
            btn2.Name = "btn2";
            btn2.Size = new Size(45, 43);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Load_Key;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(255, 128, 128);
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(105, 294);
            btn3.Name = "btn3";
            btn3.Size = new Size(45, 43);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Load_Key;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 128);
            btnMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(156, 294);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(45, 43);
            btnMinus.TabIndex = 7;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += Operator;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(255, 128, 128);
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(3, 245);
            btn4.Name = "btn4";
            btn4.Size = new Size(45, 43);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Load_Key;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(255, 128, 128);
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(54, 245);
            btn5.Name = "btn5";
            btn5.Size = new Size(45, 43);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Load_Key;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(255, 128, 128);
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(105, 245);
            btn6.Name = "btn6";
            btn6.Size = new Size(45, 43);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Load_Key;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 128);
            btnDivide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(156, 245);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(45, 43);
            btnDivide.TabIndex = 11;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += Operator;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(255, 128, 128);
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(3, 196);
            btn7.Name = "btn7";
            btn7.Size = new Size(45, 43);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Load_Key;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(255, 128, 128);
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(54, 196);
            btn8.Name = "btn8";
            btn8.Size = new Size(45, 43);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Load_Key;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(255, 128, 128);
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(105, 196);
            btn9.Name = "btn9";
            btn9.Size = new Size(45, 43);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Load_Key;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 128);
            btnMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(156, 196);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(45, 43);
            btnMultiply.TabIndex = 15;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += Operator;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 128, 128);
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(156, 147);
            button6.Name = "button6";
            button6.Size = new Size(45, 43);
            button6.TabIndex = 16;
            button6.Text = "⌫";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(105, 147);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(45, 43);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "C";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 128);
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(54, 147);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(45, 43);
            btnClear.TabIndex = 18;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtEquation
            // 
            txtEquation.BackColor = Color.FromArgb(255, 128, 128);
            txtEquation.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEquation.Location = new Point(3, 51);
            txtEquation.Name = "txtEquation";
            txtEquation.Size = new Size(198, 29);
            txtEquation.TabIndex = 19;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(3, 90);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(198, 50);
            txtDisplay.TabIndex = 20;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(255, 128, 128);
            btnSetting.Location = new Point(156, 9);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(45, 36);
            btnSetting.TabIndex = 21;
            btnSetting.Text = "☰";
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // txtHistory
            // 
            txtHistory.Location = new Point(207, 51);
            txtHistory.Multiline = true;
            txtHistory.Name = "txtHistory";
            txtHistory.Size = new Size(144, 335);
            txtHistory.TabIndex = 22;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistory.Location = new Point(207, 30);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(58, 15);
            lblHistory.TabIndex = 23;
            lblHistory.Text = "HISTORY";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(363, 407);
            Controls.Add(lblHistory);
            Controls.Add(txtHistory);
            Controls.Add(btnSetting);
            Controls.Add(txtDisplay);
            Controls.Add(txtEquation);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(button6);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDivide);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMinus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEqual);
            Controls.Add(btnplus);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn0;
        private Button btnDot;
        private Button btnplus;
        private Button btnEqual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMinus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button button6;
        private Button btnDelete;
        private Button btnClear;
        private TextBox txtEquation;
        private TextBox txtDisplay;
        private Button btnSetting;
        private TextBox txtHistory;
        private Label lblHistory;
    }
}
