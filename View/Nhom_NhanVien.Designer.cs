namespace View
{
    partial class Nhom_NhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ChucVu = new DataGridViewTextBoxColumn();
            dataGridViewThanhVien = new Guna.UI2.WinForms.Guna2DataGridView();
            Ten = new DataGridViewTextBoxColumn();
            ThanhVien = new TabPage();
            CapNhat = new DataGridViewTextBoxColumn();
            TruongNhom = new DataGridViewTextBoxColumn();
            TenNhom = new DataGridViewTextBoxColumn();
            Idnhom = new DataGridViewTextBoxColumn();
            dataGridViewNhom = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            Nhom = new TabPage();
            txtBoxTimKiemNhom = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThanhVien).BeginInit();
            ThanhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhom).BeginInit();
            guna2TabControl1.SuspendLayout();
            Nhom.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ChucVu
            // 
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            // 
            // dataGridViewThanhVien
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewThanhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewThanhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewThanhVien.ColumnHeadersHeight = 22;
            dataGridViewThanhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewThanhVien.Columns.AddRange(new DataGridViewColumn[] { Ten, ChucVu });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewThanhVien.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewThanhVien.Dock = DockStyle.Fill;
            dataGridViewThanhVien.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewThanhVien.Location = new Point(3, 3);
            dataGridViewThanhVien.Name = "dataGridViewThanhVien";
            dataGridViewThanhVien.RowHeadersVisible = false;
            dataGridViewThanhVien.RowHeadersWidth = 51;
            dataGridViewThanhVien.Size = new Size(1044, 634);
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
            dataGridViewThanhVien.ThemeStyle.ReadOnly = false;
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
            Ten.HeaderText = "Tên";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            // 
            // ThanhVien
            // 
            ThanhVien.Controls.Add(dataGridViewThanhVien);
            ThanhVien.Location = new Point(4, 44);
            ThanhVien.Name = "ThanhVien";
            ThanhVien.Padding = new Padding(3);
            ThanhVien.Size = new Size(1050, 640);
            ThanhVien.TabIndex = 1;
            ThanhVien.Text = "Thành viên";
            ThanhVien.UseVisualStyleBackColor = true;
            // 
            // CapNhat
            // 
            CapNhat.HeaderText = "Cập nhật gần nhất";
            CapNhat.MinimumWidth = 6;
            CapNhat.Name = "CapNhat";
            // 
            // TruongNhom
            // 
            TruongNhom.HeaderText = "Trưởng nhóm";
            TruongNhom.MinimumWidth = 6;
            TruongNhom.Name = "TruongNhom";
            // 
            // TenNhom
            // 
            TenNhom.HeaderText = "Tên nhóm";
            TenNhom.MinimumWidth = 6;
            TenNhom.Name = "TenNhom";
            // 
            // Idnhom
            // 
            Idnhom.HeaderText = "ID nhóm";
            Idnhom.MinimumWidth = 6;
            Idnhom.Name = "Idnhom";
            // 
            // dataGridViewNhom
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewNhom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewNhom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewNhom.ColumnHeadersHeight = 22;
            dataGridViewNhom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewNhom.Columns.AddRange(new DataGridViewColumn[] { Idnhom, TenNhom, TruongNhom, CapNhat });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewNhom.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewNhom.Dock = DockStyle.Fill;
            dataGridViewNhom.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewNhom.Location = new Point(3, 3);
            dataGridViewNhom.Name = "dataGridViewNhom";
            dataGridViewNhom.RowHeadersVisible = false;
            dataGridViewNhom.RowHeadersWidth = 51;
            dataGridViewNhom.Size = new Size(1044, 479);
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
            dataGridViewNhom.ThemeStyle.ReadOnly = false;
            dataGridViewNhom.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewNhom.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewNhom.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewNhom.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewNhom.ThemeStyle.RowsStyle.Height = 29;
            dataGridViewNhom.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewNhom.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Controls.Add(Nhom);
            guna2TabControl1.Controls.Add(ThanhVien);
            guna2TabControl1.Dock = DockStyle.Fill;
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(0, 105);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(1058, 533);
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
            guna2TabControl1.TabIndex = 5;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // Nhom
            // 
            Nhom.Controls.Add(dataGridViewNhom);
            Nhom.Location = new Point(4, 44);
            Nhom.Name = "Nhom";
            Nhom.Padding = new Padding(3);
            Nhom.Size = new Size(1050, 485);
            Nhom.TabIndex = 0;
            Nhom.Text = "Nhóm ";
            Nhom.UseVisualStyleBackColor = true;
            // 
            // txtBoxTimKiemNhom
            // 
            txtBoxTimKiemNhom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxTimKiemNhom.Cursor = Cursors.IBeam;
            txtBoxTimKiemNhom.CustomizableEdges = customizableEdges1;
            txtBoxTimKiemNhom.DefaultText = "Tìm kiếm nhóm";
            txtBoxTimKiemNhom.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBoxTimKiemNhom.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBoxTimKiemNhom.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBoxTimKiemNhom.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBoxTimKiemNhom.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxTimKiemNhom.Font = new Font("Segoe UI", 9F);
            txtBoxTimKiemNhom.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxTimKiemNhom.IconRight = Properties.Resources.icons8_search_40;
            txtBoxTimKiemNhom.Location = new Point(348, 5);
            txtBoxTimKiemNhom.Margin = new Padding(5, 7, 5, 7);
            txtBoxTimKiemNhom.Name = "txtBoxTimKiemNhom";
            txtBoxTimKiemNhom.PasswordChar = '\0';
            txtBoxTimKiemNhom.PlaceholderText = "";
            txtBoxTimKiemNhom.SelectedText = "";
            txtBoxTimKiemNhom.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBoxTimKiemNhom.Size = new Size(337, 43);
            txtBoxTimKiemNhom.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtBoxTimKiemNhom);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(1058, 55);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 11);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "DocMana Ver0 > HCKT";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 50);
            panel1.TabIndex = 3;
            // 
            // Nhom_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2TabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Location = new Point(246, 124);
            Name = "Nhom_NhanVien";
            Size = new Size(1058, 638);
            ((System.ComponentModel.ISupportInitialize)dataGridViewThanhVien).EndInit();
            ThanhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhom).EndInit();
            guna2TabControl1.ResumeLayout(false);
            Nhom.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn ChucVu;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewThanhVien;
        private DataGridViewTextBoxColumn Ten;
        private TabPage ThanhVien;
        private DataGridViewTextBoxColumn CapNhat;
        private DataGridViewTextBoxColumn TruongNhom;
        private DataGridViewTextBoxColumn TenNhom;
        private DataGridViewTextBoxColumn Idnhom;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewNhom;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage Nhom;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxTimKiemNhom;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
    }
}
