namespace View
{
    partial class TrongNhom
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
            panel1 = new Panel();
            labelCheck = new Label();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            HoSo = new TabPage();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ThanhVien = new TabPage();
            dataGridViewMembers = new Guna.UI2.WinForms.Guna2DataGridView();
            TenThanhVien = new DataGridViewTextBoxColumn();
            ViTri = new DataGridViewTextBoxColumn();
            IDHoSo = new DataGridViewTextBoxColumn();
            TenHoSo = new DataGridViewTextBoxColumn();
            NguoiTao = new DataGridViewTextBoxColumn();
            CapNhat = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            guna2TabControl1.SuspendLayout();
            HoSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            ThanhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCheck);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 45);
            panel1.TabIndex = 0;
            // 
            // labelCheck
            // 
            labelCheck.AutoSize = true;
            labelCheck.Location = new Point(3, 11);
            labelCheck.Name = "labelCheck";
            labelCheck.Size = new Size(120, 20);
            labelCheck.TabIndex = 1;
            labelCheck.Text = "DocMana Ver0 >";
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Controls.Add(HoSo);
            guna2TabControl1.Controls.Add(ThanhVien);
            guna2TabControl1.Dock = DockStyle.Fill;
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(0, 45);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(1058, 748);
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
            guna2TabControl1.TabIndex = 1;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // HoSo
            // 
            HoSo.Controls.Add(guna2DataGridView1);
            HoSo.Location = new Point(4, 44);
            HoSo.Name = "HoSo";
            HoSo.Padding = new Padding(3, 3, 3, 3);
            HoSo.Size = new Size(1050, 700);
            HoSo.TabIndex = 0;
            HoSo.Text = "Hồ sơ";
            HoSo.UseVisualStyleBackColor = true;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 22;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDHoSo, TenHoSo, NguoiTao, CapNhat, Column1 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.Dock = DockStyle.Fill;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(3, 3);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(1044, 694);
            guna2DataGridView1.TabIndex = 0;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 22;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // ThanhVien
            // 
            ThanhVien.Controls.Add(dataGridViewMembers);
            ThanhVien.Location = new Point(4, 44);
            ThanhVien.Name = "ThanhVien";
            ThanhVien.Padding = new Padding(3, 3, 3, 3);
            ThanhVien.Size = new Size(1050, 700);
            ThanhVien.TabIndex = 1;
            ThanhVien.Text = "Thành viên";
            ThanhVien.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMembers
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewMembers.ColumnHeadersHeight = 22;
            dataGridViewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewMembers.Columns.AddRange(new DataGridViewColumn[] { TenThanhVien, ViTri });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewMembers.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewMembers.Dock = DockStyle.Fill;
            dataGridViewMembers.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewMembers.Location = new Point(3, 3);
            dataGridViewMembers.Name = "dataGridViewMembers";
            dataGridViewMembers.RowHeadersVisible = false;
            dataGridViewMembers.RowHeadersWidth = 51;
            dataGridViewMembers.Size = new Size(1044, 694);
            dataGridViewMembers.TabIndex = 0;
            dataGridViewMembers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewMembers.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewMembers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewMembers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewMembers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewMembers.ThemeStyle.BackColor = Color.White;
            dataGridViewMembers.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewMembers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewMembers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMembers.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewMembers.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewMembers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewMembers.ThemeStyle.HeaderStyle.Height = 22;
            dataGridViewMembers.ThemeStyle.ReadOnly = false;
            dataGridViewMembers.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewMembers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewMembers.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewMembers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewMembers.ThemeStyle.RowsStyle.Height = 29;
            dataGridViewMembers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewMembers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // TenThanhVien
            // 
            TenThanhVien.HeaderText = "Tên";
            TenThanhVien.MinimumWidth = 6;
            TenThanhVien.Name = "TenThanhVien";
            // 
            // ViTri
            // 
            ViTri.HeaderText = "Vị trí";
            ViTri.MinimumWidth = 6;
            ViTri.Name = "ViTri";
            // 
            // IDHoSo
            // 
            IDHoSo.HeaderText = "ID hồ sơ";
            IDHoSo.MinimumWidth = 6;
            IDHoSo.Name = "IDHoSo";
            // 
            // TenHoSo
            // 
            TenHoSo.HeaderText = "Tên hồ sơ";
            TenHoSo.MinimumWidth = 6;
            TenHoSo.Name = "TenHoSo";
            // 
            // NguoiTao
            // 
            NguoiTao.HeaderText = "Người tạo";
            NguoiTao.MinimumWidth = 6;
            NguoiTao.Name = "NguoiTao";
            // 
            // CapNhat
            // 
            CapNhat.HeaderText = "Cập nhật gần nhất";
            CapNhat.MinimumWidth = 6;
            CapNhat.Name = "CapNhat";
            // 
            // Column1
            // 
            Column1.HeaderText = "...";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // TrongNhom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2TabControl1);
            Controls.Add(panel1);
            Location = new Point(246, 124);
            Name = "TrongNhom";
            Size = new Size(1058, 793);
            Load += TrongNhom_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2TabControl1.ResumeLayout(false);
            HoSo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ThanhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelCheck;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage HoSo;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private TabPage ThanhVien;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewMembers;
        private DataGridViewTextBoxColumn TenThanhVien;
        private DataGridViewTextBoxColumn ViTri;
        private DataGridViewTextBoxColumn IDHoSo;
        private DataGridViewTextBoxColumn TenHoSo;
        private DataGridViewTextBoxColumn NguoiTao;
        private DataGridViewTextBoxColumn CapNhat;
        private DataGridViewButtonColumn Column1;
    }
}
