using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Services;
using Repositories.Model;

namespace View.Usercontrol
{
    public partial class TaoNhanVien : UserControl
    {
        UserService userService = new UserService();
        public TaoNhanVien()
        {
            InitializeComponent();
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

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            if(textboxFullname.Text == "" && textBoxPassword.Text == "" && textboxGender.Text == "" && textboxEmail.Text == "" && textboxRole.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                string result = userService.createUser(hashPassword(textBoxPassword.Text), textboxFullname.Text, textboxGender.Text, textboxEmail.Text, textboxRole.Text); 
                if(result.Equals("Thêm tài khoản thành công"))
                {
                    MessageBox.Show("Tạo tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại");
                }
            }
        }
    }
}
