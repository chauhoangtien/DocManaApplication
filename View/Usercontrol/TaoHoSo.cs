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
    public partial class TaoHoSo : UserControl
    {
        ProfileService profileService = new ProfileService();

        private static string projectID = DuAn.GlobalDataProjectID.ProjectID;


        public TaoHoSo()
        {
            InitializeComponent();
        }

        private void buttonCreateProfile_Click(object sender, EventArgs e)
        {
            if(textboxProfileName.Text == "" && textboxDiscription.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
            }
            else
            {
                string result = profileService.createProfile(textboxProfileName.Text, projectID, textboxDiscription.Text);

                if(result.Equals("Tạo hồ sơ thành công"))
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Tạo hồ sơ không thành công");
                }
            }
        }
    }
}
