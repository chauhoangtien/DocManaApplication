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
using User = Repositories.Model.User;
using Services;

namespace View.Usercontrol
{
    public partial class TaoNhom : UserControl
    {
        UserService userService = new UserService();
        GroupService groupService = new GroupService();
        private string departmentID = PhongBan.GlobalDataDepartmentID.DepartmentID;

        public TaoNhom()
        {
            InitializeComponent();
        }

        private void TaoNhom_Load(object sender, EventArgs e)
        {
            List<User> userList = userService.getUserID();

            if (userList == null)
            {
                MessageBox.Show("User list is null");
            }
            else if (userList.Count == 0)
            {
                MessageBox.Show("User list is empty");
            }
            else
            {
                foreach (User user in userList)
                {
                    comboboxLeaderID.Items.Add(user.UserId);
                }
            }
        }

        private void buttonCreateGroup_Click(object sender, EventArgs e)
        {
            if(textboxGroupName.Text == "" && comboboxLeaderID.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                string result = groupService.createGroup(textboxGroupName.Text, departmentID, comboboxLeaderID.Text);
                if (result.Equals("Tạo nhóm cho phòng ban thành công"))
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Tạo nhóm cho phòng ban không thành công");
                }
            }
        }
    }
}
