using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class log : Form
    {
        public string pswrd, uid;
        public log()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            try 
            {
                var sr = new System.IO.StreamReader("D:\\project" + textBox4.Text + "\\log.DI");
                uid = sr.ReadLine();
                pswrd = sr.ReadLine();
                sr.Close();
                if (uid== textBox4.Text && pswrd == password.Text)
                {
                    MessageBox.Show("you are logged in"," success");
                }
                else
                {
                    MessageBox.Show("your password or username is incorrect"," incorrect");
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show("user Dosent exist "," Error");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            log f = new log();
            f.Hide();

        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_password reset = new reset_password();
            reset.Show();
        }

        private void Register_FontChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
