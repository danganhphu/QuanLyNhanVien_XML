using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyNhanVien
{
    public partial class frmHopDongLaoDong : Form
    {
        public frmHopDongLaoDong()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            HopDongLaoDongHandler handler = new HopDongLaoDongHandler(); //Tao moi doi tuong XmlHandler
            XmlDocument doc = new XmlDocument(); //Tao moi doi tuong XmlDocument
            string filename = Directory.GetCurrentDirectory() + @"..\..\..\DaTa\congty.xml";
            //Duong dan toi file
            List<HopDongLaoDong> hopDongList = new List<HopDongLaoDong>();
            //Tao moi 1 danh sach luu tru cac nhan vien
            handler.loadDataFromDoc(doc, filename, hopDongList);
            //lay du lieu cac nhan vien tu file xml them vao danh sach nhan vien
            dgvInfor.Rows.Clear(); //xoa het du lieu cac dong
            int rowIndex = 0; //chi so cua dong cua bang
            foreach (HopDongLaoDong hd in hopDongList)
            {
                dgvInfor.Rows.Add(); //Them mot dong moi
                //chen du lieu vao bang
                dgvInfor.Rows[rowIndex].Cells[0].Value = hd.HdId;
                dgvInfor.Rows[rowIndex].Cells[1].Value = hd.EmpId;
                dgvInfor.Rows[rowIndex].Cells[2].Value = hd.HdName;
                dgvInfor.Rows[rowIndex].Cells[3].Value = hd.NgayBD;
                dgvInfor.Rows[rowIndex].Cells[4].Value = hd.NgayKT;

                rowIndex++;//Tang chi so cua cot len
            }
        }

        private bool notEmptyFields()
        {
            if (txthdID.Text.Trim() == "" || txtEmpId.Text.Trim() == "")
                return false;
            if (txthdName.Text.Trim() == "" || txthdNgayBD.Text.Trim() == "" || txthdNgayKT.Text.Trim() == "")
                return false;
            return true;
        }

        public void clearTextBox()
        {
            txthdID.Text = "";
            txtEmpId.Text = "";
            txthdName.Text = "";
            txthdNgayBD.Text = "";
            txthdNgayKT.Text = "";
        }

        private void dgvInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSeleted = dgvInfor.CurrentCell.RowIndex; //Lay ra dong hien tai dang duoc chon
            //hien thi cac thong tin o dong hien tai len o text box tuong ung
            txthdID.Text = (string)dgvInfor.Rows[rowSeleted].Cells[0].Value;
            txtEmpId.Text = (string)dgvInfor.Rows[rowSeleted].Cells[1].Value;
            txthdName.Text = (string)dgvInfor.Rows[rowSeleted].Cells[2].Value;
            txthdNgayBD.Text = (string)dgvInfor.Rows[rowSeleted].Cells[3].Value;
            txthdNgayKT.Text = (string)dgvInfor.Rows[rowSeleted].Cells[4].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HopDongLaoDongHandler handler = new HopDongLaoDongHandler();
            //Khai bao cac bien luu tru thong tin nhan vien do nguoi dung nhap
            string hdId, empId, hdName, ngayBD, ngayKT;
            try
            {
                //Lay ra cac gia tri
                hdId = txthdID.Text;
                empId = txtEmpId.Text;
                hdName = txthdName.Text;
                ngayBD = txthdNgayBD.Text;
                ngayKT = txthdNgayKT.Text;
                //Tao moi nhan vien co cac thong tin o tren
                if (!notEmptyFields()) //neu chua nhap day du thong tin
                    MessageBox.Show("Dữ liệu không được để trống", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    HopDongLaoDong hd = new HopDongLaoDong(hdId, empId, hdName, ngayBD, ngayKT);
                    if (!handler.add(hd)) //Neu them khong thanh cong
                        MessageBox.Show("Không thể thêm Mã hd đã có. Mã hd: " + hdId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else //Thanh cong
                    {
                        MessageBox.Show("Thêm thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi(); //load lai table
                        clearTextBox(); //xoa noi dung tren text box
                        txthdID.Focus(); //set focus vao o text box EmpId
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HopDongLaoDongHandler handler = new HopDongLaoDongHandler();
            //Khai bao cac bien luo tru thong tin nhan vien do nguoi dung nhap
            string hdId, empId, hdName, ngayBD, ngayKT;
            try
            {
                hdId = txthdID.Text;
                empId = txtEmpId.Text;
                hdName = txthdName.Text;
                ngayBD = txthdNgayBD.Text;
                ngayKT = txthdNgayKT.Text;
                //Tao moi nhan vien co cac thong tin o tren
                if (!notEmptyFields()) //neu chua nhap day du thong tin
                    MessageBox.Show("Dữ liệu không được để trống", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    HopDongLaoDong hd = new HopDongLaoDong(hdId, empId, hdName, ngayBD, ngayKT);
                    if (!handler.edit(hd)) //Neu sua khong thanh cong
                        MessageBox.Show("Mã hợp đồng: " + hdId + " không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else //Thanh cong
                    {
                        MessageBox.Show("Sửa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi(); //load lai table
                        clearTextBox(); //xoa noi dung tren text box
                        txthdID.Focus(); //set focus vao o text box hdId
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string hdId = txthdID.Text;
            if (hdId.Trim() == "")
                MessageBox.Show("Mã hợp đồng không được để trống", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                HopDongLaoDongHandler handler = new HopDongLaoDongHandler();
                if (!handler.delete(hdId)) //Neu xoa khong thanh cong
                    MessageBox.Show("Mã nhân viên: " + empId + " không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else //Thanh cong
                {
                    MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(); //load lai table
                    clearTextBox(); //xoa noi dung tren text box
                    txthdID.Focus(); //set focus vao o text box EmpId
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                Close();
        }
    }
}