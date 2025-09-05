namespace S01_OOPDemoApp_Win
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblspecies = new System.Windows.Forms.Label();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(39, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "NAME:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblspecies
            // 
            this.lblspecies.AutoSize = true;
            this.lblspecies.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblspecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspecies.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblspecies.Location = new System.Drawing.Point(28, 95);
            this.lblspecies.Name = "lblspecies";
            this.lblspecies.Size = new System.Drawing.Size(63, 13);
            this.lblspecies.TabIndex = 2;
            this.lblspecies.Text = "SPECIES:";
            this.lblspecies.Click += new System.EventHandler(this.lblspecies_Click);
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(100, 88);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(221, 20);
            this.txtSpecies.TabIndex = 3;
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(246, 114);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 23);
            this.btnSpeak.TabIndex = 4;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOutput.Location = new System.Drawing.Point(39, 137);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "OUTPUT";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(352, 173);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.lblspecies);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblspecies;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Label lblOutput;
    }
}

