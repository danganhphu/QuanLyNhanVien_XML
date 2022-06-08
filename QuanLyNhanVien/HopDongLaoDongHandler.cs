using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyNhanVien
{
    internal class HopDongLaoDongHandler
    {
        //Hợp đồng lao động
        private XmlDocument doc;

        private string filename = Directory.GetCurrentDirectory() + @"..\..\..\Data\congty.xml";
        private List<HopDongLaoDong> hopDongList;

        public void create(List<HopDongLaoDong> hopDongList)
        {
            XmlNode decNode; //Khai bao nut khai bao tai lieu
            XmlElement company, hopDong, hdName, ngayBD, ngayKT;
            XmlAttribute hdId, empId; //Khai bao thuoc tinh
            doc = new XmlDocument(); //Tao moi doi tuong XmlDocumnet

            decNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //Tao moi nut khai bao tai lieu
            doc.AppendChild(decNode);
            //Them nut khai bao vao tai lieu

            company = doc.CreateElement("congty");

            foreach (HopDongLaoDong hd in hopDongList)//Duyet het cac nhan vien co trong danh sach
            {
                hopDong = doc.CreateElement("HopDongLD"); //tao moi element nhanvien
                hdId = doc.CreateAttribute("MaHD");
                hdId.Value = hd.HdId;
                empId = doc.CreateAttribute("manv"); //tao moi thuoc tinh manv
                empId.Value = hd.EmpId; //gan gia tri cho thuoc tinh mã nv
                hopDong.Attributes.Append(hdId);
                hopDong.Attributes.Append(empId); //them thuoc tinh manv vao nv

                hdName = doc.CreateElement("TenHD"); //tao moi element hoten
                hdName.InnerText = hd.HdName; //gan gia tri cho element hoten

                ngayBD = doc.CreateElement("NgayBD"); //tao moi element luong
                ngayBD.InnerText = hd.NgayBD; //gan gia tri cho element luong
                //vi luong nv la float nen can chuyen sang chuoi ta dung float.toString()

                ngayKT = doc.CreateElement("NgayKT"); //tao moi element luong
                ngayKT.InnerText = hd.NgayKT;

                hopDong.AppendChild(hdName); //them element hoten vao element nhanvien
                hopDong.AppendChild(ngayBD); //them element luong vao element nhanvien
                hopDong.AppendChild(ngayKT); //them element phongban vao element nhanvien

                company.AppendChild(hopDong); /*them element nhanvien vao element congty
                                                element congty chinh la nut goc(root) */
            }
            doc.AppendChild(company); //them element congty vao tai lieu

            doc.Save(filename); //luu file
        }

        public bool add(HopDongLaoDong hd)
        {
            doc = new XmlDocument(); //Tao moi 1 doi tuong XmlDocument
            doc.Load(filename); //Load file xml theo duong dan
            hopDongList = new List<HopDongLaoDong>(); /*Tao moi 1 danh sach nhan vien de
                                            luu tru cac nhan vien */
            loadDataFromDoc(doc, filename, hopDongList);
            if (isExistId(hopDongList, hd.HdId)) //Kiem tra da ton tai ma
                return false; //da ton tai tra ve false
            //Khong roi vao hai truong hop day ta di thuc hien them nhan vien

            XmlElement hopDong, hdName, ngayBD, ngayKT;
            XmlAttribute hdId, empId;

            hopDong = doc.CreateElement("HopDongLD"); //tao moi element nhanvien
            hdId = doc.CreateAttribute("MaHD");
            hdId.Value = hd.HdId;
            empId = doc.CreateAttribute("manv"); //tao moi thuoc tinh manv
            empId.Value = hd.EmpId; //gan gia tri cho thuoc tinh manv
            hopDong.Attributes.Append(hdId);
            hopDong.Attributes.Append(empId); //them thuoc tinh manv vao nv

            hdName = doc.CreateElement("TenHD"); //tao moi element hoten
            hdName.InnerText = hd.HdName; //gan gia tri cho element hoten

            ngayBD = doc.CreateElement("NgayBD"); //tao moi element luong
            ngayBD.InnerText = hd.NgayBD.ToString(); //gan gia tri cho element luong
                                                     //vi luong nv la float nen can chuyen sang chuoi ta dung float.toString()

            ngayKT = doc.CreateElement("NgayKT"); //tao moi element luong
            ngayKT.InnerText = hd.NgayKT.ToString();

            hopDong.AppendChild(hdName); //them element hoten vao element nhanvien
            hopDong.AppendChild(ngayBD); //them element luong vao element nhanvien
            hopDong.AppendChild(ngayKT); //them element phongban vao element nhanvien

            doc.DocumentElement.AppendChild(hopDong); //them nhan vien vao nut goc tai lieu
            //DocumneTelement la nut goc cua tai lieu

            doc.Save(filename);

            return true;
        }

        public bool edit(HopDongLaoDong hd)
        {
            doc = new XmlDocument(); //Tao moi 1 doi tuong XmlDocument
            doc.Load(filename); //Load file xml theo duong dan
            hopDongList = new List<HopDongLaoDong>(); /*Tao moi 1 danh sach nhan vien de
                                            luu tru cac nhan vien */
            loadDataFromDoc(doc, filename, hopDongList); /*Lay cac nhan vien tu tai lieu roi
                                                     them vao danh sach nhan vien vua tao */
            if (!isExistId(hopDongList, hd.HdId)) //Kiem tra ma co ton tai hay khong
                return false; //Neu khong tra ve false

            XmlNodeList empNode = doc.GetElementsByTagName("HopDongLD");
            //Lay danh sach cac nut nahn vien tu tai lieu

            foreach (XmlNode node in empNode)
            {
                string hdId = node.Attributes["MaHD"].Value;
                //Lay ra manv cua nut nhan vien hien tai
                if (hdId == hd.HdId) //Neu ma nv cua nut hien tai trung voi ma nv can sua
                {
                    //Thuc hien sua doi thong tin cua nut nay
                    node.Attributes["manv"].Value = hd.EmpId;
                    node.ChildNodes[0].InnerText = hd.HdName;
                    node.ChildNodes[1].InnerText = hd.NgayBD;
                    node.ChildNodes[2].InnerText = hd.NgayKT;
                    break; //sau khi sua xong thoat luon vong lap
                }
            }

            doc.Save(filename); // Sau khi sua luu lai file

            return true; //tra ve true khi sua thanh cong
        }

        public bool delete(string hdId)
        {
            doc = new XmlDocument(); //Tao moi 1 doi tuong XmlDocument
            doc.Load(filename); //Load file xml theo duong dan
            hopDongList = new List<HopDongLaoDong>(); /*Tao moi 1 danh sach nhan vien de
                                            luu tru cac nhan vien */
            loadDataFromDoc(doc, filename, hopDongList); /*Lay cac nhan vien tu tai lieu roi
                                                     them vao danh sach nhan vien vua tao */
            if (!isExistId(hopDongList, hdId)) //Kiem tra ma co ton tai hay khong
                return false; //Neu khong tra ve false

            XmlNodeList empNode = doc.GetElementsByTagName("HopDongLD");
            //Lay danh sach cac nut nahn vien tu tai lieu

            foreach (XmlNode node in empNode) //Duyet danh sach cac nut nhan vien
            {
                string id = node.Attributes["MaHD"].Value;
                //Lay ra manv cua nut nhan vien hien tai
                if (id == hdId) //Neu ma nv cua nut hien tai trung voi ma nv can sua
                {
                    doc.DocumentElement.RemoveChild(node);
                    break;
                }
            }

            doc.Save(filename);

            return true;
        }

        public void loadDataFromDoc(XmlDocument doc, string filename, List<HopDongLaoDong> hopDongList)
        {
            doc = new XmlDocument(); //Tao moi mot doi tuong XmlDocumnent
            doc.Load(filename); //Load file theo duong dan
            XmlNodeList empNode = doc.GetElementsByTagName("HopDongLD");
            //Lay ra cac nut co the ten la nhanvien
            foreach (XmlNode node in empNode) //Duyet tung nut
            {
                //Khai bao cac bien luu tri thong tin cua nhan vien
                string hdId; //ma hdong
                string empId; //ma nhan vien
                string hdName; //ten nhan vien
                string ngayBD; //luong
                string ngayKT; //ten phong ban

                hdId = node.Attributes["MaHD"].Value; //Lay thuoc tinh manv
                empId = node.Attributes["manv"].Value;

                hdName = node.ChildNodes[0].InnerText;
                //Lay ra gia tri nut con cua nut nhanvien co index = 0
                ngayBD = node.ChildNodes[1].InnerText;
                //Lay ra gia tri nut con cua nut nhanvien co index = 1
                ngayKT = node.ChildNodes[2].InnerText;

                HopDongLaoDong hd = new HopDongLaoDong(hdId, empId, hdName, ngayBD, ngayKT);
                //Tao moi mot nhan vien co nhung gia tri vua lay dc
                hopDongList.Add(hd);
            }
        }

        public bool isExistId(List<HopDongLaoDong> hopDongList, string id)
        {
            bool isExist = false;//ban dau se cho la chua trung ma

            foreach (HopDongLaoDong hd in hopDongList)//Duyet tung nhan vien trong danh sach
            {
                string hdId = hd.HdId;//lay ra id cua nhan vien hien tai
                if (hdId.ToLower() == id.ToLower()) //chuyen sang chu thuong va so sanh
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