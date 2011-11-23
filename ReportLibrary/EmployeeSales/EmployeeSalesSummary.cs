namespace Telerik.Reporting
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for EmployeeSalesSummary.
    /// </summary>
    [Description("Displays sales statistics for an individual employee per month")]
    public partial class EmployeeSalesSummary : Telerik.Reporting.Report
    {
        public EmployeeSalesSummary()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}