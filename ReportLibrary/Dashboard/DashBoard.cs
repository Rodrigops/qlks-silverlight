namespace Telerik.Reporting
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Summary description for DashBoard.
    /// </summary>
    [Description("Performance overview of the AdventureWorks Sales Department")]
    public partial class DashBoard : Telerik.Reporting.Report
    {
        public DashBoard()
        {
            /// <summary>
            /// Required for telerik Reporting designer support
            /// </summary>
            InitializeComponent();
        }

        public static int Qtr(DateTime date)
        {
            return (1 + ((date.Month - 1) / 3));
        }
    }
}