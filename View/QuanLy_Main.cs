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
    public partial class QuanLy_Main : Form
    {
        public QuanLy_Main()
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
            BtnQuanLyNhanVien.FillColor = Color.White;
            BtnQuanLyTruyCap.FillColor = Color.White;
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
            PhongBan phongban = new PhongBan();
            //phongban.switchToNhom += switchToNhom;
            phongban.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(phongban);
        }

        private void BtnQuanLyTruyCap_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnQuanLyTruyCap.FillColor = Color.DarkGray;

            pnlChinh.Controls.Clear();
            QuanLyQuyenTruyCap quanLyQuyenTruyCap = new QuanLyQuyenTruyCap();
            quanLyQuyenTruyCap.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(quanLyQuyenTruyCap);
        }

        private void BtnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnQuanLyNhanVien.FillColor = Color.DarkGray;
            pnlChinh.Controls.Clear();
            QuanLyNhanVien_CEO quanlynhanvien = new QuanLyNhanVien_CEO();
            quanlynhanvien.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(quanlynhanvien);
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

        private void QuanLy_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
