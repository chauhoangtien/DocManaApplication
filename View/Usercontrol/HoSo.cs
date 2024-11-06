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
using Services;
using static View.Usercontrol.DuAn;

namespace View.Usercontrol
{
    public partial class HoSo : UserControl
    {
        public event EventHandler SwitchToTaoHoSo;
        public event EventHandler SwitchToTaiLieu;

        ProfileService profileService = new ProfileService();

        private static string projectID = DuAn.GlobalDataProjectID.ProjectID;

        public HoSo()
        {
            InitializeComponent();
        }

        public static class GlobalDataProfileID
        {
            public static string ProfileID;
        }

        public static class GlobalLabelCheck
        {
            public static string labelCheck;
        }

        private void updatelabelTenDA(string projectID)
        {
            lblTenDuAn.Text = lblTenDuAn.Text + " " + projectID;
            GlobalLabelCheck.labelCheck = lblTenDuAn.Text;
        }

        private void HoSo_Load(object sender, EventArgs e)
        {
            updatelabelTenDA(projectID);

            List<Profile> profileList = profileService.getProfile(projectID);

            if (profileList != null)
            {
                // Xóa hết các hàng cũ nếu có
                dataGridViewHoSo.Rows.Clear();

                // Lặp qua danh sách và thêm từng dòng vào DataGridView
                foreach (var profile in profileList)
                {
                    dataGridViewHoSo.Rows.Add(
                        profile.ProfileId,
                        profile.ProfileName,
                        profile.StartDate.HasValue ? profile.StartDate.Value.ToString("yyyy-MM-dd") : string.Empty,
                        profile.ModifiedDate.HasValue ? profile.ModifiedDate.Value.ToString("yyyy-MM-dd") : string.Empty // Định dạng ngày nếu cần
                    );
                }
            }
        }

        private void buttonCreateProfile_Click(object sender, EventArgs e)
        {
            SwitchToTaoHoSo?.Invoke(this, EventArgs.Empty);
        }

        private void dataGridViewHoSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHoSo.Rows[e.RowIndex];
                string profileID = row.Cells[0].Value.ToString();
                GlobalDataProfileID.ProfileID = profileID;

                SwitchToTaiLieu?.Invoke(this, EventArgs.Empty);
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Tìm kiếm hồ sơ")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;  // Đổi màu chữ về bình thường
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Tìm kiếm hồ sơ";
                textBoxSearch.ForeColor = Color.Gray;  // Đổi màu chữ để thể hiện placeholder
            }
        }
    }
}
