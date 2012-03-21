using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using QuanLyKhachSan.UserControls;

namespace QuanLyKhachSan.Libs.Common
{

    public class Common
    {
        private static BusyIndicatorControl bicCommonIndicator = new BusyIndicatorControl();
        public static void ShowBusyIndicator(string busyText = "")
        {
            if (string.IsNullOrWhiteSpace(busyText)) busyText = "Đang xử lý.Vui lòng chờ...";
            bicCommonIndicator.BusyText = busyText;
            bicCommonIndicator.Show();
        }

        public static void CloseBusyIndicator()
        {
            bicCommonIndicator.Close();
        }
    }
}
