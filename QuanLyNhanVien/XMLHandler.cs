using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace QuanLyNhanVien
{
    internal class XMLHandler
    {
        private XmlDocument doc;
        private string filename = Directory.GetCurrentDirectory() + @"..\..\..\DuLieu\congty.xml";
        private List<NhanVien> empList;

        public void create(List<NhanVien> empList)
        {
            XmlNode decNode; //Khai bao nut khai bao tai lieu
            XmlElement company, employee, dept, empName, salary, deptName, deptTel;
            //Khai bao cac phan tu cua tai lieu
            XmlAttribute empId; //Khai bao thuoc tinh
            doc = new XmlDocument(); //Tao moi doi tuong XmlDocumnet

            decNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //Tao moi nut khai bao tai lieu
            doc.AppendChild(decNode);
            //Them nut khai bao vao tai lieu

            company = doc.CreateElement("congty");

            foreach (NhanVien emp in empList)//Duyet het cac nhan vien co trong danh sach
            {
                employee = doc.CreateElement("nhanvien"); //tao moi element nhanvien
                empId = doc.CreateAttribute("manv"); //tao moi thuoc tinh manv
                empId.Value = emp.EmpID; //gan gia tri cho thuoc tinh manv
                employee.Attributes.Append(empId); //them thuoc tinh manv vao nv

                empName = doc.CreateElement("hoten"); //tao moi element hoten
                empName.InnerText = emp.EmpName; //gan gia tri cho element hoten

                salary = doc.CreateElement("luong"); //tao moi element luong
                salary.InnerText = emp.Salary.ToString(); //gan gia tri cho element luong
                //vi luong nv la float nen can chuyen sang chuoi ta dung float.toString()

                dept = doc.CreateElement("phongban"); //Tao moi element phong ban

                deptName = doc.CreateElement("tenphong"); //tao moi element tenphong
                deptName.InnerText = emp.DeptName; //gan gia tri cho element tenphong

                deptTel = doc.CreateElement("dienthoai"); //tao moi element dienthoai
                deptTel.InnerText = emp.DeptTel; //gan gia tri cho dien thoai

                dept.AppendChild(deptName); //them element tenphong vao element phongban
                dept.AppendChild(deptTel); //them element dienthoai vao element phongban

                employee.AppendChild(empName); //them element hoten vao element nhanvien
                employee.AppendChild(salary); //them element luong vao element nhanvien
                employee.AppendChild(dept); //them element phongban vao element nhanvien

                company.AppendChild(employee); /*them element nhanvien vao element congty
                                                element congty chinh la nut goc(root) */
            }
            doc.AppendChild(company); //them element congty vao tai lieu

            doc.Save(filename); //luu file
        }

        public bool add(NhanVien emp)
        {
            doc = new XmlDocument(); //Tao moi 1 doi tuong XmlDocument
            doc.Load(filename); //Load file xml theo duong dan
            empList = new List<NhanVien>(); /*Tao moi 1 danh sach nhan vien de
                                            luu tru cac nhan vien */
            loadDataFromDoc(doc, filename, empList);
            if (isExistId(empList, emp.EmpID)) //Kiem tra da ton tai ma
                return false; //da ton tai tra ve false
            //Khong roi vao hai truong hop day ta di thuc hien them nhan vien

            XmlElement employee, dept, empName,
                        salary, deptName, deptTel;
            XmlAttribute empId;

            employee = doc.CreateElement("nhanvien"); //tao moi element nhanvien
            empId = doc.CreateAttribute("manv"); //tao moi thuoc tinh manv
            empId.Value = emp.EmpID; //gan gia tri cho thuoc tinh manv
            employee.Attributes.Append(empId); //them thuoc tinh manv vao nv

            empName = doc.CreateElement("hoten"); //tao moi element hoten
            empName.InnerText = emp.EmpName; //gan gia tri cho element hoten

            salary = doc.CreateElement("luong"); //tao moi element luong
            salary.InnerText = emp.Salary.ToString(); //gan gia tri cho element luong
                                                      //vi luong nv la float nen can chuyen sang chuoi ta dung float.toString()

            dept = doc.CreateElement("phongban"); //Tao moi element phong ban

            deptName = doc.CreateElement("tenphong"); //tao moi element tenphong
            deptName.InnerText = emp.DeptName; //gan gia tri cho element tenphong

            deptTel = doc.CreateElement("dienthoai"); //tao moi element dienthoai
            deptTel.InnerText = emp.DeptTel; //gan gia tri cho dien thoai

            dept.AppendChild(deptName); //them element tenphong vao element phongban
            dept.AppendChild(deptTel); //them element dienthoai vao element phongban

            employee.AppendChild(empName); //them element hoten vao element nhanvien
            employee.AppendChild(salary); //them element luong vao element nhanvien
            employee.AppendChild(dept); //them element phongban vao element nhanvien

            doc.DocumentElement.AppendChild(employee); //them nhan vien vao nut goc tai lieu
            //DocumneTelement la nut goc cua tai lieu

            doc.Save(filename);

            return true;
        }

        public bool edit(NhanVien emp)
        {
            doc = new XmlDocument(); //Tao moi 1 doi tuong XmlDocument
            doc.Load(filename); //Load file xml theo duong dan
            empList = new List<NhanVien>(); /*Tao moi 1 danh sach nhan vien de
                                            luu tru cac nhan vien */
            loadDataFromDoc(doc, filename, empList); /*Lay cac nhan vien tu tai lieu roi
                                                     them vao danh sach nhan vien vua tao */
            if (!isExistId(empList, emp.EmpID)) //Kiem tra ma co ton tai hay khong
                return false; //Neu khong tra ve false

            XmlNodeList empNode = doc.GetElementsByTagName("nhanvien");
            //Lay danh sach cac nut nahn vien tu tai lieu

            foreach (XmlNode node in empNode) //Duyet danh sach cac nut nhan vien
            {
                string empId = node.Attributes["manv"].Value;
                //Lay ra manv cua nut nhan vien hien tai
                if (empId == emp.EmpID) //Neu ma nv cua nut hien tai trung voi ma nv can sua
                {
                    //Thuc hien sua doi thong tin cua nut nay
                    node.ChildNodes[0].InnerText = emp.EmpName;
                    node.ChildNodes[1].InnerText = emp.Salary.ToString();
                    node.ChildNodes[2].ChildNodes[0].InnerText = emp.DeptName;
                    node.ChildNodes[2].ChildNodes[1].InnerText = emp.DeptTel;
                    break; //sau khi sua xong thoat luon vong lap
                }
            }

            doc.Save(filename); // Sau khi sua luu lai file

            return true; //tra ve true khi sua thanh cong
        }

        public bool delete(string empId)
        {
            doc = new XmlDocument(); //Tao moi 1 doi tuong XmlDocument
            doc.Load(filename); //Load file xml theo duong dan
            empList = new List<NhanVien>(); /*Tao moi 1 danh sach nhan vien de
                                            luu tru cac nhan vien */
            loadDataFromDoc(doc, filename, empList); /*Lay cac nhan vien tu tai lieu roi
                                                     them vao danh sach nhan vien vua tao */
            if (!isExistId(empList, empId)) //Kiem tra ma co ton tai hay khong
                return false; //Neu khong tra ve false

            XmlNodeList empNode = doc.GetElementsByTagName("nhanvien");
            //Lay danh sach cac nut nahn vien tu tai lieu

            foreach (XmlNode node in empNode) //Duyet danh sach cac nut nhan vien
            {
                string id = node.Attributes["manv"].Value;
                //Lay ra manv cua nut nhan vien hien tai
                if (id == empId) //Neu ma nv cua nut hien tai trung voi ma nv can sua
                {
                    doc.DocumentElement.RemoveChild(node);
                    break;
                }
            }

            doc.Save(filename);

            return true;
        }

        public void loadDataFromDoc(XmlDocument doc, string filename, List<NhanVien> empList)
        {
            doc = new XmlDocument(); //Tao moi mot doi tuong XmlDocumnent
            doc.Load(filename); //Load file theo duong dan
            XmlNodeList empNode = doc.GetElementsByTagName("nhanvien");
            //Lay ra cac nut co the ten la nhanvien
            foreach (XmlNode node in empNode) //Duyet tung nut
            {
                //Khai bao cac bien luu tri thong tin cua nhan vien
                string empId, empName, deptName, deptTel;
                float salary;

                empId = node.Attributes["manv"].Value; //Lay thuoc tinh manv
                empName = node.ChildNodes[0].InnerText;
                //Lay ra gia tri nut con cua nut nhanvien co index = 0
                salary = float.Parse(node.ChildNodes[1].InnerText);
                //Lay ra gia tri nut con cua nut nhanvien co index = 1
                deptName = node.ChildNodes[2].ChildNodes[0].InnerText;
                //Lay ra gia tri cua nut con (co index = 0) la nut con cua nhanvien(co index = 2)
                //nut con co index = 2 la phongban
                deptTel = node.ChildNodes[2].ChildNodes[1].InnerText;
                //Lay ra gia tri cua nut con (co index = 1) la nut con cua nhanvien(co index = 2)
                //nut con co index = 2 la phongban

                NhanVien e = new NhanVien(empId, empName, salary, deptName, deptTel);
                //Tao moi mot nhan vien co nhung gia tri vua lay dc
                empList.Add(e);// them vao danh sach nhan vien(empList)
            }
        }

        public bool isExistId(List<NhanVien> empList, string id)
        {
            bool isExist = false;//ban dau se cho la chua trung ma

            foreach (NhanVien emp in empList)//Duyet tung nhan vien trong danh sach
            {
                string empId = emp.EmpID;//lay ra id cua nhan vien hien tai
                if (empId.ToLower() == id.ToLower()) //chuyen sang chu thuong va so sanh
                {
                    //neu ma hai chuoi bang nhau
                    isExist = true; //trung ma
                    break; //thoat khoi vong lap
                }
            }

            return isExist;//tra ve ket qua
        }
    }
}