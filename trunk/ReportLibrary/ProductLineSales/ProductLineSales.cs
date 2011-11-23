namespace Telerik.Reporting
{
    using System.ComponentModel;
    using System.Drawing;
    using Telerik.Reporting;
    using Telerik.Reporting.Data;
    using Telerik.Reporting.Drawing;
    using System.Data;
    using System.Data.SqlClient;
    using Processing = Telerik.Reporting.Processing;
    using System.Collections;
    using System.Text;
    using System;

    /// <summary>
    /// Summary description for ProductLineSales.
    /// </summary>
    [Description("Top ten best performing sales people and stores")]
    public partial class ProductLineSales : Report
    {
        public ProductLineSales()
        {
            /// <summary>
            /// Required for telerik Reporting designer support
            /// </summary>
            InitializeComponent();
        }

        public static string FormatArray(IList array)
        {
            StringBuilder sb = new StringBuilder();

            foreach (object o in array)
            {
                if (sb.Length > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(o.ToString());
            }

            return sb.ToString();
        }
    }
}

