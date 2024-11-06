namespace View
{
    partial class QuanLyNhanVien_CEO
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlChinh = new Panel();
            label4 = new Label();
            dataGridViewNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            Ten = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            VaiTro = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            buttonBlockUser = new Guna.UI2.WinForms.Guna2Button();
            buttonCreateUser = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            panel1 = new Panel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            labelDeactive = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            labelActive = new Label();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            pnlChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlChinh
            // 
            pnlChinh.Controls.Add(label4);
            pnlChinh.Controls.Add(dataGridViewNhanVien);
            pnlChinh.Controls.Add(panel6);
            pnlChinh.Controls.Add(label1);
            pnlChinh.Controls.Add(panel1);
            pnlChinh.Dock = DockStyle.Fill;
            pnlChinh.Location = new Point(0, 0);
            pnlChinh.Margin = new Padding(3, 2, 3, 2);
            pnlChinh.Name = "pnlChinh";
            pnlChinh.Size = new Size(926, 595);
            pnlChinh.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(26, 212);
            label4.Name = "label4";
            label4.Size = new Size(186, 21);
            label4.TabIndex = 9;
            label4.Text = "Liệt kê tất cả nhân viên";
            // 
            // dataGridViewNhanVien
            // 
            dataGridViewNhanVien.AllowUserToAddRows = false;
            dataGridViewNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewNhanVien.ColumnHeadersHeight = 35;
            dataGridViewNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewNhanVien.Columns.AddRange(new DataGridViewColumn[] { Ten, User, DiaChi, GioiTinh, Email, VaiTro, TrangThai });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewNhanVien.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewNhanVien.Location = new Point(27, 243);
            dataGridViewNhanVien.Margin = new Padding(2);
            dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            dataGridViewNhanVien.ReadOnly = true;
            dataGridViewNhanVien.RowHeadersVisible = false;
            dataGridViewNhanVien.RowHeadersWidth = 51;
            dataGridViewNhanVien.RowTemplate.Height = 24;
            dataGridViewNhanVien.Size = new Size(872, 322);
            dataGridViewNhanVien.TabIndex = 8;
            dataGridViewNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewNhanVien.ThemeStyle.BackColor = Color.White;
            dataGridViewNhanVien.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewNhanVien.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewNhanVien.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewNhanVien.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewNhanVien.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewNhanVien.ThemeStyle.HeaderStyle.Height = 35;
            dataGridViewNhanVien.ThemeStyle.ReadOnly = true;
            dataGridViewNhanVien.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewNhanVien.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewNhanVien.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewNhanVien.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewNhanVien.ThemeStyle.RowsStyle.Height = 24;
            dataGridViewNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Ten
            // 
            Ten.HeaderText = "Tên ";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            Ten.ReadOnly = true;
            // 
            // User
            // 
            User.HeaderText = "UserId";
            User.MinimumWidth = 6;
            User.Name = "User";
            User.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // VaiTro
            // 
            VaiTro.HeaderText = "Vai trò";
            VaiTro.MinimumWidth = 6;
            VaiTro.Name = "VaiTro";
            VaiTro.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(buttonBlockUser);
            panel6.Controls.Add(buttonCreateUser);
            panel6.Location = new Point(27, 164);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(872, 46);
            panel6.TabIndex = 2;
            // 
            // buttonBlockUser
            // 
            buttonBlockUser.BorderColor = Color.White;
            buttonBlockUser.CustomizableEdges = customizableEdges1;
            buttonBlockUser.DisabledState.BorderColor = Color.DarkGray;
            buttonBlockUser.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonBlockUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonBlockUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonBlockUser.FillColor = Color.White;
            buttonBlockUser.Font = new Font("Segoe UI", 9.75F);
            buttonBlockUser.ForeColor = Color.Black;
            buttonBlockUser.Image = Properties.Resources.remove;
            buttonBlockUser.ImageAlign = HorizontalAlignment.Left;
            buttonBlockUser.Location = new Point(194, 8);
            buttonBlockUser.Margin = new Padding(4, 3, 4, 3);
            buttonBlockUser.Name = "buttonBlockUser";
            buttonBlockUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            buttonBlockUser.Size = new Size(188, 29);
            buttonBlockUser.TabIndex = 7;
            buttonBlockUser.Text = "Khóa nhân viên";
            buttonBlockUser.TextOffset = new Point(5, 0);
            buttonBlockUser.Click += buttonBlockUser_Click;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.BorderColor = Color.White;
            buttonCreateUser.CustomizableEdges = customizableEdges3;
            buttonCreateUser.DisabledState.BorderColor = Color.DarkGray;
            buttonCreateUser.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonCreateUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonCreateUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonCreateUser.FillColor = Color.White;
            buttonCreateUser.Font = new Font("Segoe UI", 9.75F);
            buttonCreateUser.ForeColor = Color.Black;
            buttonCreateUser.Image = Properties.Resources.icons8_plus_30;
            buttonCreateUser.ImageAlign = HorizontalAlignment.Left;
            buttonCreateUser.Location = new Point(0, 8);
            buttonCreateUser.Margin = new Padding(4, 3, 4, 3);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.ShadowDecoration.CustomizableEdges = customizableEdges4;
            buttonCreateUser.Size = new Size(167, 29);
            buttonCreateUser.TabIndex = 3;
            buttonCreateUser.Text = "Tạo nhân viên";
            buttonCreateUser.TextOffset = new Point(8, 0);
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(26, 17);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhân viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2TextBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(26, 58);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 94);
            panel1.TabIndex = 0;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.Cursor = Cursors.IBeam;
            guna2TextBox1.CustomizableEdges = customizableEdges5;
            guna2TextBox1.DefaultText = "Tìm kiếm nhân viên\r\n";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconRight = Properties.Resources.icons8_search_40;
            guna2TextBox1.Location = new Point(539, 44);
            guna2TextBox1.Margin = new Padding(4, 5, 4, 5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2TextBox1.Size = new Size(315, 32);
            guna2TextBox1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(labelDeactive);
            panel3.Location = new Point(234, 14);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 63);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Image = Properties.Resources.profile__1_;
            pictureBox2.Location = new Point(12, 13);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // labelDeactive
            // 
            labelDeactive.AutoSize = true;
            labelDeactive.Location = new Point(58, 25);
            labelDeactive.Name = "labelDeactive";
            labelDeactive.Size = new Size(0, 15);
            labelDeactive.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(labelActive);
            panel2.Location = new Point(1, 14);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(172, 63);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 0);
            pictureBox1.Image = Properties.Resources.profile__1_;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelActive
            // 
            labelActive.AutoSize = true;
            labelActive.Location = new Point(58, 25);
            labelActive.Name = "labelActive";
            labelActive.Size = new Size(0, 15);
            labelActive.TabIndex = 0;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // QuanLyNhanVien_CEO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlChinh);
            Location = new Point(246, 124);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuanLyNhanVien_CEO";
            Size = new Size(926, 595);
            Load += QuanLyNhanVien_CEO_Load;
            pnlChinh.ResumeLayout(false);
            pnlChinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).EndInit();
            panel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChinh;
        private Label label1;
        private Panel panel1;
        private Panel panel6;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label labelDeactive;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label labelActive;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button buttonCreateUser;
        private Guna.UI2.WinForms.Guna2Button buttonBlockUser;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewNhanVien;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn VaiTro;
        private DataGridViewTextBoxColumn TrangThai;
    }
}
