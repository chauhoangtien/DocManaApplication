using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Usercontrol
{
    public partial class TrangChu : UserControl
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Tìm kiếm trong DocMana")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;  // Đổi màu chữ về bình thường
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Tìm kiếm trong DocMana";
                textBoxSearch.ForeColor = Color.Gray;  // Đổi màu chữ để thể hiện placeholder
            }
        }
    }
}
