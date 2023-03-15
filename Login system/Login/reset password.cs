using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail; 

namespace Login
{
    public partial class reset_password : Form
    {
        reg_and_login reg = new reg_and_login();
        int OTP=0;
        string code;
        public reset_password()
        {
            InitializeComponent();
        }

        private void verify_Click(object sender, EventArgs e)
        {

            if (ott.ToString().Equals(otp.Text))
            {
                try
                {
                    var sr = new System.IO.StreamReader("D:\\project" + textBox1.Text + "\\log.DI");
                    string ui = sr.ReadLine();
                    string pw = sr.ReadLine();
                    string name = sr.ReadLine();
                    string age = sr.ReadLine();
                    string dob = sr.ReadLine();
                    string gmail = sr.ReadLine();
                    string add = sr.ReadLine();

                    var sw = new System.IO.StreamWriter("D:\\project" + textBox1.Text + "\\log.DI");
                    sw.Write(ui + "\n" + textBox2.Text + "\n" + name + "\n" + age + "\n" + dob + "\n" + gmail + "\n" + add);
                    sw.Close();
                    
                }
                catch (Exception)
                {
                }this.Close();
                    MessageBox.Show("Password changed successfully");
            }
            else { MessageBox.Show("OTP incorrect"); }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Random rand = new Random();
        int ott;
        private void button1_Click(object sender, EventArgs e)
        {
            ott = rand.Next(10000, 99999);
            MessageBox.Show(ott.ToString());
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("shabith.2k01@gmail.com");
                msg.To.Add(mail2.Text);
                msg.Subject = "otp verification";
                msg.Body = ott.ToString();

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "shabith.2k01@gmail.com";
                ntcd.Password = "betbqvjysrsbrvrf";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("OTP sent to your mail");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }  

        }

        private void mail2_TextChanged(object sender, EventArgs e)
        {

        }

        private void otp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
