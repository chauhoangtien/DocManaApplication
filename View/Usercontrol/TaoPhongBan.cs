using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Repositories.Model;
using User = Repositories.Model.User;
using Services;

namespace View
{
    public partial class TaoPhongBan : UserControl
    {
        UserService userService = new UserService();
        DepartmentService departmentService = new DepartmentService();
        UserDepartmentService userDepartmentService = new UserDepartmentService();

        public TaoPhongBan()
        {
            InitializeComponent();
        }

        private void TaoPhongBan_Load(object sender, EventArgs e)
        {
            List<User> userList = userService.getManagerID();

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
                    comboboxManagerID.Items.Add(user.UserId);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(textboxDepartmentName.Text != null && comboboxManagerID.Text != null)
            {
                string resultCreateDepartment = departmentService.create(textboxDepartmentName.Text, comboboxManagerID.Text, textboxDiscription.Text);
                if (resultCreateDepartment.Equals("Tạo phòng ban thành công"))
                {
                    MessageBox.Show(resultCreateDepartment);
                }
                else
                {
                    MessageBox.Show("Tạo phòng ban không thành công");
                }
            }
        }
    }
}
