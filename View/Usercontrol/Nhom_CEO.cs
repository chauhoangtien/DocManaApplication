using Repositories.Model;
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
using View.Usercontrol;
using static View.Usercontrol.PhongBan;

namespace View
{
    public partial class Nhom_CEO : UserControl
    {
        public event EventHandler SwitchToTaoNhom;
        public event EventHandler SwitchToThemThanhVienVaoPhongBan;
        public event EventHandler SwitchToTrongNhom;

        GroupService groupService = new GroupService();
        UserDepartmentService userDepartmentService = new UserDepartmentService();

        private string departmentID = PhongBan.GlobalDataDepartmentID.DepartmentID;

        public Nhom_CEO()
        {
            InitializeComponent();
        }

        public static class GlobalDataGroupID
        {
            public static string GroupID;
        }

        public static class GlobalLabelCheck
        {
            public static string LabelCheck;
        }
        private void loadDataGroup(string departmentID)
        {
            List<UserDepartment> userDepartmentList = userDepartmentService.getUserDepartment(departmentID);

            if (userDepartmentList != null)
            {
                dataGridViewThanhVien.Rows.Clear();
                foreach (var userDepartment in userDepartmentList)
                {
                    dataGridViewThanhVien.Rows.Add(
                        userDepartment.UserId,
                        userDepartment.Role
                    );
                }
            }
        }

        private void loadDataUserDepartment(string departmentID)
        {
            List<Group> groupList = groupService.getDataGroup(departmentID);

            if (groupList != null)
            {
                dataGridViewNhom.Rows.Clear();
                foreach (var group in groupList)
                {
                    dataGridViewNhom.Rows.Add(
                        group.GroupId,
                        group.GroupName,
                        group.LeaderId,
                        group.ModifiedDate.HasValue ? group.CreateDate.Value.ToString("yyyy-MM-dd") : string.Empty // Định dạng ngày nếu cần
                    );
                }
            }
        }

        private void Nhom_CEO_Load(object sender, EventArgs e)
        {
            updateLabelCheck();
            loadDataGroup(departmentID);
            loadDataUserDepartment(departmentID);
        }

        public void updateLabelCheck()
        {
            labelCheck.Text = labelCheck.Text + " " + departmentID;
            GlobalLabelCheck.LabelCheck = labelCheck.Text;
        }

        private void btnTaonhom_Click(object sender, EventArgs e)
        {
            SwitchToTaoNhom?.Invoke(this, EventArgs.Empty);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SwitchToThemThanhVienVaoPhongBan?.Invoke(this, EventArgs.Empty);
        }

        private void dataGridViewNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewNhom.Rows[e.RowIndex];
                string groupID = row.Cells[0].Value.ToString();
                GlobalDataGroupID.GroupID = groupID;

                SwitchToTrongNhom?.Invoke(this, EventArgs.Empty);
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Tìm kiếm nhóm")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;  // Đổi màu chữ về bình thường
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Tìm kiếm nhóm";
                textBoxSearch.ForeColor = Color.Gray;  // Đổi màu chữ để thể hiện placeholder
            }
        }
    }
}
