using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using System.Net;  
using System.Net.Mail;  

namespace Login
{
    public partial class Registration : Form
    {
        reg_and_login ral = new reg_and_login();
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            textBox1.MaxLength = 15;
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        Random rand = new Random();
         int ott;

        private void Register_Click(object sender, EventArgs e)
        {   int ak;
            string l,dob;
            dob = (string)textBox3.Text;
            bool q =ral.DOB(dob);
            if (q == true)
              { ak = ral.get_age(dob); 
                  try
                         { l= (string)textBox6.Text;
                          ak  = Convert.ToInt16(textBox2.Text);
                          }
                   catch (FormatException)
                          {
                              MessageBox.Show("invalid input " + "Registration");
                              this.Close();
                            }
                     l = (string)textBox6.Text;
                     ak = Convert.ToInt16(textBox2.Text);
                      bool al= ral.age(ak);
                      bool mail = ral.mailcheck2(l);
                      if (al == false)
                         {
                              textBox2.Clear();
                              textBox2.Text = String.Empty;
                                MessageBox.Show("age not valid");
                             }
                       else{
                              if (mail == false)
                              {
                                textBox6.Clear();
                                textBox6.Text = String.Empty;
                                 MessageBox.Show("Mail not valid");
                              }
                              else
                             {
                                  
                                   ott = rand.Next(10000, 99999);
                                   MessageBox.Show(ott.ToString());
                                  try  
            {  
  
                MailMessage msg = new MailMessage();  
                msg.From = new MailAddress("shabith.2k01@gmail.com");  
                msg.To.Add(textBox6.Text);  
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
  
                MessageBox.Show("OTP sent successfully");  
  
            }  
            catch (Exception ex)  
            {  
  
                MessageBox.Show(ex.Message);  
            } 
                             }
                           }
               
                }else
                {MessageBox.Show("Enter proper DOB");textBox3.Text = String.Empty;
                }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length < 3) { label8.Text = " very weak"; }
            else if (((TextBox)sender).Text.Length < 6) { label8.Text = "weak"; }
            else if  (((TextBox)sender).Text.Length > 6) { label8.Text = "strong"; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( ott.ToString() .Equals(textBox8.Text))
            {
             try
                {
                var sw = new System.IO.StreamWriter("D:\\project" + textBox4.Text + "\\log.DI");
                sw.Write(textBox4.Text + "\n" + textBox5.Text + "\n" + textBox1.Text + "\n" + textBox2.Text + "\n" + textBox3.Text + "\n" + textBox6.Text + "\n" + textBox7.Text);
                sw.Close();
                
                 }
                  catch (System.IO.DirectoryNotFoundException)
                  {
                       System.IO.Directory.CreateDirectory("D:\\project" + textBox4.Text);
                         var sw = new System.IO.StreamWriter("D:\\project" + textBox4.Text + "\\log.DI");
                         sw.Write(textBox4.Text + "\n" + textBox5.Text + "\n" + textBox1.Text + "\n" + textBox2.Text + "\n" + textBox3.Text + "\n" + textBox6.Text + "\n" + textBox7.Text);
                         sw.Close();

            }
                MessageBox.Show("successfully registered");
                this.Close();
            }
            
            else
            {MessageBox.Show("OTP incorrect");}

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
