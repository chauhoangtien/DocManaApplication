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
using Services;
using Repositories.Model;

namespace View
{
    public partial class CEO_Main : Form
    {
        private string UserID;
        UserService userService = new UserService();

        public CEO_Main()
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

        private void ShowUserControl(UserControl uc)
        {
            pnlChinh.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(uc);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnTrangChu.FillColor = Color.DarkGray;
            TrangChu trangchu = new TrangChu();


            ShowUserControl(trangchu);
        }

        private void BtnThongBao_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnThongBao.FillColor = Color.DarkGray;
            ThongBao thongBao = new ThongBao();

            ShowUserControl(thongBao);
        }

        private void BtnDuAn_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnDuAn.FillColor = Color.DarkGray;
            DuAn duAn = new DuAn();
            duAn.SwitchToTaoDuAn += duAn_SwitchToTaoDuAn;
            duAn.SwitchToHoSo += duAn_SwitchToHoSo;

            ShowUserControl(duAn);
        }
        private void duAn_SwitchToTaoDuAn(object sender, EventArgs e)
        {
            TaoDuAn taoDuAn = new TaoDuAn();
            ShowUserControl(taoDuAn);
        }
        private void duAn_SwitchToHoSo(object sender, EventArgs e)
        {
            HoSo hoSo = new HoSo();
            hoSo.SwitchToTaoHoSo += hoSo_SwitchToTaoHoSo;
            hoSo.SwitchToTaiLieu += hoSo_SwitchToTaiLieu;
            ShowUserControl(hoSo);
        }
        private void hoSo_SwitchToTaoHoSo(object sender, EventArgs e)
        {
            TaoHoSo taoHoSo = new TaoHoSo();
            ShowUserControl(taoHoSo);
        }
        private void hoSo_SwitchToTaiLieu(object sender, EventArgs e)
        {
            TaiLieu taiLieu = new TaiLieu();
            taiLieu.SwitchToTaoTaiLieu += taiLieu_SwitchToTaoTaiLieu;
            ShowUserControl(taiLieu);
        }
        private void taiLieu_SwitchToTaoTaiLieu(object sender, EventArgs e)
        {
            TaoTailieu taoTailieu = new TaoTailieu();
            ShowUserControl(taoTailieu);
        }

        private void BtnPhongBan_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnPhongBan.FillColor = Color.DarkGray;
            PhongBan phongban = new PhongBan();

            phongban.SwitchToTaoPhongBan += phongBan_SwitchToTaoPhongBan;
            phongban.SwitchToNhom_CEO += phongBan_SwitchToNhom_CEO;

            ShowUserControl(phongban);
        }
        private void phongBan_SwitchToTaoPhongBan(object sender, EventArgs e)
        {
            TaoPhongBan taoPhongBan = new TaoPhongBan();
            ShowUserControl(taoPhongBan);
        }
        private void phongBan_SwitchToNhom_CEO(object sender, EventArgs e)
        {
            Nhom_CEO nhom_CEO = new Nhom_CEO();
            nhom_CEO.SwitchToTaoNhom += nhomCEO_SwitchToTaoNhom;
            nhom_CEO.SwitchToThemThanhVienVaoPhongBan += nhomCEO_SwitchToThemNhanVienVaoPhongBan;
            nhom_CEO.SwitchToTrongNhom += nhomCEO_SwitchToTrongNhom;

            ShowUserControl(nhom_CEO);
        }
        private void nhomCEO_SwitchToTaoNhom(object sender, EventArgs e)
        {
            TaoNhom taoNhom = new TaoNhom();
            ShowUserControl(taoNhom);
        }
        private void nhomCEO_SwitchToThemNhanVienVaoPhongBan(object sender, EventArgs e)
        {
            ThemNhanVienVaoPhongBan themNhanVienVaoPhongBan = new ThemNhanVienVaoPhongBan();
            ShowUserControl(themNhanVienVaoPhongBan);
        }
        private void nhomCEO_SwitchToTrongNhom(object sender, EventArgs e)
        {
            TrongNhom trongNhom = new TrongNhom();
            ShowUserControl(trongNhom);
        }

        private void BtnQuanLyTruyCap_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnQuanLyTruyCap.FillColor = Color.DarkGray;
            QuanLyQuyenTruyCap quanLyQuyenTruyCap = new QuanLyQuyenTruyCap();

            ShowUserControl(quanLyQuyenTruyCap);
        }

        private void BtnCaNhan_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnCaNhan.FillColor = Color.DarkGray;
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan();

            ShowUserControl(thongTinCaNhan);
        }

        private Image convertByteToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void CEO_Main_Load(object sender, EventArgs e)
        {
            UserID = Login.GlobalDataUserID.UserID;
            User user = userService.getUser(UserID);
            if (user != null)
            {
                labelUserName.Text = user.FullName;
                if (user.Avatar != null)
                {
                    BtnCaNhan.Image = convertByteToImage(user.Avatar);
                }
                else
                {
                    BtnCaNhan.Image = Properties.Resources.DefaultAvatar;
                }
            }
            else
            {
                MessageBox.Show("User is null");
            }

            TrangChu trangchu = new TrangChu();
            ShowUserControl(trangchu);
        }

        private void CEO_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BtnQuanLyNhanVien.FillColor = Color.DarkGray;
            QuanLyNhanVien_CEO quanlynhanvien = new QuanLyNhanVien_CEO();
            quanlynhanvien.SwitchToTaoNhanVien += quanLyNhanVien_SwitchToTaoNhanVien;
            ShowUserControl(quanlynhanvien);
        }
        private void quanLyNhanVien_SwitchToTaoNhanVien(object sender, EventArgs e)
        {
            TaoNhanVien taoNhanVien = new TaoNhanVien();
            ShowUserControl(taoNhanVien);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void translate(string textTranslate)
        {
            if(textTranslate.Equals("EN"))
            {
                btnTrangChu.Text = "Main";
                BtnThongBao.Text = "Notification";
                BtnDuAn.Text = "Project";
                BtnPhongBan.Text = "Department";
                BtnQuanLyTruyCap.Text = "Access Management";
                BtnQuanLyNhanVien.Text = "Employee Management";

                buttonTranslate.Text = "VN";
            }
            else
            {
                btnTrangChu.Text = "Trang chủ";
                BtnThongBao.Text = "Thông báo";
                BtnDuAn.Text = "Dự án";
                BtnPhongBan.Text = "Phòng ban";
                BtnQuanLyTruyCap.Text = "Quản lý quyền truy cập";
                BtnQuanLyNhanVien.Text = "Quản lý nhân viên";

                buttonTranslate.Text = "EN";
            }
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            translate(buttonTranslate.Text);
        }
    }
}
