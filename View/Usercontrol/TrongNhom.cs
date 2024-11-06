using Repositories.Model;
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
using Services;

namespace View
{
    public partial class TrongNhom : UserControl
    {
        private string groupID = Nhom_CEO.GlobalDataGroupID.GroupID;

        UserGroupService userGroupService = new UserGroupService();

        public TrongNhom()
        {
            InitializeComponent();
        }

        public void updateLabelCheck()
        {
            labelCheck.Text = Nhom_CEO.GlobalLabelCheck.LabelCheck + " > " + groupID;
        }

        private void loadDataUserGroup(string groupID)
        {
            List<UserGroup> userGroupList = userGroupService.getUserGroup(groupID);

            if (userGroupList != null)
            {
                dataGridViewMembers.Rows.Clear();
                foreach (var userGroup in userGroupList)
                {
                    dataGridViewMembers.Rows.Add(
                        userGroup.UserId,
                        userGroup.Role
                    );
                }
            }
        }

        private void TrongNhom_Load(object sender, EventArgs e)
        {
            updateLabelCheck();
            loadDataUserGroup(groupID);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
