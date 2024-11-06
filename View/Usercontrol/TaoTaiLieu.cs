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

namespace View.Usercontrol
{
    public partial class TaoTailieu : UserControl
    {
        DocumentService documentService = new DocumentService();

        private static string projectID = DuAn.GlobalDataProjectID.ProjectID;

        private static string submittedBy = Login.GlobalDataUserID.UserID;

        private static string filePath;

        public TaoTailieu()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                string fileName = Path.GetFileNameWithoutExtension(filePath);

                textboxDocumentName.Text = fileName;
                textBoxFilePath.Text = filePath;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ngăn không cho nhập nếu không hợp lệ
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(textboxDocumentName.Text == "" && textboxVersion.Text == "" && textboxStatus.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                DateOnly date = new DateOnly();
                if (textboxDate.Text == "")
                {
                    date = DateOnly.FromDateTime(DateTime.Now);
                }
                else
                {
                    date = DateOnly.Parse(textboxDate.Text);
                }

                string result = documentService.createDocument(date, projectID, textboxDocumentName.Text, textboxVersion.Text, textboxStatus.Text, submittedBy, filePath);
                if(result.Equals("Thêm tài liệu thành công"))
                {
                    MessageBox.Show("Tạo tài liệu thành công");
                }
                else
                {
                    MessageBox.Show("Tạo tài liệu không thành công");
                }
            }
        }
    }
}
