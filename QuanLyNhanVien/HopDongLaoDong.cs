using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class HopDongLaoDong
    {
        private string hdId; //ma hdong
        private string empId; //ma nhan vien
        private string hdName; //ten nhan vien
        private string ngayBD; //luong
        private string ngayKT; //ten phong ban

        public HopDongLaoDong()
        {
        }

        public HopDongLaoDong(string hdId, string empId, string hdName, string ngayBD, string ngayKT)
        {
            this.hdId = hdId;
            this.empId = empId;
            this.hdName = hdName;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
        }

        public string HdId { get => hdId; set => hdId = value; }
        public string EmpId { get => empId; set => empId = value; }
        public string HdName { get => hdName; set => hdName = value; }
        public string NgayBD { get => ngayBD; set => ngayBD = value; }
        public string NgayKT { get => ngayKT; set => ngayKT = value; }
    }
}