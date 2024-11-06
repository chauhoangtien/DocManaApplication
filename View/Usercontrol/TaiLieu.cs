using Repositories.Model;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static View.Usercontrol.DuAn;

namespace View.Usercontrol
{
    public partial class TaiLieu : UserControl
    {
        public event EventHandler SwitchToTaoTaiLieu;

        private static string LabelCheck = HoSo.GlobalLabelCheck.labelCheck;
        private static string profileID = HoSo.GlobalDataProfileID.ProfileID;

        ProfileDocumentService profileDocumentService = new ProfileDocumentService();
        DocumentService documentService = new DocumentService();

        public TaiLieu()
        {
            InitializeComponent();
        }

        private void updatelabelTenDA(string profileID)
        {
            labelCheck.Text = LabelCheck + " > " + profileID;
        }

        private void buttonCreateDocument_Click(object sender, EventArgs e)
        {
            SwitchToTaoTaiLieu?.Invoke(this, EventArgs.Empty);
        }

        private void TaiLieu_Load(object sender, EventArgs e)
        {
            updatelabelTenDA(profileID);

            List<Document> documentList = profileDocumentService.getProfileDocument(profileID);

            if (documentList != null)
            {
                // Xóa hết các hàng cũ nếu có
                dataGridViewTaiLieu.Rows.Clear();

                // Lặp qua danh sách và thêm từng dòng vào DataGridView
                foreach (var document in documentList)
                {
                    dataGridViewTaiLieu.Rows.Add(
                        document.DocumentId,
                        document.DocumentName,
                        document.SubmittedBy,
                        document.ModifiedDate.HasValue ? document.ModifiedDate.Value.ToString("yyyy-MM-dd") : string.Empty // Định dạng ngày nếu cần
                    );
                }
            }
        }

        private void dataGridViewTaiLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTaiLieu.Rows[e.RowIndex];
                string documentID = row.Cells[0].Value.ToString();

                Document document = documentService.getDocument(documentID);

                try
                {
                    Process.Start(new ProcessStartInfo(document.FilePath) { UseShellExecute = true });
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("Không thể mở file: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dataGridViewTaiLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Tìm kiếm tài liệu")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;  // Đổi màu chữ về bình thường
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Tìm kiếm tài liệu";
                textBoxSearch.ForeColor = Color.Gray;  // Đổi màu chữ để thể hiện placeholder
            }
        }
    }
}
