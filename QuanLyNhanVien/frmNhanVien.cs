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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            XMLHandler handler = new XMLHandler(); //Tao moi doi tuong XmlHandler
            XmlDocument doc = new XmlDocument(); //Tao moi doi tuong XmlDocument
            string filename = Directory.GetCurrentDirectory() + @"..\..\..\Data\congty.xml";
            //Duong dan toi file
            List<NhanVien> empList = new List<NhanVien>();
            //Tao moi 1 danh sach luu tru cac nhan vien
            handler.loadDataFromDoc(doc, filename, empList);
            //lay du lieu cac nhan vien tu file xml them vao danh sach nhan vien
            dgvInfor.Rows.Clear(); //xoa het du lieu cac dong
            int rowIndex = 0; //chi so cua dong cua bang
            foreach (NhanVien emp in empList)
            {
                dgvInfor.Rows.Add(); //Them mot dong moi
                //chen du lieu vao bang
                dgvInfor.Rows[rowIndex].Cells[0].Value = emp.EmpID;
                dgvInfor.Rows[rowIndex].Cells[1].Value = emp.EmpName;
                dgvInfor.Rows[rowIndex].Cells[2].Value = emp.Salary;
                dgvInfor.Rows[rowIndex].Cells[3].Value = emp.DeptName;
                dgvInfor.Rows[rowIndex].Cells[4].Value = emp.DeptTel;

                rowIndex++;//Tang chi so cua cot len
            }
        }

        private bool notEmptyFields()
        {
            if (txtEmpId.Text.Trim() == "" || txtEmpName.Text.Trim() == "")
                return false;
            if (txtSalary.Text.Trim() == "" || txtDeptName.Text.Trim() == "")
                return false;
            if (lblDeptTel.Text.Trim() == "")
                return false;
            return true;
        }

        public void clearTextBox()
        {
            txtEmpId.Text = "";
            txtEmpName.Text = "";
            txtSalary.Text = "";
            txtDeptName.Text = "";
            txtDeptTel.Text = "";
        }

        private void dgvInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSeleted = dgvInfor.CurrentCell.RowIndex; //Lay ra dong hien tai dang duoc chon
            //hien thi cac thong tin o dong hien tai len o text box tuong ung
            txtEmpId.Text = (string)dgvInfor.Rows[rowSeleted].Cells[0].Value;
            txtEmpName.Text = (string)dgvInfor.Rows[rowSeleted].Cells[1].Value;
            float salary = (float)dgvInfor.Rows[rowSeleted].Cells[2].Value;
            txtSalary.Text = salary.ToString();
            txtDeptName.Text = (string)dgvInfor.Rows[rowSeleted].Cells[3].Value;
            txtDeptTel.Text = (string)dgvInfor.Rows[rowSeleted].Cells[4].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XMLHandler handler = new XMLHandler();
            //Khai bao cac bien luu tru thong tin nhan vien do nguoi dung nhap
            string empId, empName, deptName, deptTel;
            float salary;
            try
            {
                //Lay ra cac gia tri
                empId = txtEmpId.Text;
                empName = txtEmpName.Text;
                salary = float.Parse(txtSalary.Text);
                deptName = txtDeptName.Text;
                deptTel = txtDeptTel.Text;
                //Tao moi nhan vien co cac thong tin o tren
                if (!notEmptyFields()) //neu chua nhap day du thong tin
                    MessageBox.Show("Dữ liệu không được để trống", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    NhanVien emp = new NhanVien(empId, empName, salary, deptName, deptTel);
                    if (!handler.add(emp)) //Neu them khong thanh cong
                        MessageBox.Show("Không thể thêm Mã NV đã có. Mã NV: " + empId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else //Thanh cong
                    {
                        MessageBox.Show("Thêm thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi(); //load lai table
                        clearTextBox(); //xoa noi dung tren text box
                        txtEmpId.Focus(); //set focus vao o text box EmpId
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
            XMLHandler handler = new XMLHandler();
            //Khai bao cac bien luo tru thong tin nhan vien do nguoi dung nhap
            string empId, empName, deptName, deptTel;
            float salary;
            try
            {
                //Lay ra cac gia tri
                empId = txtEmpId.Text;
                empName = txtEmpName.Text;
                salary = float.Parse(txtSalary.Text);
                deptName = txtDeptName.Text;
                deptTel = txtDeptTel.Text;
                //Tao moi nhan vien co cac thong tin o tren
                if (!notEmptyFields()) //neu chua nhap day du thong tin
                    MessageBox.Show("Dữ liệu không được để trống", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    NhanVien emp = new NhanVien(empId, empName, salary, deptName, deptTel);
                    if (!handler.edit(emp)) //Neu sua khong thanh cong
                        MessageBox.Show("Mã nhân viên: " + empId + " không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else //Thanh cong
                    {
                        MessageBox.Show("Sửa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi(); //load lai table
                        clearTextBox(); //xoa noi dung tren text box
                        txtEmpId.Focus(); //set focus vao o text box EmpId
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
            string empId = txtEmpId.Text;
            if (empId.Trim() == "")
                MessageBox.Show("Mã nhân viên không được để trống", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                XMLHandler handler = new XMLHandler();
                if (!handler.delete(empId)) //Neu xoa khong thanh cong
                    MessageBox.Show("Mã nhân viên: " + empId + " không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else //Thanh cong
                {
                    MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(); //load lai table
                    clearTextBox(); //xoa noi dung tren text box
                    txtEmpId.Focus(); //set focus vao o text box EmpId
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHopDongLaoDong frmHDLD = new frmHopDongLaoDong();
            frmHDLD.Show();
        }
    }
}