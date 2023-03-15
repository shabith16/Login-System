namespace Login
{
    partial class reset_password
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
            this.mail2 = new System.Windows.Forms.TextBox();
            this.otp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.verify = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mail2
            // 
            this.mail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail2.Location = new System.Drawing.Point(232, 229);
            this.mail2.Name = "mail2";
            this.mail2.Size = new System.Drawing.Size(329, 30);
            this.mail2.TabIndex = 0;
            this.mail2.TextChanged += new System.EventHandler(this.mail2_TextChanged);
            // 
            // otp
            // 
            this.otp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otp.Location = new System.Drawing.Point(232, 393);
            this.otp.Name = "otp";
            this.otp.Size = new System.Drawing.Size(279, 30);
            this.otp.TabIndex = 1;
            this.otp.TextChanged += new System.EventHandler(this.otp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mail:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "OTP:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // verify
            // 
            this.verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify.Location = new System.Drawing.Point(280, 573);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(93, 44);
            this.verify.TabIndex = 4;
            this.verify.Text = "Reset";
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(232, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "User name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reset Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(232, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate OTP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(232, 482);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 30);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "New password";
            // 
            // reset_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otp);
            this.Controls.Add(this.mail2);
            this.Name = "reset_password";
            this.Text = "reset_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mail2;
        private System.Windows.Forms.TextBox otp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verify;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}