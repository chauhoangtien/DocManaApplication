using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View
{
    public partial class Login : Form
    {
        DangNhapService service = new DangNhapService();
        UserService userService = new UserService();

        public Login()
        {
            InitializeComponent();
        }

        public static class GlobalDataUserID
        {
            public static string UserID;
        }

        public static string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Chuyển mật khẩu thành byte array
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                // Hash mật khẩu
                byte[] hash = sha256.ComputeHash(bytes);

                // Chuyển byte array thành chuỗi hex
                StringBuilder result = new StringBuilder();
                foreach (byte b in hash)
                {
                    result.Append(b.ToString("x2"));
                }
                return result.ToString();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool result = service.checkLogin(textboxUserID.Text, hashPassword(textboxPassword.Text));

            if (result)
            {
                string role = userService.checkRole(textboxUserID.Text);
                if(role.Equals("Giám đốc"))
                {
                    GlobalDataUserID.UserID = textboxUserID.Text;
                    CEO_Main ceo_main = new CEO_Main();
                    ceo_main.Show();
                    this.Hide();
                }
                if(role.Equals("Quản lý"))
                {
                    GlobalDataUserID.UserID = textboxUserID.Text;
                    QuanLy_Main quanLy_Main = new QuanLy_Main();
                    quanLy_Main.Show();
                    this.Hide();
                }
                if(role.Equals("Nhân viên"))
                {
                    GlobalDataUserID.UserID = textboxUserID.Text;
                    NhanVien_Main nhanVien_Main = new NhanVien_Main();
                    nhanVien_Main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}
