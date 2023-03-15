namespace Login
{
    partial class log
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
            this.login = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(306, 290);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 40);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.FontChanged += new System.EventHandler(this.Register_FontChanged);
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(180, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(382, 30);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(180, 189);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(382, 30);
            this.password.TabIndex = 2;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(306, 375);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(88, 34);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset ";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.FontChanged += new System.EventHandler(this.Register_FontChanged);
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forgot password:";
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(306, 463);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(113, 40);
            this.Register.TabIndex = 7;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.FontChanged += new System.EventHandler(this.Register_FontChanged);
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "For Registration:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "login page";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 577);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.login);
            this.Name = "log";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

