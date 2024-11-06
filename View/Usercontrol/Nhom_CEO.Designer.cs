namespace View
{
    partial class Nhom_CEO
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelCheck = new Label();
            panel2 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnXoaNhom = new Guna.UI2.WinForms.Guna2Button();
            btnTaonhom = new Guna.UI2.WinForms.Guna2Button();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            Nhom = new TabPage();
            dataGridViewNhom = new Guna.UI2.WinForms.Guna2DataGridView();
            Idnhom = new DataGridViewTextBoxColumn();
            TenNhom = new DataGridViewTextBoxColumn();
            TruongNhom = new DataGridViewTextBoxColumn();
            CapNhat = new DataGridViewTextBoxColumn();
            ThanhVien = new TabPage();
            dataGridViewThanhVien = new Guna.UI2.WinForms.Guna2DataGridView();
            Ten = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            guna2TabControl1.SuspendLayout();
            Nhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhom).BeginInit();
            ThanhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThanhVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCheck);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 38);
            panel1.TabIndex = 0;
            // 
            // labelCheck
            // 
            labelCheck.AutoSize = true;
            labelCheck.Location = new Point(4, 8);
            labelCheck.Name = "labelCheck";
            labelCheck.Size = new Size(94, 15);
            labelCheck.TabIndex = 0;
            labelCheck.Text = "DocMana Ver0 >";
            // 
            // panel2
            // 
            panel2.Controls.Add(guna2Button1);
            panel2.Controls.Add(textBoxSearch);
            panel2.Controls.Add(btnXoaNhom);
            panel2.Controls.Add(btnTaonhom);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 38);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(926, 41);
            panel2.TabIndex = 1;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.White;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI", 9.75F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = Properties.Resources.icons8_plus_30;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.Location = new Point(408, 3);
            guna2Button1.Margin = new Padding(4, 3, 4, 3);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(167, 29);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "Thêm thành viên";
            guna2Button1.TextOffset = new Point(8, 0);
            guna2Button1.Click += guna2Button1_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.CustomizableEdges = customizableEdges3;
            textBoxSearch.DefaultText = "Tìm kiếm nhóm";
            textBoxSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearch.Font = new Font("Segoe UI", 9F);
            textBoxSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearch.IconRight = Properties.Resources.icons8_search_40;
            textBoxSearch.Location = new Point(650, 3);
            textBoxSearch.Margin = new Padding(4, 5, 4, 5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PasswordChar = '\0';
            textBoxSearch.PlaceholderText = "";
            textBoxSearch.SelectedText = "";
            textBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textBoxSearch.Size = new Size(271, 32);
            textBoxSearch.TabIndex = 8;
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // btnXoaNhom
            // 
            btnXoaNhom.BorderColor = Color.White;
            btnXoaNhom.CustomizableEdges = customizableEdges5;
            btnXoaNhom.DisabledState.BorderColor = Color.DarkGray;
            btnXoaNhom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoaNhom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoaNhom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoaNhom.FillColor = Color.White;
            btnXoaNhom.Font = new Font("Segoe UI", 9.75F);
            btnXoaNhom.ForeColor = Color.Black;
            btnXoaNhom.Image = Properties.Resources.remove;
            btnXoaNhom.ImageAlign = HorizontalAlignment.Left;
            btnXoaNhom.Location = new Point(190, 3);
            btnXoaNhom.Margin = new Padding(4, 3, 4, 3);
            btnXoaNhom.Name = "btnXoaNhom";
            btnXoaNhom.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnXoaNhom.Size = new Size(188, 29);
            btnXoaNhom.TabIndex = 7;
            btnXoaNhom.Text = "Xóa nhóm";
            btnXoaNhom.TextOffset = new Point(5, 0);
            // 
            // btnTaonhom
            // 
            btnTaonhom.BorderColor = Color.White;
            btnTaonhom.CustomizableEdges = customizableEdges7;
            btnTaonhom.DisabledState.BorderColor = Color.DarkGray;
            btnTaonhom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTaonhom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTaonhom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTaonhom.FillColor = Color.White;
            btnTaonhom.Font = new Font("Segoe UI", 9.75F);
            btnTaonhom.ForeColor = Color.Black;
            btnTaonhom.Image = Properties.Resources.icons8_plus_30;
            btnTaonhom.ImageAlign = HorizontalAlignment.Left;
            btnTaonhom.Location = new Point(4, 3);
            btnTaonhom.Margin = new Padding(4, 3, 4, 3);
            btnTaonhom.Name = "btnTaonhom";
            btnTaonhom.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnTaonhom.Size = new Size(167, 29);
            btnTaonhom.TabIndex = 3;
            btnTaonhom.Text = "Tạo nhóm";
            btnTaonhom.TextOffset = new Point(8, 0);
            btnTaonhom.Click += btnTaonhom_Click;
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Controls.Add(Nhom);
            guna2TabControl1.Controls.Add(ThanhVien);
            guna2TabControl1.Dock = DockStyle.Fill;
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(0, 79);
            guna2TabControl1.Margin = new Padding(3, 2, 3, 2);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(926, 516);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 2;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // Nhom
            // 
            Nhom.Controls.Add(dataGridViewNhom);
            Nhom.Location = new Point(4, 44);
            Nhom.Margin = new Padding(3, 2, 3, 2);
            Nhom.Name = "Nhom";
            Nhom.Padding = new Padding(3, 2, 3, 2);
            Nhom.Size = new Size(918, 468);
            Nhom.TabIndex = 0;
            Nhom.Text = "Nhóm ";
            Nhom.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNhom
            // 
            dataGridViewNhom.AllowUserToAddRows = false;
            dataGridViewNhom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewNhom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewNhom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewNhom.ColumnHeadersHeight = 22;
            dataGridViewNhom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewNhom.Columns.AddRange(new DataGridViewColumn[] { Idnhom, TenNhom, TruongNhom, CapNhat });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewNhom.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewNhom.Dock = DockStyle.Fill;
            dataGridViewNhom.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewNhom.Location = new Point(3, 2);
            dataGridViewNhom.Margin = new Padding(3, 2, 3, 2);
            dataGridViewNhom.Name = "dataGridViewNhom";
            dataGridViewNhom.ReadOnly = true;
            dataGridViewNhom.RowHeadersVisible = false;
            dataGridViewNhom.RowHeadersWidth = 51;
            dataGridViewNhom.RowTemplate.Height = 29;
            dataGridViewNhom.Size = new Size(912, 464);
            dataGridViewNhom.TabIndex = 0;
            dataGridViewNhom.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewNhom.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewNhom.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewNhom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewNhom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewNhom.ThemeStyle.BackColor = Color.White;
            dataGridViewNhom.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewNhom.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewNhom.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewNhom.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewNhom.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewNhom.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewNhom.ThemeStyle.HeaderStyle.Height = 22;
            dataGridViewNhom.ThemeStyle.ReadOnly = true;
            dataGridViewNhom.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewNhom.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewNhom.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewNhom.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewNhom.ThemeStyle.RowsStyle.Height = 29;
            dataGridViewNhom.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewNhom.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewNhom.CellClick += dataGridViewNhom_CellClick;
            // 
            // Idnhom
            // 
            Idnhom.HeaderText = "ID nhóm";
            Idnhom.MinimumWidth = 6;
            Idnhom.Name = "Idnhom";
            Idnhom.ReadOnly = true;
            // 
            // TenNhom
            // 
            TenNhom.HeaderText = "Tên nhóm";
            TenNhom.MinimumWidth = 6;
            TenNhom.Name = "TenNhom";
            TenNhom.ReadOnly = true;
            // 
            // TruongNhom
            // 
            TruongNhom.HeaderText = "Trưởng nhóm";
            TruongNhom.MinimumWidth = 6;
            TruongNhom.Name = "TruongNhom";
            TruongNhom.ReadOnly = true;
            // 
            // CapNhat
            // 
            CapNhat.HeaderText = "Cập nhật gần nhất";
            CapNhat.MinimumWidth = 6;
            CapNhat.Name = "CapNhat";
            CapNhat.ReadOnly = true;
            // 
            // ThanhVien
            // 
            ThanhVien.Controls.Add(dataGridViewThanhVien);
            ThanhVien.Location = new Point(4, 44);
            ThanhVien.Margin = new Padding(3, 2, 3, 2);
            ThanhVien.Name = "ThanhVien";
            ThanhVien.Padding = new Padding(3, 2, 3, 2);
            ThanhVien.Size = new Size(918, 468);
            ThanhVien.TabIndex = 1;
            ThanhVien.Text = "Thành viên";
            ThanhVien.UseVisualStyleBackColor = true;
            // 
            // dataGridViewThanhVien
            // 
            dataGridViewThanhVien.AllowUserToAddRows = false;
            dataGridViewThanhVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewThanhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewThanhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewThanhVien.ColumnHeadersHeight = 22;
            dataGridViewThanhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewThanhVien.Columns.AddRange(new DataGridViewColumn[] { Ten, ChucVu });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewThanhVien.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewThanhVien.Dock = DockStyle.Fill;
            dataGridViewThanhVien.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewThanhVien.Location = new Point(3, 2);
            dataGridViewThanhVien.Margin = new Padding(3, 2, 3, 2);
            dataGridViewThanhVien.Name = "dataGridViewThanhVien";
            dataGridViewThanhVien.ReadOnly = true;
            dataGridViewThanhVien.RowHeadersVisible = false;
            dataGridViewThanhVien.RowHeadersWidth = 51;
            dataGridViewThanhVien.RowTemplate.Height = 29;
            dataGridViewThanhVien.Size = new Size(912, 464);
            dataGridViewThanhVien.TabIndex = 0;
            dataGridViewThanhVien.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewThanhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewThanhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewThanhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewThanhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewThanhVien.ThemeStyle.BackColor = Color.White;
            dataGridViewThanhVien.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewThanhVien.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewThanhVien.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewThanhVien.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewThanhVien.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewThanhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewThanhVien.ThemeStyle.HeaderStyle.Height = 22;
            dataGridViewThanhVien.ThemeStyle.ReadOnly = true;
            dataGridViewThanhVien.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewThanhVien.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewThanhVien.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewThanhVien.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewThanhVien.ThemeStyle.RowsStyle.Height = 29;
            dataGridViewThanhVien.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewThanhVien.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Ten
            // 
            Ten.HeaderText = "UserID";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            Ten.ReadOnly = true;
            // 
            // ChucVu
            // 
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            // 
            // Nhom_CEO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2TabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Nhom_CEO";
            Size = new Size(926, 595);
            Load += Nhom_CEO_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            guna2TabControl1.ResumeLayout(false);
            Nhom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhom).EndInit();
            ThanhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewThanhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelCheck;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnTaonhom;
        private Guna.UI2.WinForms.Guna2Button btnXoaNhom;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage Nhom;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewNhom;
        private DataGridViewTextBoxColumn Idnhom;
        private DataGridViewTextBoxColumn TenNhom;
        private DataGridViewTextBoxColumn TruongNhom;
        private DataGridViewTextBoxColumn CapNhat;
        private TabPage ThanhVien;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewThanhVien;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn ChucVu;
    }
}
