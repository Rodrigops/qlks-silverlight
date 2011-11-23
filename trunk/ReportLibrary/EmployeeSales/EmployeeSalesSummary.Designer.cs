namespace Telerik.Reporting
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    partial class EmployeeSalesSummary
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.NavigateToReportAction navigateToReportAction1 = new Telerik.Reporting.NavigateToReportAction();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSalesSummary));
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup6 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup7 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup8 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup9 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup10 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup11 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup12 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.Charting.Styles.ChartMargins chartMargins1 = new Telerik.Reporting.Charting.Styles.ChartMargins();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem1 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem2 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem3 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem4 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem5 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem6 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem7 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartSeries chartSeries1 = new Telerik.Reporting.Charting.ChartSeries();
            Telerik.Reporting.Charting.ChartSeries chartSeries2 = new Telerik.Reporting.Charting.ChartSeries();
            Telerik.Reporting.Charting.ChartSeries chartSeries3 = new Telerik.Reporting.Charting.ChartSeries();
            Telerik.Reporting.Charting.ChartSeries chartSeries4 = new Telerik.Reporting.Charting.ChartSeries();
            Telerik.Reporting.Charting.Styles.ChartMargins chartMargins2 = new Telerik.Reporting.Charting.Styles.ChartMargins();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem8 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem9 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem10 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem11 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem12 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem13 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartAxisItem chartAxisItem14 = new Telerik.Reporting.Charting.ChartAxisItem();
            Telerik.Reporting.Charting.ChartSeries chartSeries5 = new Telerik.Reporting.Charting.ChartSeries();
            Telerik.Reporting.Charting.ChartSeries chartSeries6 = new Telerik.Reporting.Charting.ChartSeries();
            Telerik.Reporting.Charting.ChartSeries chartSeries7 = new Telerik.Reporting.Charting.ChartSeries();
            Telerik.Reporting.Charting.ChartSeries chartSeries8 = new Telerik.Reporting.Charting.ChartSeries();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            this.textBoxTableTitle = new Telerik.Reporting.TextBox();
            this.textBoxCategoryAmount = new Telerik.Reporting.TextBox();
            this.textBoxCategory = new Telerik.Reporting.TextBox();
            this.textBoxSalesOrderNumber = new Telerik.Reporting.TextBox();
            this.textBoxOrderTotal = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBoxEmployeeSalesTotal = new Telerik.Reporting.TextBox();
            this.textBoxTotalLabel = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.SalesEmployees = new Telerik.Reporting.SqlDataSource();
            this.detail = new Telerik.Reporting.DetailSection();
            this.crosstabEmployeeSales = new Telerik.Reporting.Crosstab();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.EmployeeSales = new Telerik.Reporting.SqlDataSource();
            this.panelWrapper = new Telerik.Reporting.Panel();
            this.chartYearlySales = new Telerik.Reporting.Chart();
            this.EmployeeSalesYearOverYear = new Telerik.Reporting.SqlDataSource();
            this.chartMonthlySales = new Telerik.Reporting.Chart();
            this.EmployeeCategorySales = new Telerik.Reporting.SqlDataSource();
            this.group1 = new Telerik.Reporting.Group();
            this.groupFooterSection1 = new Telerik.Reporting.GroupFooterSection();
            this.groupHeaderSection1 = new Telerik.Reporting.GroupHeaderSection();
            this.pictureBoxLogo = new Telerik.Reporting.PictureBox();
            this.textBoxLogo = new Telerik.Reporting.TextBox();
            this.textBoxDataRange = new Telerik.Reporting.TextBox();
            this.textBoxReportEmployee = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // textBoxTableTitle
            // 
            this.textBoxTableTitle.Name = "textBoxTableTitle";
            this.textBoxTableTitle.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.8972222805023193D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23702292144298554D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxTableTitle.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.textBoxTableTitle.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBoxTableTitle.Style.Color = System.Drawing.Color.White;
            this.textBoxTableTitle.Style.Font.Bold = true;
            this.textBoxTableTitle.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBoxTableTitle.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxTableTitle.Value = "{Parameters.ReportDate.Value.ToString(\"MMMM yyyy\")} Order Summary";
            // 
            // textBoxCategoryAmount
            // 
            this.textBoxCategoryAmount.Format = "{0:N2}";
            this.textBoxCategoryAmount.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(2.9000003337860107D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(1.4000000953674316D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxCategoryAmount.Name = "textBoxCategoryAmount";
            this.textBoxCategoryAmount.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.77916651964187622D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20610688626766205D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxCategoryAmount.Style.Font.Bold = true;
            this.textBoxCategoryAmount.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxCategoryAmount.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxCategoryAmount.Value = "=Sum(Fields.Sales)";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.0590277910232544D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20610688626766205D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxCategory.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBoxCategory.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxCategory.Value = "=Fields.Category";
            // 
            // textBoxSalesOrderNumber
            // 
            navigateToReportAction1.Parameters.Add(new Telerik.Reporting.Parameter("OrderNumber", "=Fields.SalesOrderNumber"));
            navigateToReportAction1.Parameters.Add(new Telerik.Reporting.Parameter("ForYear", "=Parameters.ReportDate.Value.Year"));
            navigateToReportAction1.Parameters.Add(new Telerik.Reporting.Parameter("ForMonth", "=Parameters.ReportDate.Value.Month"));
            navigateToReportAction1.ReportDocumentType = "Telerik.Reporting.Examples.CSharp.Invoice, CSharp.ReportLibrary, Version=1.0.0.0," +
                " Culture=neutral, PublicKeyToken=null";
            this.textBoxSalesOrderNumber.Action = navigateToReportAction1;
            this.textBoxSalesOrderNumber.Name = "textBoxSalesOrderNumber";
            this.textBoxSalesOrderNumber.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.0590277910232544D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20610688626766205D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxSalesOrderNumber.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBoxSalesOrderNumber.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.textBoxSalesOrderNumber.Style.Font.Underline = true;
            this.textBoxSalesOrderNumber.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.textBoxSalesOrderNumber.Value = "=Fields.SalesOrderNumber";
            // 
            // textBoxOrderTotal
            // 
            this.textBoxOrderTotal.Format = "{0:N2}";
            this.textBoxOrderTotal.Name = "textBoxOrderTotal";
            this.textBoxOrderTotal.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.77916651964187622D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20999999344348908D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxOrderTotal.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(227)))));
            this.textBoxOrderTotal.Style.Font.Bold = true;
            this.textBoxOrderTotal.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxOrderTotal.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxOrderTotal.Value = "=Sum(Fields.Sales)";
            // 
            // textBox4
            // 
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.0590277910232544D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20999999344348908D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBox4.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(227)))));
            this.textBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            // 
            // textBox12
            // 
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.0590277910232544D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20999999344348908D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBox12.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(227)))));
            // 
            // textBoxEmployeeSalesTotal
            // 
            this.textBoxEmployeeSalesTotal.Format = "{0:N2}";
            this.textBoxEmployeeSalesTotal.Name = "textBoxEmployeeSalesTotal";
            this.textBoxEmployeeSalesTotal.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.77916651964187622D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20999999344348908D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxEmployeeSalesTotal.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBoxEmployeeSalesTotal.Style.Font.Bold = true;
            this.textBoxEmployeeSalesTotal.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxEmployeeSalesTotal.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxEmployeeSalesTotal.Value = "=Sum(Fields.Sales)";
            // 
            // textBoxTotalLabel
            // 
            this.textBoxTotalLabel.Name = "textBoxTotalLabel";
            this.textBoxTotalLabel.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.0590277910232544D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20999999344348908D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxTotalLabel.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBoxTotalLabel.Style.Font.Bold = true;
            this.textBoxTotalLabel.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxTotalLabel.Value = "Total:";
            // 
            // textBox10
            // 
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.0590277910232544D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20999999344348908D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            // 
            // SalesEmployees
            // 
            this.SalesEmployees.ConnectionString = "Telerik.Reporting.Examples.CSharp.Properties.Settings.TelerikConnectionString";
            this.SalesEmployees.Name = "SalesEmployees";
            this.SalesEmployees.SelectCommand = resources.GetString("SalesEmployees.SelectCommand");
            // 
            // detail
            // 
            this.detail.Height = new Telerik.Reporting.Drawing.Unit(6.1999602317810059D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.crosstabEmployeeSales,
            this.panelWrapper});
            this.detail.KeepTogether = false;
            this.detail.Name = "detail";
            // 
            // crosstabEmployeeSales
            // 
            this.crosstabEmployeeSales.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstabEmployeeSales.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(new Telerik.Reporting.Drawing.Unit(0.23702292144298554D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstabEmployeeSales.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(new Telerik.Reporting.Drawing.Unit(0.20610688626766205D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstabEmployeeSales.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(new Telerik.Reporting.Drawing.Unit(0.20999999344348908D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstabEmployeeSales.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(new Telerik.Reporting.Drawing.Unit(0.20999999344348908D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstabEmployeeSales.Body.SetCellContent(1, 0, this.textBox6);
            this.crosstabEmployeeSales.Body.SetCellContent(0, 0, this.textBox5);
            this.crosstabEmployeeSales.Body.SetCellContent(2, 0, this.textBox9);
            this.crosstabEmployeeSales.Body.SetCellContent(3, 0, this.textBox13);
            this.crosstabEmployeeSales.ColumnGroups.Add(tableGroup1);
            this.crosstabEmployeeSales.DataSource = this.EmployeeSales;
            this.crosstabEmployeeSales.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox6,
            this.textBox5,
            this.textBox9,
            this.textBox13,
            this.textBoxTableTitle,
            this.textBoxSalesOrderNumber,
            this.textBoxCategory,
            this.textBoxCategoryAmount,
            this.textBox12,
            this.textBox4,
            this.textBoxOrderTotal,
            this.textBox10,
            this.textBoxTotalLabel,
            this.textBoxEmployeeSalesTotal});
            this.crosstabEmployeeSales.KeepTogether = false;
            this.crosstabEmployeeSales.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.1000000610947609D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.crosstabEmployeeSales.Name = "crosstabEmployeeSales";
            tableGroup2.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("1")});
            tableGroup2.Name = "RowGroup";
            tableGroup2.ReportItem = this.textBoxTableTitle;
            tableGroup2.Sortings.AddRange(new Telerik.Reporting.Data.Sorting[] {
            new Telerik.Reporting.Data.Sorting("1", Telerik.Reporting.Data.SortDirection.Asc)});
            tableGroup6.Name = "Detail";
            tableGroup6.ReportItem = this.textBoxCategoryAmount;
            tableGroup5.ChildGroups.Add(tableGroup6);
            tableGroup5.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("=Fields.Category")});
            tableGroup5.Name = "Category";
            tableGroup5.ReportItem = this.textBoxCategory;
            tableGroup5.Sortings.AddRange(new Telerik.Reporting.Data.Sorting[] {
            new Telerik.Reporting.Data.Sorting("=Fields.Category", Telerik.Reporting.Data.SortDirection.Asc)});
            tableGroup4.ChildGroups.Add(tableGroup5);
            tableGroup4.Name = "Group6";
            tableGroup4.ReportItem = this.textBoxSalesOrderNumber;
            tableGroup9.Name = "Group2";
            tableGroup9.ReportItem = this.textBoxOrderTotal;
            tableGroup8.ChildGroups.Add(tableGroup9);
            tableGroup8.Name = "Group1";
            tableGroup8.ReportItem = this.textBox4;
            tableGroup7.ChildGroups.Add(tableGroup8);
            tableGroup7.Name = "Group7";
            tableGroup7.ReportItem = this.textBox12;
            tableGroup3.ChildGroups.Add(tableGroup4);
            tableGroup3.ChildGroups.Add(tableGroup7);
            tableGroup3.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("=Fields.SalesOrderNumber")});
            tableGroup3.Name = "SalesOrderNumber";
            tableGroup3.Sortings.AddRange(new Telerik.Reporting.Data.Sorting[] {
            new Telerik.Reporting.Data.Sorting("=Fields.SalesOrderNumber", Telerik.Reporting.Data.SortDirection.Asc)});
            tableGroup12.Name = "Group4";
            tableGroup12.ReportItem = this.textBoxEmployeeSalesTotal;
            tableGroup11.ChildGroups.Add(tableGroup12);
            tableGroup11.Name = "Group5";
            tableGroup11.ReportItem = this.textBoxTotalLabel;
            tableGroup10.ChildGroups.Add(tableGroup11);
            tableGroup10.Name = "Group3";
            tableGroup10.ReportItem = this.textBox10;
            this.crosstabEmployeeSales.RowGroups.Add(tableGroup2);
            this.crosstabEmployeeSales.RowGroups.Add(tableGroup3);
            this.crosstabEmployeeSales.RowGroups.Add(tableGroup10);
            this.crosstabEmployeeSales.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.8972222805023193D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.86312979459762573D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.crosstabEmployeeSales.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            // 
            // textBox6
            // 
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20610688626766205D, Telerik.Reporting.Drawing.UnitType.Inch));
            // 
            // textBox5
            // 
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23702292144298554D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            // 
            // textBox9
            // 
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20999999344348908D, Telerik.Reporting.Drawing.UnitType.Inch));
            // 
            // textBox13
            // 
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.20999999344348908D, Telerik.Reporting.Drawing.UnitType.Inch));
            // 
            // EmployeeSales
            // 
            this.EmployeeSales.ConnectionString = "Telerik.Reporting.Examples.CSharp.Properties.Settings.TelerikConnectionString";
            this.EmployeeSales.Name = "EmployeeSales";
            this.EmployeeSales.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@ReportYear", System.Data.DbType.Int32, "=Parameters.ReportDate.Value.Year"),
            new Telerik.Reporting.SqlDataSourceParameter("@ReportMonth", System.Data.DbType.Int32, "=Parameters.ReportDate.Value.Month"),
            new Telerik.Reporting.SqlDataSourceParameter("@EmployeeID", System.Data.DbType.Int32, "=Parameters.Employee.Value")});
            this.EmployeeSales.SelectCommand = resources.GetString("EmployeeSales.SelectCommand");
            // 
            // panelWrapper
            // 
            this.panelWrapper.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.chartYearlySales,
            this.chartMonthlySales});
            this.panelWrapper.KeepTogether = false;
            this.panelWrapper.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(3D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.10003948211669922D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(3.5D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(6.0999207496643066D, Telerik.Reporting.Drawing.UnitType.Inch));
            // 
            // chartYearlySales
            // 
            this.chartYearlySales.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.chartYearlySales.Appearance.Shadow.Color = System.Drawing.Color.DarkGray;
            this.chartYearlySales.BitmapResolution = 300F;
            this.chartYearlySales.ChartTitle.Appearance.Shadow.Color = System.Drawing.Color.DarkGray;
            this.chartYearlySales.ChartTitle.TextBlock.Appearance.Position.AlignedPosition = Telerik.Reporting.Charting.Styles.AlignedPositions.Top;
            this.chartYearlySales.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.chartYearlySales.ChartTitle.TextBlock.Text = "Yearly Sales Comparison";
            this.chartYearlySales.DataSource = this.EmployeeSalesYearOverYear;
            this.chartYearlySales.ImageFormat = System.Drawing.Imaging.ImageFormat.Emf;
            this.chartYearlySales.Legend.Appearance.Border.Visible = false;
            this.chartYearlySales.Legend.Appearance.Overflow = Telerik.Reporting.Charting.Styles.Overflow.Row;
            this.chartYearlySales.Legend.Appearance.Position.AlignedPosition = Telerik.Reporting.Charting.Styles.AlignedPositions.Bottom;
            this.chartYearlySales.Legend.Appearance.Shadow.Color = System.Drawing.Color.DarkGray;
            this.chartYearlySales.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(3.9378803194267675E-05D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(3.9418537198798731E-05D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.chartYearlySales.Name = "chartYearlySales";
            this.chartYearlySales.PlotArea.Appearance.Border.Visible = false;
            chartMargins1.Bottom = new Telerik.Reporting.Charting.Styles.Unit(32D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            chartMargins1.Left = new Telerik.Reporting.Charting.Styles.Unit(18D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            chartMargins1.Right = new Telerik.Reporting.Charting.Styles.Unit(5D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            chartMargins1.Top = new Telerik.Reporting.Charting.Styles.Unit(18D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            this.chartYearlySales.PlotArea.Appearance.Dimensions.Margins = chartMargins1;
            this.chartYearlySales.PlotArea.Appearance.FillStyle.FillType = Telerik.Reporting.Charting.Styles.FillType.Solid;
            this.chartYearlySales.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White;
            this.chartYearlySales.PlotArea.Appearance.SeriesPalette = "Mac";
            this.chartYearlySales.PlotArea.Appearance.Shadow.Color = System.Drawing.Color.DarkGray;
            this.chartYearlySales.PlotArea.XAxis.Appearance.LabelAppearance.Position.AlignedPosition = Telerik.Reporting.Charting.Styles.AlignedPositions.Top;
            this.chartYearlySales.PlotArea.XAxis.Appearance.LabelAppearance.RotationAngle = 90F;
            this.chartYearlySales.PlotArea.XAxis.Appearance.MajorGridLines.Visible = false;
            this.chartYearlySales.PlotArea.XAxis.Appearance.MajorTick.Visible = false;
            this.chartYearlySales.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            this.chartYearlySales.PlotArea.XAxis.AutoScale = false;
            this.chartYearlySales.PlotArea.XAxis.DataLabelsColumn = "Month";
            chartAxisItem1.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            chartAxisItem2.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            chartAxisItem3.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            chartAxisItem4.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            chartAxisItem5.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            chartAxisItem6.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem6.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            chartAxisItem7.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem7.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.chartYearlySales.PlotArea.XAxis.Items.AddRange(new Telerik.Reporting.Charting.ChartAxisItem[] {
            chartAxisItem1,
            chartAxisItem2,
            chartAxisItem3,
            chartAxisItem4,
            chartAxisItem5,
            chartAxisItem6,
            chartAxisItem7});
            this.chartYearlySales.PlotArea.XAxis.MinValue = 1D;
            this.chartYearlySales.PlotArea.YAxis.Appearance.LabelAppearance.Border.Visible = false;
            this.chartYearlySales.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.Black;
            this.chartYearlySales.PlotArea.YAxis.Appearance.MinorTick.Visible = false;
            this.chartYearlySales.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            this.chartYearlySales.PlotArea.YAxis.AxisLabel.Appearance.Visible = true;
            this.chartYearlySales.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            this.chartYearlySales.PlotArea.YAxis.AxisLabel.TextBlock.Text = "In Thousands";
            this.chartYearlySales.PlotArea.YAxis.AxisLabel.Visible = true;
            this.chartYearlySales.PlotArea.YAxis.MaxItemsCount = 5;
            this.chartYearlySales.PlotArea.YAxis.MaxValue = 100D;
            this.chartYearlySales.PlotArea.YAxis.Step = 20D;
            chartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(167)))), ((int)(((byte)(226)))));
            chartSeries1.Appearance.LabelAppearance.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries1.Appearance.LabelAppearance.Visible = false;
            chartSeries1.Appearance.PointMark.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries1.Appearance.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries1.DataYColumn = "Y2001";
            chartSeries1.DefaultLabelValue = "";
            chartSeries1.Name = "2001";
            chartSeries1.Type = Telerik.Reporting.Charting.ChartSeriesType.Line;
            chartSeries2.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(87)))), ((int)(((byte)(60)))));
            chartSeries2.Appearance.LabelAppearance.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries2.Appearance.LabelAppearance.Visible = false;
            chartSeries2.Appearance.PointMark.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries2.Appearance.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries2.DataYColumn = "Y2002";
            chartSeries2.DefaultLabelValue = "";
            chartSeries2.Name = "2002";
            chartSeries2.Type = Telerik.Reporting.Charting.ChartSeriesType.Line;
            chartSeries3.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(203)))), ((int)(((byte)(76)))));
            chartSeries3.Appearance.LabelAppearance.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries3.Appearance.LabelAppearance.Visible = false;
            chartSeries3.Appearance.PointMark.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries3.Appearance.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries3.DataYColumn = "Y2003";
            chartSeries3.DefaultLabelValue = "";
            chartSeries3.Name = "2003";
            chartSeries3.Type = Telerik.Reporting.Charting.ChartSeriesType.Line;
            chartSeries4.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            chartSeries4.Appearance.LabelAppearance.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries4.Appearance.LabelAppearance.Visible = false;
            chartSeries4.Appearance.PointMark.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries4.Appearance.Shadow.Color = System.Drawing.Color.DarkGray;
            chartSeries4.DataYColumn = "Y2004";
            chartSeries4.DefaultLabelValue = "";
            chartSeries4.Name = "2004";
            chartSeries4.Type = Telerik.Reporting.Charting.ChartSeriesType.Line;
            this.chartYearlySales.Series.AddRange(new Telerik.Reporting.Charting.ChartSeries[] {
            chartSeries1,
            chartSeries2,
            chartSeries3,
            chartSeries4});
            this.chartYearlySales.SeriesPalette = "Mac";
            this.chartYearlySales.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(3.4999606609344482D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(2.9999210834503174D, Telerik.Reporting.Drawing.UnitType.Inch));
            // 
            // EmployeeSalesYearOverYear
            // 
            this.EmployeeSalesYearOverYear.ConnectionString = "Telerik.Reporting.Examples.CSharp.Properties.Settings.TelerikConnectionString";
            this.EmployeeSalesYearOverYear.Name = "EmployeeSalesYearOverYear";
            this.EmployeeSalesYearOverYear.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@ReportYear", System.Data.DbType.String, "=Parameters.ReportDate.Value.Year"),
            new Telerik.Reporting.SqlDataSourceParameter("@ReportMonth", System.Data.DbType.String, "=Parameters.ReportDate.Value.Month"),
            new Telerik.Reporting.SqlDataSourceParameter("@EmployeeID", System.Data.DbType.String, "=Parameters.Employee.Value")});
            this.EmployeeSalesYearOverYear.SelectCommand = resources.GetString("EmployeeSalesYearOverYear.SelectCommand");
            // 
            // chartMonthlySales
            // 
            this.chartMonthlySales.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.chartMonthlySales.BitmapResolution = 300F;
            this.chartMonthlySales.ChartTitle.TextBlock.Appearance.Position.AlignedPosition = Telerik.Reporting.Charting.Styles.AlignedPositions.Top;
            this.chartMonthlySales.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.chartMonthlySales.ChartTitle.TextBlock.Text = "Category Sales Comparison";
            this.chartMonthlySales.DataSource = this.EmployeeCategorySales;
            this.chartMonthlySales.ImageFormat = System.Drawing.Imaging.ImageFormat.Emf;
            this.chartMonthlySales.Legend.Appearance.Border.Visible = false;
            this.chartMonthlySales.Legend.Appearance.Overflow = Telerik.Reporting.Charting.Styles.Overflow.Row;
            this.chartMonthlySales.Legend.Appearance.Position.AlignedPosition = Telerik.Reporting.Charting.Styles.AlignedPositions.Bottom;
            this.chartMonthlySales.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(3.9418537198798731E-05D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(3.0999605655670166D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.chartMonthlySales.Name = "chartMonthlySales";
            this.chartMonthlySales.PlotArea.Appearance.Border.Visible = false;
            chartMargins2.Bottom = new Telerik.Reporting.Charting.Styles.Unit(34D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            chartMargins2.Left = new Telerik.Reporting.Charting.Styles.Unit(18D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            chartMargins2.Right = new Telerik.Reporting.Charting.Styles.Unit(5D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            chartMargins2.Top = new Telerik.Reporting.Charting.Styles.Unit(18D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            this.chartMonthlySales.PlotArea.Appearance.Dimensions.Margins = chartMargins2;
            this.chartMonthlySales.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White;
            this.chartMonthlySales.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.White;
            this.chartMonthlySales.PlotArea.Appearance.SeriesPalette = "Mac";
            this.chartMonthlySales.PlotArea.XAxis.Appearance.LabelAppearance.Position.AlignedPosition = Telerik.Reporting.Charting.Styles.AlignedPositions.Top;
            this.chartMonthlySales.PlotArea.XAxis.Appearance.LabelAppearance.RotationAngle = 90F;
            this.chartMonthlySales.PlotArea.XAxis.Appearance.MajorTick.Visible = false;
            this.chartMonthlySales.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            this.chartMonthlySales.PlotArea.XAxis.AutoScale = false;
            this.chartMonthlySales.PlotArea.XAxis.DataLabelsColumn = "Category";
            chartAxisItem8.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            chartAxisItem9.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem9.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            chartAxisItem10.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem10.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            chartAxisItem11.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem11.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            chartAxisItem12.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem12.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            chartAxisItem13.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem13.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            chartAxisItem14.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            chartAxisItem14.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.chartMonthlySales.PlotArea.XAxis.Items.AddRange(new Telerik.Reporting.Charting.ChartAxisItem[] {
            chartAxisItem8,
            chartAxisItem9,
            chartAxisItem10,
            chartAxisItem11,
            chartAxisItem12,
            chartAxisItem13,
            chartAxisItem14});
            this.chartMonthlySales.PlotArea.XAxis.MinValue = 1D;
            this.chartMonthlySales.PlotArea.YAxis.Appearance.LabelAppearance.Border.Visible = false;
            this.chartMonthlySales.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.Black;
            this.chartMonthlySales.PlotArea.YAxis.Appearance.MinorTick.Visible = false;
            this.chartMonthlySales.PlotArea.YAxis.Appearance.TextAppearance.Border.Visible = false;
            this.chartMonthlySales.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.chartMonthlySales.PlotArea.YAxis.AxisLabel.Appearance.Border.Visible = false;
            this.chartMonthlySales.PlotArea.YAxis.AxisLabel.Appearance.Visible = true;
            this.chartMonthlySales.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 7F);
            this.chartMonthlySales.PlotArea.YAxis.AxisLabel.TextBlock.Text = "In Thousands";
            this.chartMonthlySales.PlotArea.YAxis.AxisLabel.Visible = true;
            this.chartMonthlySales.PlotArea.YAxis.MaxItemsCount = 4;
            this.chartMonthlySales.PlotArea.YAxis.MaxValue = 100D;
            this.chartMonthlySales.PlotArea.YAxis.Step = 20D;
            chartSeries5.DataYColumn = "Y2001";
            chartSeries5.DefaultLabelValue = "";
            chartSeries5.Name = "2001";
            chartSeries6.DataYColumn = "Y2002";
            chartSeries6.DefaultLabelValue = "";
            chartSeries6.Name = "2002";
            chartSeries7.DataYColumn = "Y2003";
            chartSeries7.DefaultLabelValue = "";
            chartSeries7.Name = "2003";
            chartSeries8.DataYColumn = "Y2004";
            chartSeries8.DefaultLabelValue = "";
            chartSeries8.Name = "2004";
            this.chartMonthlySales.Series.AddRange(new Telerik.Reporting.Charting.ChartSeries[] {
            chartSeries5,
            chartSeries6,
            chartSeries7,
            chartSeries8});
            this.chartMonthlySales.SeriesPalette = "Mac";
            this.chartMonthlySales.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(3.4999606609344482D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(3.00003981590271D, Telerik.Reporting.Drawing.UnitType.Inch));
            // 
            // EmployeeCategorySales
            // 
            this.EmployeeCategorySales.ConnectionString = "Telerik.Reporting.Examples.CSharp.Properties.Settings.TelerikConnectionString";
            this.EmployeeCategorySales.Name = "EmployeeCategorySales";
            this.EmployeeCategorySales.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@ReportYear", System.Data.DbType.String, "=Parameters.ReportDate.Value.Year"),
            new Telerik.Reporting.SqlDataSourceParameter("@ReportMonth", System.Data.DbType.String, "=Parameters.ReportDate.Value.Month"),
            new Telerik.Reporting.SqlDataSourceParameter("@EmployeeID", System.Data.DbType.String, "=Parameters.Employee.Value")});
            this.EmployeeCategorySales.SelectCommand = resources.GetString("EmployeeCategorySales.SelectCommand");
            // 
            // group1
            // 
            this.group1.GroupFooter = this.groupFooterSection1;
            this.group1.GroupHeader = this.groupHeaderSection1;
            this.group1.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("")});
            this.group1.Name = "group1";
            // 
            // groupFooterSection1
            // 
            this.groupFooterSection1.Height = new Telerik.Reporting.Drawing.Unit(0.1272023469209671D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.groupFooterSection1.Name = "groupFooterSection1";
            this.groupFooterSection1.Style.Visible = false;
            // 
            // groupHeaderSection1
            // 
            this.groupHeaderSection1.Height = new Telerik.Reporting.Drawing.Unit(0.8728376030921936D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.groupHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pictureBoxLogo,
            this.textBoxLogo,
            this.textBoxDataRange,
            this.textBoxReportEmployee});
            this.groupHeaderSection1.Name = "groupHeaderSection1";
            this.groupHeaderSection1.PrintOnEveryPage = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(3.9418537198798731E-05D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.pictureBoxLogo.MimeType = "image/jpeg";
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.440000057220459D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.67434477806091309D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.pictureBoxLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBoxLogo.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.pictureBoxLogo.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.pictureBoxLogo.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Point);
            this.pictureBoxLogo.Value = ((object)(resources.GetObject("pictureBoxLogo.Value")));
            // 
            // textBoxLogo
            // 
            this.textBoxLogo.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(1.4400788545608521D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(3.9418537198798731E-05D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxLogo.Name = "textBoxLogo";
            this.textBoxLogo.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(5.0571436882019043D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.3790486752986908D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxLogo.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.textBoxLogo.Style.Font.Bold = true;
            this.textBoxLogo.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(20D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxLogo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxLogo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxLogo.Value = "Sales Report";
            // 
            // textBoxDataRange
            // 
            this.textBoxDataRange.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.67446309328079224D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxDataRange.Name = "textBoxDataRange";
            this.textBoxDataRange.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(6.4972224235534668D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.19837446510791779D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxDataRange.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.textBoxDataRange.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.textBoxDataRange.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxDataRange.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxDataRange.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxDataRange.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxDataRange.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxDataRange.Style.Color = System.Drawing.Color.White;
            this.textBoxDataRange.Style.Font.Name = "Trebuchet MS";
            this.textBoxDataRange.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(12D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxDataRange.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxDataRange.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.textBoxDataRange.Value = "=Parameters.ReportDate.Value.ToString(\'MMMM yyyy\')";
            // 
            // textBoxReportEmployee
            // 
            this.textBoxReportEmployee.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(1.4400788545608521D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.37916693091392517D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxReportEmployee.Name = "textBoxReportEmployee";
            this.textBoxReportEmployee.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(5.0571432113647461D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.29521733522415161D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxReportEmployee.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.textBoxReportEmployee.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.textBoxReportEmployee.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxReportEmployee.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxReportEmployee.Style.Color = System.Drawing.Color.White;
            this.textBoxReportEmployee.Style.Font.Bold = true;
            this.textBoxReportEmployee.Style.Font.Name = "Trebuchet MS";
            this.textBoxReportEmployee.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(16D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxReportEmployee.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxReportEmployee.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxReportEmployee.Value = "=Parameters.Employee.Label";
            // 
            // EmployeeSalesSummary
            // 
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            this.group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.groupHeaderSection1,
            this.groupFooterSection1,
            this.detail});
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins.Bottom = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.PageSettings.Margins.Left = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.PageSettings.Margins.Right = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.PageSettings.Margins.Top = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.Name = "ReportDate";
            reportParameter1.AutoRefresh = true;
            reportParameter1.Text = "Report Date";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter1.Value = "=#2003-07-01#";
            reportParameter1.Visible = true;
            reportParameter2.AvailableValues.DataSource = this.SalesEmployees;
            reportParameter2.AvailableValues.DisplayMember = "= Fields.Employee";
            reportParameter2.AvailableValues.ValueMember = "= Fields.SalesPersonID";
            reportParameter2.Name = "Employee";
            reportParameter2.AutoRefresh = true;
            reportParameter2.Text = "Employee";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter2.Value = "=283";
            reportParameter2.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.Width = new Telerik.Reporting.Drawing.Unit(6.5D, Telerik.Reporting.Drawing.UnitType.Inch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private SqlDataSource EmployeeSalesYearOverYear;
        private SqlDataSource EmployeeSales;
        private Crosstab crosstabEmployeeSales;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBoxSalesOrderNumber;
        private Telerik.Reporting.TextBox textBoxCategory;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBoxTableTitle;
        private Telerik.Reporting.TextBox textBoxCategoryAmount;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBoxOrderTotal;
        private Telerik.Reporting.TextBox textBox13;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBoxEmployeeSalesTotal;
        private Telerik.Reporting.TextBox textBoxTotalLabel;
        private Telerik.Reporting.TextBox textBox12;
        private SqlDataSource SalesEmployees;
        private Chart chartYearlySales;
        private Chart chartMonthlySales;
        private SqlDataSource EmployeeCategorySales;
        private Telerik.Reporting.Panel panelWrapper;
        private Group group1;
        private GroupFooterSection groupFooterSection1;
        private GroupHeaderSection groupHeaderSection1;
        private Telerik.Reporting.PictureBox pictureBoxLogo;
        private Telerik.Reporting.TextBox textBoxLogo;
        private Telerik.Reporting.TextBox textBoxDataRange;
        private Telerik.Reporting.TextBox textBoxReportEmployee;
    }
}