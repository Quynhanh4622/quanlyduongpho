using System;
using System.Text;
using QuanLyDuongPho.Controller;
using QuanLyDuongPho.Entity;
using QuanLyDuongPho.Model;
using QuanLyDuongPho.View;

namespace QuanLyDuongPho
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //var duongPho = new DuongPho();
            //var duongPhoModel = new DuongPhoModel();
            //duongPhoModel.Save(duongPho);
            // DuongPhoController duongPhoController = new DuongPhoController();
            // duongPhoController.TaoDuongPho();
            DuongPhoView duongPhoView = new DuongPhoView();
            duongPhoView.ShowMenu();
        }
    }
}