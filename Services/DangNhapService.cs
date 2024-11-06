using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    public class DangNhapService
    {

        DangNhapRepository dangNhapRepository = new DangNhapRepository();

        public bool checkLogin(string userID, string password)
        {
            return dangNhapRepository.checkLogin(userID, password);
        }
        
        public string sendEmail(string userID)
        {
            MailService mailService = new MailService();

            string receiverEmail = dangNhapRepository.getEmail(userID);

            string subject = "Lấy lại mật khẩu tài khoản DocMana của bạn";
            string body = "Chúng tôi nhận được yêu cầu đặt lại mật khẩu của bạn. Mật khẩu tạm thời của bạn là:...... \n" 
                + "Vui lòng đăng nhập vào hệ thống bằng mật khẩu tạm thời này và đổi mật khẩu ngay sau khi đăng nhập thành công.\n" + "Trân trọng.";

            if (receiverEmail != "Connection Failed" && receiverEmail != "Email could not be found")
            {
                mailService.sendEmail(subject, body, receiverEmail);
                return "A temporary password has been sent to your email account.";
            }
            else
            {
                return "Email could not be found";
            }
        }
    }
}
