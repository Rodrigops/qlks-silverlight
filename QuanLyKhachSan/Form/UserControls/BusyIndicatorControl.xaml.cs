using System.Windows.Controls;

namespace QuanLyKhachSan.UserControls
{
    public partial class BusyIndicatorControl : ChildWindow
    {
        string _BusyText;
        public string BusyText
        {
            get
            {
                return _BusyText;
            }
            set
            {
                _BusyText = value;
                RadBusyControl.BusyContent = _BusyText;
            }
        }

        public BusyIndicatorControl()
        {
            InitializeComponent();
        }

    }
}

