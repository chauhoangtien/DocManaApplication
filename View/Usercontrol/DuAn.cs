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
using Repositories.Model;
using Repositories;
using static View.Nhom_CEO;

namespace View.Usercontrol
{
    public partial class DuAn : UserControl
    {
        public event EventHandler SwitchToTaoDuAn;
        public event EventHandler SwitchToHoSo;

        ProjectService projectService = new ProjectService();
        public DuAn()
        {
            InitializeComponent();
        }

        public static class GlobalDataProjectID
        {
            public static string ProjectID;
        }

        private void DuAn_Load(object sender, EventArgs e)
        {
            List<Project> projectList = projectService.getProject();

            if (projectList != null)
            {
                // Xóa hết các hàng cũ nếu có
                dataGridViewDuAn.Rows.Clear();

                // Lặp qua danh sách và thêm từng dòng vào DataGridView
                foreach (var project in projectList)
                {
                    dataGridViewDuAn.Rows.Add(
                        project.ProjectId,
                        project.ProjectName,
                        project.CreatedBy,
                        project.ModifiedDate.HasValue ? project.ModifiedDate.Value.ToString("yyyy-MM-dd") : string.Empty // Định dạng ngày nếu cần
                    );
                }
            }
        }

        private void buttonCreateProject_Click(object sender, EventArgs e)
        {
            SwitchToTaoDuAn?.Invoke(this, EventArgs.Empty);
        }

        private void dataGridViewDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDuAn.Rows[e.RowIndex];
                string projectID = row.Cells[0].Value.ToString();
                GlobalDataProjectID.ProjectID = projectID;

                SwitchToHoSo?.Invoke(this, EventArgs.Empty);
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Tìm kiếm dự án")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;  // Đổi màu chữ về bình thường
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Tìm kiếm dự án";
                textBoxSearch.ForeColor = Color.Gray;  // Đổi màu chữ để thể hiện placeholder
            }
        }
    }
}
