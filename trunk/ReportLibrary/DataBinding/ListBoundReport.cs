namespace Telerik.Reporting
{
    using System.Collections.Generic;
    using System.ComponentModel;
	using System.Collections;

    /// <summary>
    /// Demonstrates binding to an IList.
    /// </summary>
    [Description("Displays data from a set of Business Objects")]
    public partial class ListBoundReport : Report
    {
        public ListBoundReport()
        {
            /// <summary>
            /// Required for Telerik Reporting designer support
            /// </summary>
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

		public static bool IsColorInStock(string color, ArrayList availableColors)
		{
			return availableColors.Contains(color);
		}
    }
}