namespace View.Usercontrol
{
    partial class PhongBan
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTenDuAn = new Label();
            dataGridViewPhongBan = new Guna.UI2.WinForms.Guna2DataGridView();
            ProfileID = new DataGridViewTextBoxColumn();
            ProfileName = new DataGridViewTextBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            ModifiedDate = new DataGridViewTextBoxColumn();
            contextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            btnXoaPhongBan = new Guna.UI2.WinForms.Guna2Button();
            textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnTaoPhongBan = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhongBan).BeginInit();
            contextMenuStrip.SuspendLayout();
            guna2Panel7.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenDuAn
            // 
            lblTenDuAn.AutoSize = true;
            lblTenDuAn.Location = new Point(2, 10);
            lblTenDuAn.Margin = new Padding(2, 0, 2, 0);
            lblTenDuAn.Name = "lblTenDuAn";
            lblTenDuAn.Size = new Size(83, 15);
            lblTenDuAn.TabIndex = 3;
            lblTenDuAn.Text = "DocMana Ver0";
            // 
            // dataGridViewPhongBan
            // 
            dataGridViewPhongBan.AllowUserToAddRows = false;
            dataGridViewPhongBan.AllowUserToDeleteRows = false;
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
            dataGridViewPhongBan.ContextMenuStrip = contextMenuStrip;
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
            dataGridViewPhongBan.Location = new Point(0, 90);
            dataGridViewPhongBan.Margin = new Padding(2);
            dataGridViewPhongBan.Name = "dataGridViewPhongBan";
            dataGridViewPhongBan.ReadOnly = true;
            dataGridViewPhongBan.RowHeadersVisible = false;
            dataGridViewPhongBan.RowHeadersWidth = 51;
            dataGridViewPhongBan.RowTemplate.Height = 24;
            dataGridViewPhongBan.Size = new Size(926, 471);
            dataGridViewPhongBan.TabIndex = 7;
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
            dataGridViewPhongBan.ThemeStyle.ReadOnly = true;
            dataGridViewPhongBan.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewPhongBan.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPhongBan.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewPhongBan.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewPhongBan.ThemeStyle.RowsStyle.Height = 24;
            dataGridViewPhongBan.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewPhongBan.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewPhongBan.CellDoubleClick += dataGridViewPhongBan_CellClick;
            dataGridViewPhongBan.CellMouseClick += dataGridViewPhongBan_CellMouseClick;
            // 
            // ProfileID
            // 
            ProfileID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProfileID.HeaderText = "ID Phòng ban";
            ProfileID.MinimumWidth = 6;
            ProfileID.Name = "ProfileID";
            ProfileID.ReadOnly = true;
            // 
            // ProfileName
            // 
            ProfileName.HeaderText = "Tên Phòng ban";
            ProfileName.MinimumWidth = 6;
            ProfileName.Name = "ProfileName";
            ProfileName.ReadOnly = true;
            // 
            // CreatedBy
            // 
            CreatedBy.HeaderText = "Quản lý";
            CreatedBy.MinimumWidth = 6;
            CreatedBy.Name = "CreatedBy";
            CreatedBy.ReadOnly = true;
            // 
            // ModifiedDate
            // 
            ModifiedDate.HeaderText = "Cập nhật gần nhất";
            ModifiedDate.MinimumWidth = 6;
            ModifiedDate.Name = "ModifiedDate";
            ModifiedDate.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            contextMenuStrip.RenderStyle.BorderColor = Color.Gainsboro;
            contextMenuStrip.RenderStyle.ColorTable = null;
            contextMenuStrip.RenderStyle.RoundedEdges = true;
            contextMenuStrip.RenderStyle.SelectionArrowColor = Color.White;
            contextMenuStrip.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            contextMenuStrip.RenderStyle.SelectionForeColor = Color.White;
            contextMenuStrip.RenderStyle.SeparatorColor = Color.Gainsboro;
            contextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            contextMenuStrip.Size = new Size(123, 26);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(122, 22);
            cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // guna2Panel7
            // 
            guna2Panel7.BackColor = Color.White;
            guna2Panel7.Controls.Add(btnXoaPhongBan);
            guna2Panel7.Controls.Add(textBoxSearch);
            guna2Panel7.Controls.Add(btnTaoPhongBan);
            guna2Panel7.CustomizableEdges = customizableEdges7;
            guna2Panel7.Dock = DockStyle.Top;
            guna2Panel7.Location = new Point(0, 47);
            guna2Panel7.Margin = new Padding(4, 3, 4, 3);
            guna2Panel7.Name = "guna2Panel7";
            guna2Panel7.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel7.Size = new Size(926, 43);
            guna2Panel7.TabIndex = 6;
            // 
            // btnXoaPhongBan
            // 
            btnXoaPhongBan.BorderColor = Color.White;
            btnXoaPhongBan.CustomizableEdges = customizableEdges1;
            btnXoaPhongBan.DisabledState.BorderColor = Color.DarkGray;
            btnXoaPhongBan.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoaPhongBan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoaPhongBan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoaPhongBan.FillColor = Color.White;
            btnXoaPhongBan.Font = new Font("Segoe UI", 9.75F);
            btnXoaPhongBan.ForeColor = Color.Black;
            btnXoaPhongBan.Image = Properties.Resources.remove;
            btnXoaPhongBan.ImageAlign = HorizontalAlignment.Left;
            btnXoaPhongBan.Location = new Point(192, 6);
            btnXoaPhongBan.Margin = new Padding(4, 3, 4, 3);
            btnXoaPhongBan.Name = "btnXoaPhongBan";
            btnXoaPhongBan.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnXoaPhongBan.Size = new Size(188, 29);
            btnXoaPhongBan.TabIndex = 6;
            btnXoaPhongBan.Text = "Xóa phòng ban";
            btnXoaPhongBan.TextOffset = new Point(5, 0);
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.CustomizableEdges = customizableEdges3;
            textBoxSearch.DefaultText = "Tìm kiếm phòng ban";
            textBoxSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearch.Font = new Font("Segoe UI", 9F);
            textBoxSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearch.IconRight = Properties.Resources.icons8_search_40;
            textBoxSearch.Location = new Point(651, 5);
            textBoxSearch.Margin = new Padding(4, 5, 4, 5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PasswordChar = '\0';
            textBoxSearch.PlaceholderText = "";
            textBoxSearch.SelectedText = "";
            textBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textBoxSearch.Size = new Size(271, 32);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // btnTaoPhongBan
            // 
            btnTaoPhongBan.BorderColor = Color.White;
            btnTaoPhongBan.CustomizableEdges = customizableEdges5;
            btnTaoPhongBan.DisabledState.BorderColor = Color.DarkGray;
            btnTaoPhongBan.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTaoPhongBan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTaoPhongBan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTaoPhongBan.FillColor = Color.White;
            btnTaoPhongBan.Font = new Font("Segoe UI", 9.75F);
            btnTaoPhongBan.ForeColor = Color.Black;
            btnTaoPhongBan.Image = Properties.Resources.icons8_plus_30;
            btnTaoPhongBan.ImageAlign = HorizontalAlignment.Left;
            btnTaoPhongBan.Location = new Point(5, 6);
            btnTaoPhongBan.Margin = new Padding(4, 3, 4, 3);
            btnTaoPhongBan.Name = "btnTaoPhongBan";
            btnTaoPhongBan.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnTaoPhongBan.Size = new Size(167, 29);
            btnTaoPhongBan.TabIndex = 2;
            btnTaoPhongBan.Text = "Tạo phòng ban";
            btnTaoPhongBan.TextOffset = new Point(8, 0);
            btnTaoPhongBan.Click += btnTaoPhongBan_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTenDuAn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 47);
            panel1.TabIndex = 5;
            // 
            // PhongBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewPhongBan);
            Controls.Add(guna2Panel7);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PhongBan";
            Size = new Size(926, 561);
            Load += PhongBan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhongBan).EndInit();
            contextMenuStrip.ResumeLayout(false);
            guna2Panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTenDuAn;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Button btnXoaPhongBan;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2Button btnTaoPhongBan;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
    }
}
