namespace View.Usercontrol
{
    partial class ThongBao
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongBao));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            TxtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            panelChinh = new Panel();
            pnlThongBao = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox2 = new PictureBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            NdThongBao = new DataGridViewTextBoxColumn();
            PhongBan = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewButtonColumn();
            label1 = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1.SuspendLayout();
            panelChinh.SuspendLayout();
            pnlThongBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(TxtTimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 80);
            panel1.TabIndex = 0;
            // 
            // TxtTimKiem
            // 
            TxtTimKiem.Cursor = Cursors.IBeam;
            TxtTimKiem.CustomizableEdges = customizableEdges1;
            TxtTimKiem.DefaultText = "\r\nTìm kiếm";
            TxtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtTimKiem.Font = new Font("Segoe UI", 9F);
            TxtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtTimKiem.IconRight = (Image)resources.GetObject("TxtTimKiem.IconRight");
            TxtTimKiem.Location = new Point(2, 21);
            TxtTimKiem.Margin = new Padding(2, 4, 2, 4);
            TxtTimKiem.Name = "TxtTimKiem";
            TxtTimKiem.PasswordChar = '\0';
            TxtTimKiem.PlaceholderText = "";
            TxtTimKiem.SelectedText = "";
            TxtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TxtTimKiem.Size = new Size(358, 32);
            TxtTimKiem.TabIndex = 1;
            // 
            // panelChinh
            // 
            panelChinh.Controls.Add(pnlThongBao);
            panelChinh.Controls.Add(panel1);
            panelChinh.Dock = DockStyle.Fill;
            panelChinh.Location = new Point(0, 0);
            panelChinh.Margin = new Padding(2, 3, 2, 3);
            panelChinh.Name = "panelChinh";
            panelChinh.Size = new Size(1058, 791);
            panelChinh.TabIndex = 1;
            // 
            // pnlThongBao
            // 
            pnlThongBao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlThongBao.BackColor = Color.White;
            pnlThongBao.Controls.Add(pictureBox2);
            pnlThongBao.Controls.Add(guna2DataGridView1);
            pnlThongBao.Controls.Add(label1);
            pnlThongBao.CustomizableEdges = customizableEdges3;
            pnlThongBao.Location = new Point(2, 110);
            pnlThongBao.Margin = new Padding(2, 3, 2, 3);
            pnlThongBao.Name = "pnlThongBao";
            pnlThongBao.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlThongBao.Size = new Size(1022, 629);
            pnlThongBao.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = Properties.Resources.notification;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(15, 13);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 36);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { NdThongBao, PhongBan, ThoiGian, TrangThai, XemChiTiet });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(15, 71);
            guna2DataGridView1.Margin = new Padding(2, 3, 2, 3);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 24;
            guna2DataGridView1.Size = new Size(990, 537);
            guna2DataGridView1.TabIndex = 3;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // NdThongBao
            // 
            NdThongBao.HeaderText = "Thông báo";
            NdThongBao.MinimumWidth = 6;
            NdThongBao.Name = "NdThongBao";
            // 
            // PhongBan
            // 
            PhongBan.HeaderText = "Phòng Ban";
            PhongBan.MinimumWidth = 6;
            PhongBan.Name = "PhongBan";
            // 
            // ThoiGian
            // 
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.MinimumWidth = 6;
            ThoiGian.Name = "ThoiGian";
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // XemChiTiet
            // 
            XemChiTiet.HeaderText = "Xem chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(54, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 1;
            label1.Text = "Thông báo";
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ThongBao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelChinh);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ThongBao";
            Size = new Size(1058, 791);
            panel1.ResumeLayout(false);
            panelChinh.ResumeLayout(false);
            pnlThongBao.ResumeLayout(false);
            pnlThongBao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TxtTimKiem;
        private System.Windows.Forms.Panel panelChinh;
        private Guna.UI2.WinForms.Guna2Panel pnlThongBao;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NdThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn XemChiTiet;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private PictureBox pictureBox2;
    }
}
