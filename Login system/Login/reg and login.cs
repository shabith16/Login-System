using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace Login
{
    class reg_and_login
    {
        public  bool  age(int a)
        {
            bool ag = false;
            if (a > 60 || a < 18)
            {
              System.Windows.Forms.MessageBox.Show("INVALID AGE");
                ag = false;
            }
            else {ag = true;}
            return ag;
        }
        public bool DOB(string a)
        {
            bool q = false;
            DateTime dDate;
        if (DateTime.TryParse(a, out dDate))
        {
            q = true;
            string.Format("{0:d/MM/YYYY}", dDate);
        }
        else { System.Windows.Forms.MessageBox.Show("Invalid Date"); }
        return q;
        }
 
        public  bool password(string a)
        {    bool b = false;
          int d=0;
            foreach ( char c in a)
            { 
             if ((int)c>=33 && (int)c <= 64)
             {
                //b= true;
                 d += 1;
             }
             }
            if (d >= 3)
            { b = true; }
            return b;
           }

        public string mailcheck(string email)
        {
            string l;
         Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-
         9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
         RegexOptions.CultureInvariant | RegexOptions.Singleline);
            // Console.WriteLine($"The email is {email}");
         bool isValidEmail = regex.IsMatch(email);
         if (!isValidEmail){
            //Console.WriteLine($"The email is invalid"); 
             l = "invalid";
         } else { l = "positive";
           // Console.WriteLine($"The email is valid");
         }
         return l;
       
        }
        public bool mailcheck2(string mail)
        {
            bool a = false; 
            if (mail.Contains("@gmail.com") == true)
            {
                a = true;
            }
            else
            {
                a = false;
                System.Windows.Forms.MessageBox.Show("Enter A Valid Mail"); 
            }
            return a;

        }
        public int get_age(string dob)
        {
            DateTime w = Convert.ToDateTime(dob);
            int age = 0;
            age = DateTime.Now.Subtract(w).Days;
            age = age / 365;
            return age;
        }

        public int Otp()
        {
            Random num = new Random();
            int number = num.Next(100000, 99999);
            return number;
        }
        public  void Email(string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("FromMailAddress");
                message.To.Add(new MailAddress("ToMailAddress"));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("FromMailAddress", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("otp gen failed",ex.Message); }
        }  

    }
}
