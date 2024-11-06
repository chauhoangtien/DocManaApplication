using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Model;
using Services;
using User = Repositories.Model.User;

namespace View
{
    public partial class QuanLyNhanVien_CEO : UserControl
    {
        public event EventHandler SwitchToTaoNhanVien;

        UserService userService = new UserService();

        public QuanLyNhanVien_CEO()
        {
            InitializeComponent();
        }

        private void loadUserDataCEO()
        {
            List<User> userList = userService.getDataUser_CEO();

            if (userList != null)
            {
                // Xóa hết các hàng cũ nếu có
                dataGridViewNhanVien.Rows.Clear();

                // Lặp qua danh sách và thêm từng dòng vào DataGridView
                foreach (var user in userList)
                {
                    dataGridViewNhanVien.Rows.Add(
                        user.FullName,
                        user.UserId,
                        user.Address,
                        user.Gender,
                        user.Email,
                        user.Role,
                        user.Status
                    );
                }
            }

            int countUserActive = userService.countUserActive_CEO();
            int countUserDeActive = userService.countUserDeActive_CEO();

            labelActive.Text = countUserActive.ToString() + " hoạt động";
            labelDeactive.Text = countUserDeActive.ToString() + " không hoạt động";
        }

        private void QuanLyNhanVien_CEO_Load(object sender, EventArgs e)
        {
            loadUserDataCEO();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            SwitchToTaoNhanVien?.Invoke(this, EventArgs.Empty);
        }

        private void buttonBlockUser_Click(object sender, EventArgs e)
        {
            if(dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewNhanVien.SelectedRows[0].Index;
                string userID = dataGridViewNhanVien.Rows[selectedRowIndex].Cells[1].Value.ToString();

                bool result = userService.blockUser(userID);

                if (result)
                {
                    MessageBox.Show("Khóa tài khoản thành công");
                    loadUserDataCEO();
                }
                else
                {
                    MessageBox.Show("Khóa tài khoản không thành công");
                }
            }
        }
    }
}
