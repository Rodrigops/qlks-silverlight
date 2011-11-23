namespace Telerik.Reporting
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ProductSales.
    /// </summary>
    [Description("Crosstab summary of AdventureWorks sales, grouped by product category over a 4 year period.")]
    public partial class ProductSales : Telerik.Reporting.Report
    {
        public ProductSales()
        {
            /// <summary>
            /// Required for telerik Reporting designer support
            /// </summary>
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public static int Qtr(DateTime date)
        {
            return (1 + ((date.Month - 1) / 3));
        }
    }
}