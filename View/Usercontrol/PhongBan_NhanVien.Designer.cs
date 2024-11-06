namespace View
{
    partial class PhongBan_NhanVien
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblTenDuAn = new Label();
            guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridViewPhongBan = new Guna.UI2.WinForms.Guna2DataGridView();
            ProfileID = new DataGridViewTextBoxColumn();
            ProfileName = new DataGridViewTextBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            ModifiedDate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            guna2Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhongBan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTenDuAn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 56);
            panel1.TabIndex = 6;
            // 
            // lblTenDuAn
            // 
            lblTenDuAn.AutoSize = true;
            lblTenDuAn.Location = new Point(2, 13);
            lblTenDuAn.Margin = new Padding(2, 0, 2, 0);
            lblTenDuAn.Name = "lblTenDuAn";
            lblTenDuAn.Size = new Size(106, 20);
            lblTenDuAn.TabIndex = 3;
            lblTenDuAn.Text = "DocMana Ver0";
            // 
            // guna2Panel7
            // 
            guna2Panel7.BackColor = Color.White;
            guna2Panel7.Controls.Add(label1);
            guna2Panel7.Controls.Add(guna2TextBox1);
            guna2Panel7.CustomizableEdges = customizableEdges3;
            guna2Panel7.Dock = DockStyle.Top;
            guna2Panel7.Location = new Point(0, 56);
            guna2Panel7.Margin = new Padding(5, 4, 5, 4);
            guna2Panel7.Name = "guna2Panel7";
            guna2Panel7.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel7.Size = new Size(1058, 57);
            guna2Panel7.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(0, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 25);
            label1.TabIndex = 4;
            label1.Text = "Danh sách phòng ban của nhân viên";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.Cursor = Cursors.IBeam;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "Tìm kiếm phòng ban";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconRight = Properties.Resources.icons8_search_40;
            guna2TextBox1.Location = new Point(707, 7);
            guna2TextBox1.Margin = new Padding(5, 7, 5, 7);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(335, 43);
            guna2TextBox1.TabIndex = 1;
            // 
            // dataGridViewPhongBan
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewPhongBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPhongBan.ColumnHeadersHeight = 35;
            dataGridViewPhongBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewPhongBan.Columns.AddRange(new DataGridViewColumn[] { ProfileID, ProfileName, CreatedBy, ModifiedDate });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewPhongBan.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPhongBan.Dock = DockStyle.Fill;
            dataGridViewPhongBan.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewPhongBan.Location = new Point(0, 113);
            dataGridViewPhongBan.Margin = new Padding(2, 3, 2, 3);
            dataGridViewPhongBan.Name = "dataGridViewPhongBan";
            dataGridViewPhongBan.RowHeadersVisible = false;
            dataGridViewPhongBan.RowHeadersWidth = 51;
            dataGridViewPhongBan.RowTemplate.Height = 24;
            dataGridViewPhongBan.Size = new Size(1058, 481);
            dataGridViewPhongBan.TabIndex = 8;
            dataGridViewPhongBan.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewPhongBan.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewPhongBan.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewPhongBan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewPhongBan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewPhongBan.ThemeStyle.BackColor = Color.White;
            dataGridViewPhongBan.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewPhongBan.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewPhongBan.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPhongBan.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewPhongBan.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewPhongBan.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewPhongBan.ThemeStyle.HeaderStyle.Height = 35;
            dataGridViewPhongBan.ThemeStyle.ReadOnly = false;
            dataGridViewPhongBan.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewPhongBan.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPhongBan.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewPhongBan.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewPhongBan.ThemeStyle.RowsStyle.Height = 24;
            dataGridViewPhongBan.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewPhongBan.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ProfileID
            // 
            ProfileID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProfileID.HeaderText = "ID Phòng ban";
            ProfileID.MinimumWidth = 6;
            ProfileID.Name = "ProfileID";
            // 
            // ProfileName
            // 
            ProfileName.HeaderText = "Tên Phòng ban";
            ProfileName.MinimumWidth = 6;
            ProfileName.Name = "ProfileName";
            // 
            // CreatedBy
            // 
            CreatedBy.HeaderText = "Quản lý";
            CreatedBy.MinimumWidth = 6;
            CreatedBy.Name = "CreatedBy";
            // 
            // ModifiedDate
            // 
            ModifiedDate.HeaderText = "Cập nhật gần nhất";
            ModifiedDate.MinimumWidth = 6;
            ModifiedDate.Name = "ModifiedDate";
            // 
            // PhongBan_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewPhongBan);
            Controls.Add(guna2Panel7);
            Controls.Add(panel1);
            Name = "PhongBan_NhanVien";
            Size = new Size(1058, 594);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2Panel7.ResumeLayout(false);
            guna2Panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhongBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTenDuAn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewPhongBan;
        private DataGridViewTextBoxColumn ProfileID;
        private DataGridViewTextBoxColumn ProfileName;
        private DataGridViewTextBoxColumn CreatedBy;
        private DataGridViewTextBoxColumn ModifiedDate;
    }
}
