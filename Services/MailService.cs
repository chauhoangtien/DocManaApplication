using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Services
{
    public class MailService
    {
        public void sendEmail(string subject, string body, string email)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string senderEmail = "your-email@example.com"; // Email gửi
            string senderPassword = "your-email-password"; // Mật khẩu email
            string receiverEmail = email; // Email nhận

            // Tạo một đối tượng MailMessage
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail);
            mail.To.Add(receiverEmail);
            mail.Subject = subject; // Tiêu đề email
            mail.Body = body; // Nội dung email
            mail.IsBodyHtml = false; // Nếu bạn muốn gửi email HTML, đặt thành true

            // Tạo một đối tượng SmtpClient
            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true; // Bật SSL nếu cần thiết

            try
            {
                // Gửi email
                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }
    }
}
