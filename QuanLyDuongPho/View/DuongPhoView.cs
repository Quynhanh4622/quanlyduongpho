using System;
using QuanLyDuongPho.Controller;

namespace QuanLyDuongPho.View
{
    public class DuongPhoView
    {
        private DuongPhoController _duongPhoController = new DuongPhoController();
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Quản lý đường phố.");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Tạo mới đường phố.");
                Console.WriteLine("2. Hiển thị danh sách đường phố.");
                Console.WriteLine("3. Sửa thông tin.");
                Console.WriteLine("4. Xóa thông tin đường phố.");
                Console.WriteLine("5. Thóat chương trình.");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Vui long chon tu (1->5): ");
                int luachon = Convert.ToInt32(Console.ReadLine());
                switch (luachon)
                {
                    case 1: _duongPhoController.TaoDuongPho();
                        break;
                   case 2: _duongPhoController.HienThiDanhSachDuongPho();
                       break;
                   case 3: _duongPhoController.SuaThongTinDuongPho();
                       break;
                   case 4: _duongPhoController.XoaThongTinDuongPho();
                       break;
                   case 5: Console.WriteLine("Hẹn gặp lại ^-^");
                       break;
                   default:
                       Console.WriteLine("Lựa chọn sai, vui lòng nhập lại lựa chọn từ 1->5");
                       break;
                }

                Console.ReadLine();
                if (luachon == 5)
                {
                    break;
                }
            }
        }
    }
}