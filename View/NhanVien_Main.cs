using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Usercontrol;

namespace View
{
    public partial class NhanVien_Main : Form
    {
        public NhanVien_Main()
        {
            InitializeComponent();
        }
        private void ResetButtonColors()
        {
            BtnCaNhan.FillColor = Color.White;
            BtnThongBao.FillColor = Color.White;
            btnTrangChu.FillColor = Color.White;
            BtnDuAn.FillColor = Color.White;
            BtnPhongBan.FillColor = Color.White;

        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnTrangChu.FillColor = Color.DarkGray;


            pnlChinh.Controls.Clear();
            TrangChu trangchu = new TrangChu();
            trangchu.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(trangchu);
        }

        private void BtnThongBao_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnThongBao.FillColor = Color.DarkGray;

            pnlChinh.Controls.Clear();
            ThongBao thongBao = new ThongBao();
            thongBao.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(thongBao);
        }

        private void BtnDuAn_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnDuAn.FillColor = Color.DarkGray;

            pnlChinh.Controls.Clear();
            HoSo hoSo = new HoSo();
            //hoSo.switchToTaiLieu += switchToTaiLieu;
            hoSo.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(hoSo);
        }

        private void BtnPhongBan_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnPhongBan.FillColor = Color.DarkGray;


            pnlChinh.Controls.Clear();
            PhongBan_NhanVien phongban = new PhongBan_NhanVien();
            //phongban.switchToNhom += switchToNhom;
            phongban.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(phongban);
        }

        private void BtnCaNhan_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnCaNhan.FillColor = Color.DarkGray;

            pnlChinh.Controls.Clear();
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan();
            thongTinCaNhan.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(thongTinCaNhan);
        }
    }
}
