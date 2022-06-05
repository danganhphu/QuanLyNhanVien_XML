using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class NhanVien
    {
        private string empID; //ma nhan vien
        private string empName; //ten nhan vien
        private float salary; //luong
        private string deptName; //ten phong ban
        private string deptTel; //so dt phong ban

        public NhanVien()
        {
        }

        public NhanVien(string empID, string empName, float salary, string deptName, string deptTel)
        {
            this.empID = empID;
            this.empName = empName;
            this.salary = salary;
            this.deptName = deptName;
            this.deptTel = deptTel;
        }

        public string EmpID { get => empID; set => empID = value; }
        public string EmpName { get => empName; set => empName = value; }
        public float Salary { get => salary; set => salary = value; }
        public string DeptName { get => deptName; set => deptName = value; }
        public string DeptTel { get => deptTel; set => deptTel = value; }
    }
}