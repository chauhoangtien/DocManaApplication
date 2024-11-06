using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Model;
using User = Repositories.Model.User;
using Services;

namespace View.Usercontrol
{
    public partial class ThemNhanVienVaoPhongBan : UserControl
    {
        UserService userService = new UserService();
        UserDepartmentService userDepartmentService = new UserDepartmentService();
        private string departmentID = PhongBan.GlobalDataDepartmentID.DepartmentID;

        public ThemNhanVienVaoPhongBan()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlChinh = new Guna.UI2.WinForms.Guna2Panel();
            pnlTaoPhongBan = new Guna.UI2.WinForms.Guna2Panel();
            comboboxUserID = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            textboxRole = new Guna.UI2.WinForms.Guna2TextBox();
            pnlChinh.SuspendLayout();
            pnlTaoPhongBan.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChinh
            // 
            pnlChinh.Controls.Add(pnlTaoPhongBan);
            pnlChinh.CustomizableEdges = customizableEdges9;
            pnlChinh.Dock = DockStyle.Fill;
            pnlChinh.Location = new Point(0, 0);
            pnlChinh.Margin = new Padding(3, 2, 3, 2);
            pnlChinh.Name = "pnlChinh";
            pnlChinh.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlChinh.Size = new Size(926, 595);
            pnlChinh.TabIndex = 1;
            // 
            // pnlTaoPhongBan
            // 
            pnlTaoPhongBan.BackColor = Color.White;
            pnlTaoPhongBan.Controls.Add(comboboxUserID);
            pnlTaoPhongBan.Controls.Add(guna2Button1);
            pnlTaoPhongBan.Controls.Add(label4);
            pnlTaoPhongBan.Controls.Add(label2);
            pnlTaoPhongBan.Controls.Add(label1);
            pnlTaoPhongBan.Controls.Add(textboxRole);
            pnlTaoPhongBan.CustomizableEdges = customizableEdges7;
            pnlTaoPhongBan.Location = new Point(206, 130);
            pnlTaoPhongBan.Margin = new Padding(3, 2, 3, 2);
            pnlTaoPhongBan.Name = "pnlTaoPhongBan";
            pnlTaoPhongBan.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlTaoPhongBan.Size = new Size(519, 272);
            pnlTaoPhongBan.TabIndex = 0;
            // 
            // comboboxUserID
            // 
            comboboxUserID.BackColor = Color.Transparent;
            comboboxUserID.CustomizableEdges = customizableEdges1;
            comboboxUserID.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxUserID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxUserID.FocusedColor = Color.FromArgb(94, 148, 255);
            comboboxUserID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboboxUserID.Font = new Font("Segoe UI", 10F);
            comboboxUserID.ForeColor = Color.FromArgb(68, 88, 112);
            comboboxUserID.ItemHeight = 30;
            comboboxUserID.Location = new Point(187, 72);
            comboboxUserID.Name = "comboboxUserID";
            comboboxUserID.ShadowDecoration.CustomizableEdges = customizableEdges2;
            comboboxUserID.Size = new Size(193, 36);
            comboboxUserID.TabIndex = 8;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(128, 128, 255);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(425, 235);
            guna2Button1.Margin = new Padding(3, 2, 3, 2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(80, 28);
            guna2Button1.TabIndex = 7;
            guna2Button1.Text = "Thêm";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(279, 25);
            label4.TabIndex = 6;
            label4.Text = "Thêm nhân viên vào phòng ban";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(69, 161);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Vai trò:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(69, 72);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã nhân viên:";
            // 
            // textboxRole
            // 
            textboxRole.CustomizableEdges = customizableEdges5;
            textboxRole.DefaultText = "";
            textboxRole.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textboxRole.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textboxRole.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textboxRole.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textboxRole.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textboxRole.Font = new Font("Segoe UI", 9F);
            textboxRole.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textboxRole.Location = new Point(187, 157);
            textboxRole.Name = "textboxRole";
            textboxRole.PasswordChar = '\0';
            textboxRole.PlaceholderText = "";
            textboxRole.SelectedText = "";
            textboxRole.ShadowDecoration.CustomizableEdges = customizableEdges6;
            textboxRole.Size = new Size(193, 24);
            textboxRole.TabIndex = 0;
            // 
            // ThemNhanVienVaoPhongBan
            // 
            Controls.Add(pnlChinh);
            Name = "ThemNhanVienVaoPhongBan";
            Size = new Size(926, 595);
            Load += ThemNhanVienVaoPhongBan_Load;
            pnlChinh.ResumeLayout(false);
            pnlTaoPhongBan.ResumeLayout(false);
            pnlTaoPhongBan.PerformLayout();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel pnlChinh;
        private Guna.UI2.WinForms.Guna2Panel pnlTaoPhongBan;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxUserID;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textboxRole;

        private void ThemNhanVienVaoPhongBan_Load(object sender, EventArgs e)
        {
            List<User> userList = userService.getUserID();

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
                    comboboxUserID.Items.Add(user.UserId);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(comboboxUserID.Text == "" && textboxRole.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                string result = userDepartmentService.createUserDepartment(comboboxUserID.Text, departmentID, textboxRole.Text);
                if (result.Equals("Thêm User vào phòng ban thành công"))
                {
                    MessageBox.Show("Thêm nhân viên vào phòng ban thành công");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên vào phòng ban không thành công");
                }
            }
        }
    }
}
