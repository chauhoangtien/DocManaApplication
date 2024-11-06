using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Repositories.Model;

namespace View.Usercontrol
{
    public partial class PhongBan : UserControl
    {
        public event EventHandler SwitchToTaoPhongBan;
        public event EventHandler SwitchToNhom_CEO;

        DepartmentService departmentService = new DepartmentService();
        UserService userService = new UserService();

        public static class GlobalDataDepartmentID
        {
            public static string DepartmentID;
        }

        public PhongBan()
        {
            InitializeComponent();
        }

        private void btnTaoPhongBan_Click(object sender, EventArgs e)
        {
            string userID = Login.GlobalDataUserID.UserID;
            string role = userService.checkRole(userID);

            if (role.Equals("Giám đốc"))
            {
                SwitchToTaoPhongBan?.Invoke(this, EventArgs.Empty);
            }
            else if (role.Equals("Quản lý"))
            {
                MessageBox.Show("Bạn không có quyền tạo phòng ban");
            }
        }

        private void loadDepartmentDataCEO()
        {
            List<Department> departmentList = departmentService.getListDepartmentCEO();

            if (departmentList != null)
            {
                // Xóa hết các hàng cũ nếu có
                dataGridViewPhongBan.Rows.Clear();

                // Lặp qua danh sách và thêm từng dòng vào DataGridView
                foreach (var department in departmentList)
                {
                    dataGridViewPhongBan.Rows.Add(
                        department.DepartmentId,
                        department.DepartmentName,
                        department.ManagerId,
                        department.ModifiedDate.HasValue ? department.CreateDate.Value.ToString("yyyy-MM-dd") : string.Empty // Định dạng ngày nếu cần
                    );
                }
            }
        }

        private void loadDepartmentDataManager(string managerID)
        {
            List<Department> departmentList = departmentService.getListDepartmentManager(managerID);

            if (departmentList != null)
            {
                // Xóa hết các hàng cũ nếu có
                dataGridViewPhongBan.Rows.Clear();

                // Lặp qua danh sách và thêm từng dòng vào DataGridView
                foreach (var department in departmentList)
                {
                    dataGridViewPhongBan.Rows.Add(
                        department.DepartmentId,
                        department.DepartmentName,
                        department.ManagerId,
                        department.ModifiedDate.HasValue ? department.CreateDate.Value.ToString("yyyy-MM-dd") : string.Empty // Định dạng ngày nếu cần
                    );
                }
            }
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            string userID = Login.GlobalDataUserID.UserID;
            string role = userService.checkRole(userID);

            if(role.Equals("Giám đốc"))
            {
                loadDepartmentDataCEO();
            }
            else if(role.Equals("Quản lý"))
            {
                loadDepartmentDataManager(userID);  
            }  
        }

        private void dataGridViewPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPhongBan.Rows[e.RowIndex];
                string departmentID = row.Cells[0].Value.ToString();
                GlobalDataDepartmentID.DepartmentID = departmentID;

                SwitchToNhom_CEO?.Invoke(this, EventArgs.Empty);
            }
        }

        private void dataGridViewPhongBan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Chọn hàng tương ứng khi nhấp chuột phải
                dataGridViewPhongBan.ClearSelection();
                dataGridViewPhongBan.Rows[e.RowIndex].Selected = true;

                // Hiển thị menu ngữ cảnh tại vị trí nhấp chuột
                contextMenuStrip.Show(Cursor.Position);
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Tìm kiếm phòng ban")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;  // Đổi màu chữ về bình thường
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Tìm kiếm phòng ban";
                textBoxSearch.ForeColor = Color.Gray;  // Đổi màu chữ để thể hiện placeholder
            }
        }
    }
}
