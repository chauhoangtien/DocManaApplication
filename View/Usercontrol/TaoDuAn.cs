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
    public partial class TaoDuAn : UserControl
    {
        ProjectService projectService = new ProjectService();

        string createdBy = Login.GlobalDataUserID.UserID;
        public TaoDuAn()
        {
            InitializeComponent();
        }

        private void buttonCreateProject_Click(object sender, EventArgs e)
        {
            if(textboxProjectName.Text == "" && textboxStatus.Text == "" && textboxDiscription.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ");
            }
            else
            {
                string result = projectService.createProject(textboxProjectName.Text, textboxDiscription.Text, textboxStatus.Text, createdBy);
                if(result.Equals("Tạo dự án thành công"))
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Tạo dự án không thành công");
                }
            }
        }
    }
}
