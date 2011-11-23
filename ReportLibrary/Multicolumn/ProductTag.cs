namespace Telerik.Reporting
{
    using System;
    using System.ComponentModel;
    using System.Drawing;

    /// <summary>
    /// A report for printing business cards.
    /// </summary>
    [Description("Printable product tags arranged in a newspaper-style columns")]
    public partial class ProductTagReport : Report
    {
        public ProductTagReport()
        {
            /// <summary>
            /// Required for Telerik Reporting designer support
            /// </summary>
            InitializeComponent();
        }
    }    
}

