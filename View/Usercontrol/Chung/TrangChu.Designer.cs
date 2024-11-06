namespace View.Usercontrol
{
    partial class TrangChu
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
            label1 = new Label();
            guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            Ten = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            ChuSoHuu = new DataGridViewTextBoxColumn();
            ThayDoi = new DataGridViewTextBoxColumn();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(4, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(382, 32);
            label1.TabIndex = 1;
            label1.Text = "Chào mừng bạn đến với DocMana";
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView2.ColumnHeadersHeight = 40;
            guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.Columns.AddRange(new DataGridViewColumn[] { Ten, LyDo, ChuSoHuu, ThayDoi });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView2.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.Location = new Point(17, 166);
            guna2DataGridView2.Margin = new Padding(3, 2, 3, 2);
            guna2DataGridView2.Name = "guna2DataGridView2";
            guna2DataGridView2.RowHeadersVisible = false;
            guna2DataGridView2.RowHeadersWidth = 51;
            guna2DataGridView2.RowTemplate.Height = 24;
            guna2DataGridView2.Size = new Size(893, 369);
            guna2DataGridView2.TabIndex = 9;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 40;
            guna2DataGridView2.ThemeStyle.ReadOnly = false;
            guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView2.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView2.ThemeStyle.RowsStyle.Height = 24;
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Ten
            // 
            Ten.HeaderText = "Tên";
            Ten.MinimumWidth = 10;
            Ten.Name = "Ten";
            // 
            // LyDo
            // 
            LyDo.HeaderText = "Lý do đề xuất";
            LyDo.MinimumWidth = 6;
            LyDo.Name = "LyDo";
            // 
            // ChuSoHuu
            // 
            ChuSoHuu.HeaderText = "Chủ sỡ hữu";
            ChuSoHuu.MinimumWidth = 6;
            ChuSoHuu.Name = "ChuSoHuu";
            // 
            // ThayDoi
            // 
            ThayDoi.HeaderText = "Ngày thay đổi gần nhất";
            ThayDoi.MinimumWidth = 6;
            ThayDoi.Name = "ThayDoi";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(325, 273);
            guna2DataGridView1.Margin = new Padding(3, 2, 3, 2);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 24;
            guna2DataGridView1.Size = new Size(210, 141);
            guna2DataGridView1.TabIndex = 8;
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
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.CustomizableEdges = customizableEdges1;
            textBoxSearch.DefaultText = "Tìm kiếm trong DocMana";
            textBoxSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearch.Font = new Font("Segoe UI", 9F);
            textBoxSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearch.IconRight = Properties.Resources.icons8_search_40;
            textBoxSearch.Location = new Point(224, 34);
            textBoxSearch.Margin = new Padding(4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PasswordChar = '\0';
            textBoxSearch.PlaceholderText = "";
            textBoxSearch.SelectedText = "";
            textBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textBoxSearch.Size = new Size(494, 32);
            textBoxSearch.TabIndex = 7;
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 64);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 83);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(17, 10);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 10;
            label2.Text = "Trang Chủ";
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(guna2DataGridView2);
            Controls.Add(guna2DataGridView1);
            Controls.Add(textBoxSearch);
            Controls.Add(panel1);
            Location = new Point(246, 100);
            Margin = new Padding(4);
            Name = "TrangChu";
            Size = new Size(927, 561);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private Label label2;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn LyDo;
        private DataGridViewTextBoxColumn ChuSoHuu;
        private DataGridViewTextBoxColumn ThayDoi;
    }
}
