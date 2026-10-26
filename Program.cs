using System;
using System.Windows.Forms;
using HotelManagement.DangNhap;

namespace HotelManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Hiện form đăng nhập trước; đăng nhập thành công (DialogResult.OK) mới mở form chính
            using (var formDangNhap = new FormDangNhap())
            {
                if (formDangNhap.ShowDialog() != DialogResult.OK)
                    return;
            }
            Application.Run(new FormMain());
        }
    }
}
