namespace StrongPassword
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
            this.btnTestRegex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGetRan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestRegex
            // 
            this.btnTestRegex.Location = new System.Drawing.Point(27, 76);
            this.btnTestRegex.Name = "btnTestRegex";
            this.btnTestRegex.Size = new System.Drawing.Size(75, 23);
            this.btnTestRegex.TabIndex = 0;
            this.btnTestRegex.Text = "Test Regex";
            this.btnTestRegex.UseVisualStyleBackColor = true;
            this.btnTestRegex.Click += new System.EventHandler(this.btnTestRegex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Strong Password Regex:";
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(154, 12);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(269, 20);
            this.txtRegex.TabIndex = 2;
            this.txtRegex.Text = "^(?=.*[A-Z])(?=.*[^\\w\\s])(?=.*[0-9]).{8,}$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Explanation: ^ Start enchor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "(?=.*[A-Z]) Ensure string has one uppercase letter.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "(?=.*[^\\w\\s]) Ensure string has one not alphanumeric or space letter.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "(?=.*[0-9]) Ensure string has one digit.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = ".{8} Ensure string is at least of length 8.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "$ End anchor.";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(154, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(269, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Your New Password:";
            // 
            // btnGetRan
            // 
            this.btnGetRan.Location = new System.Drawing.Point(108, 76);
            this.btnGetRan.Name = "btnGetRan";
            this.btnGetRan.Size = new System.Drawing.Size(105, 23);
            this.btnGetRan.TabIndex = 11;
            this.btnGetRan.Text = "Random Password";
            this.btnGetRan.UseVisualStyleBackColor = true;
            this.btnGetRan.Click += new System.EventHandler(this.btnGetRan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 262);
            this.Controls.Add(this.btnGetRan);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestRegex);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strong Password Regex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGetRan;
    }
}

