using System;
using System.Collections.Generic;
using QuanLyDuongPho.Entity;
using QuanLyDuongPho.Model;

namespace QuanLyDuongPho.Controller
{
    public class DuongPhoController
    {
        private DuongPhoModel _duongPhoModel = new DuongPhoModel();
        public bool TaoDuongPho()
        {
            DuongPho duongPho = new DuongPho();
            Console.WriteLine("Vui lòng nhập mã: ");
            duongPho.Ma = Console.ReadLine();
            Console.WriteLine("Nhập tên đường: ");
            duongPho.Ten = Console.ReadLine();
            Console.WriteLine("Nhập mô tả: ");
            duongPho.MoTa = Console.ReadLine();
            Console.WriteLine("Nhập ngày sử dụng: ");
            duongPho.NgaySuDung = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lịch sử: ");
            duongPho.LichSu = Console.ReadLine();
            Console.WriteLine("Nhập tên quận: ");
            duongPho.TenQuan = Console.ReadLine();
            Console.WriteLine("Nhập trạng thái: ");
            duongPho.TrangThai = Convert.ToInt32(Console.ReadLine());
            return _duongPhoModel.Save(duongPho);
        }

        public void HienThiDanhSachDuongPho()
        {
            Console.WriteLine("Danh sách đường phố vừa nhập là: ");
            List<DuongPho> listDuongPho = _duongPhoModel.FindAll();
            for (var i = 0; i < listDuongPho.Count; i++)
            {
                var dp1 = listDuongPho[i];
                Console.WriteLine($"Mã: {dp1.Ma}, Tên: {dp1.Ten}, Mô tả: {dp1.MoTa}, Ngày sử dụng: {dp1.NgaySuDung}, Lịch sử: {dp1.LichSu}, Tên quận: {dp1.TenQuan}, Trạng thái: {dp1.TrangThai}");
            }
        }

        public void SuaThongTinDuongPho()
        {
            Console.WriteLine("Vui lòng nhập mã đường phố: ");
            var ma = Console.ReadLine();
            DuongPho dp = _duongPhoModel.FindById(ma);
            if (dp == null)
            {
                Console.WriteLine("Không tìm thấy đường phố cần sửa!");
                return;
            }
            Console.WriteLine("Nhập tên đường cần sửa: ");
            var ten = Console.ReadLine();
            dp.Ten = ten;
            Console.WriteLine("Nhập mô tả đường cần sửa: ");
            var moTa = Console.ReadLine();
            dp.MoTa = moTa;
            Console.WriteLine("Nhập ngày sử dụng đường cần sửa: ");
            var ngaySuDung = Convert.ToDateTime(Console.ReadLine());
            dp.NgaySuDung = ngaySuDung;
            Console.WriteLine("Nhập lịch sử đường cần sửa: ");
            var lichSu = Console.ReadLine();
            dp.LichSu = lichSu;
            Console.WriteLine("Nhập tên quận đường cần sửa: ");
            var tenQuan = Console.ReadLine();
            dp.TenQuan = tenQuan;
            Console.WriteLine("Nhập trạng thái đường cần sửa: ");
            var trangThai = Convert.ToInt32(Console.ReadLine());
            dp.TrangThai = trangThai;
        }

        public void XoaThongTinDuongPho()
        {
            Console.WriteLine("Vui lòng nhập mã đường phố cần xóa: ");
            var ma = Console.ReadLine();
            DuongPho dp = _duongPhoModel.FindById(ma);
            if (dp == null)
            {
                Console.WriteLine("Không tìm thấy đường phố cần xóa!");
                return;
            }

            Console.WriteLine($"Tìm thấy đường phố có mã: {dp.Ma},Tên là {dp.Ten}");
            Console.WriteLine("Bạn có chắc muốn xóa thông tin đường phố không (C/K)?");
            string luachon = Console.ReadLine();
            if (luachon.ToLower().Equals("C"))
            {
                bool result = _duongPhoModel.Delete(ma);
                if (result)
                {
                    Console.WriteLine("Xóa thành công.");
                }
                else
                {
                    Console.WriteLine("Xóa thất bại,vui lòng thử lại sau.");
                }
            }
        }
    }
}