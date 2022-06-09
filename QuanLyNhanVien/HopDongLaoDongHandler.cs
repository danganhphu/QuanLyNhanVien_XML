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

            foreach (HopDongLaoDong hd in hopDongList)
            {
                hopDong = doc.CreateElement("HopDongLD");
                hdId = doc.CreateAttribute("MaHD");
                hdId.Value = hd.HdId;
                empId = doc.CreateAttribute("manv");
                empId.Value = hd.EmpId;
                hopDong.Attributes.Append(hdId);
                hopDong.Attributes.Append(empId);

                hdName = doc.CreateElement("TenHD");
                hdName.InnerText = hd.HdName;

                ngayBD = doc.CreateElement("NgayBD");
                ngayBD.InnerText = hd.NgayBD;

                ngayKT = doc.CreateElement("NgayKT");
                ngayKT.InnerText = hd.NgayKT;

                hopDong.AppendChild(hdName);
                hopDong.AppendChild(ngayBD);
                hopDong.AppendChild(ngayKT);
                company.AppendChild(hopDong);
            }
            doc.AppendChild(company); //them element congty vao tai lieu

            doc.Save(filename); //luu file
        }

        public bool add(HopDongLaoDong hd)
        {
            doc = new XmlDocument(); //Tao moi 1 doi tuong XmlDocument
            doc.Load(filename); //Load file xml theo duong dan
            hopDongList = new List<HopDongLaoDong>();
            loadDataFromDoc(doc, filename, hopDongList);
            if (isExistId(hopDongList, hd.HdId)) //Kiem tra da ton tai ma
                return false; //da ton tai tra ve false
            //Khong roi vao hai truong hop day ta di thuc hien them hop dong

            XmlElement hopDong, hdName, ngayBD, ngayKT;
            XmlAttribute hdId, empId;

            hopDong = doc.CreateElement("HopDongLD");
            hdId = doc.CreateAttribute("MaHD");
            hdId.Value = hd.HdId;
            empId = doc.CreateAttribute("manv");
            empId.Value = hd.EmpId;
            hopDong.Attributes.Append(hdId);
            hopDong.Attributes.Append(empId);

            hdName = doc.CreateElement("TenHD");
            hdName.InnerText = hd.HdName;

            ngayBD = doc.CreateElement("NgayBD");
            ngayBD.InnerText = hd.NgayBD.ToString();

            ngayKT = doc.CreateElement("NgayKT");
            ngayKT.InnerText = hd.NgayKT.ToString();

            hopDong.AppendChild(hdName);
            hopDong.AppendChild(ngayBD);
            hopDong.AppendChild(ngayKT);

            doc.DocumentElement.AppendChild(hopDong);

            doc.Save(filename);

            return true;
        }

        public bool edit(HopDongLaoDong hd)
        {
            doc = new XmlDocument();
            doc.Load(filename);
            hopDongList = new List<HopDongLaoDong>();
            loadDataFromDoc(doc, filename, hopDongList);
            if (!isExistId(hopDongList, hd.HdId)) //Kiem tra ma co ton tai hay khong
                return false; //Neu khong tra ve false

            XmlNodeList empNode = doc.GetElementsByTagName("HopDongLD");

            foreach (XmlNode node in empNode)
            {
                string hdId = node.Attributes["MaHD"].Value;

                if (hdId == hd.HdId)
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
            hopDongList = new List<HopDongLaoDong>();
            loadDataFromDoc(doc, filename, hopDongList);
            if (!isExistId(hopDongList, hdId)) //Kiem tra ma co ton tai hay khong
                return false; //Neu khong tra ve false

            XmlNodeList empNode = doc.GetElementsByTagName("HopDongLD");

            foreach (XmlNode node in empNode) //Duyet danh sach cac nut nhan vien
            {
                string id = node.Attributes["MaHD"].Value;

                if (id == hdId)
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
                string hdId;
                string empId;
                string hdName;
                string ngayBD;
                string ngayKT;

                hdId = node.Attributes["MaHD"].Value; //Lay thuoc tinh manv
                empId = node.Attributes["manv"].Value;

                hdName = node.ChildNodes[0].InnerText;

                ngayBD = node.ChildNodes[1].InnerText;

                ngayKT = node.ChildNodes[2].InnerText;

                HopDongLaoDong hd = new HopDongLaoDong(hdId, empId, hdName, ngayBD, ngayKT);

                hopDongList.Add(hd);
            }
        }

        public bool isExistId(List<HopDongLaoDong> hopDongList, string id)
        {
            bool isExist = false;//ban dau se cho la chua trung ma

            foreach (HopDongLaoDong hd in hopDongList)//Duyet tung hop dong trong danh sach
            {
                string hdId = hd.HdId;//lay ra id  hien tai
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