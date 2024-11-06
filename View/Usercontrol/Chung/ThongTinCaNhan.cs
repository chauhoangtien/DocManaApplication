using Services;
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
using Repositories.Model;

namespace View.Usercontrol
{
    public partial class ThongTinCaNhan : UserControl
    {
        private string UserID;
        UserService userService = new UserService();

        public ThongTinCaNhan()
        {
            InitializeComponent();
        }
        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            UserID = Login.GlobalDataUserID.UserID;
            User user = userService.getUser(UserID);

            if (user != null)
            {
                textBoxUserID.Text = user.UserId;
                textBoxGender.Text = user.Gender;
                textBoxRole.Text = user.Role;
                textBoxName.Text = user.FullName;
                textBoxDepartment.Text = "";
                textBoxEmail.Text = user.Email;
                textBoxAddress.Text = user.Address;
                textBoxStatus.Text = user.Status;

                pictureBoxAvatar.Image = convertByteToImage(user.Avatar);

                textBoxRole.Enabled = false;
                textBoxUserID.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxDepartment.Enabled = false;
                textBoxStatus.Enabled = false;
                textBoxLoginName.Enabled = false;


                textBoxLoginName.Text = user.UserId;
            }
        }

        private Image convertByteToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private byte[] convertImageToByte(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void buttonSaveInforBase_Click(object sender, EventArgs e)
        {
            UserID = Login.GlobalDataUserID.UserID;
            User user = userService.getUser(UserID);

            byte[] avatarBytes = convertImageToByte(pictureBoxAvatar.Image);

            if (user != null)
            {
                string result = userService.updateUser(textBoxUserID.Text, user.Password, textBoxName.Text, textBoxAddress.Text, textBoxGender.Text, avatarBytes, textBoxRole.Text, textBoxStatus.Text);
                if (result.Equals("Cập nhật tài khoản thành công"))
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private void BtnAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh trong PictureBox
                    pictureBoxAvatar.Image = Image.FromFile(ofd.FileName);
                }
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserID = Login.GlobalDataUserID.UserID;
            User user = userService.getUser(UserID);

            byte[] avatarBytes = convertImageToByte(pictureBoxAvatar.Image);

            if (user != null)
            {
                string result = userService.updateUser(textBoxUserID.Text, hashPassword(textBoxPassword.Text), textBoxName.Text, textBoxAddress.Text, textBoxGender.Text, avatarBytes, textBoxRole.Text, textBoxStatus.Text);
                if (result.Equals("Cập nhật tài khoản thành công"))
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }
    }
}
