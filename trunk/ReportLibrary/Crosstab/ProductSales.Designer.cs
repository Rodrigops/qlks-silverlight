namespace Telerik.Reporting
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    partial class ProductSales
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.ToggleVisibilityAction toggleVisibilityAction1 = new Telerik.Reporting.ToggleVisibilityAction();
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.ToggleVisibilityAction toggleVisibilityAction2 = new Telerik.Reporting.ToggleVisibilityAction();
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
            Telerik.Reporting.NavigateToReportAction navigateToReportAction1 = new Telerik.Reporting.NavigateToReportAction();
            Telerik.Reporting.Drawing.FormattingRule formattingRule1 = new Telerik.Reporting.Drawing.FormattingRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSales));
            this.textBoxQtr = new Telerik.Reporting.TextBox();
            this.textBoxSubCategory = new Telerik.Reporting.TextBox();
            this.textBoxTotalYearLabel = new Telerik.Reporting.TextBox();
            this.textBoxYear = new Telerik.Reporting.TextBox();
            this.textBoxGrandTotalYearLabel = new Telerik.Reporting.TextBox();
            this.htmlTextBoxTitle = new Telerik.Reporting.HtmlTextBox();
            this.textBoxTotalCategoryLabel = new Telerik.Reporting.TextBox();
            this.textBoxCategory = new Telerik.Reporting.TextBox();
            this.textBoxGrandTotalCategoryLabel = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.crosstab1 = new Telerik.Reporting.Crosstab();
            this.textBoxFact = new Telerik.Reporting.TextBox();
            this.textBoxTotalCategory = new Telerik.Reporting.TextBox();
            this.textBoxTotalCategoryYear = new Telerik.Reporting.TextBox();
            this.textBoxTotalYear = new Telerik.Reporting.TextBox();
            this.textBoxGrandTotalYearCategory = new Telerik.Reporting.TextBox();
            this.textBoxGrandTotalSubCategoryYear = new Telerik.Reporting.TextBox();
            this.textBoxGrandTotal = new Telerik.Reporting.TextBox();
            this.GrandTotalCategoryYear = new Telerik.Reporting.TextBox();
            this.textBoxGrandTotalCategoryQtr = new Telerik.Reporting.TextBox();
            this.pictureBoxLogo = new Telerik.Reporting.PictureBox();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // textBoxQtr
            // 
            this.textBoxQtr.Name = "textBoxQtr";
            this.textBoxQtr.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.61388880014419556D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.24000008404254913D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxQtr.Style.BackgroundColor = System.Drawing.Color.Empty;
            this.textBoxQtr.Style.BorderColor.Bottom = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxQtr.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxQtr.Style.BorderColor.Left = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxQtr.Style.BorderColor.Top = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxQtr.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxQtr.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxQtr.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBoxQtr.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxQtr.Value = "=\'Q\' + Qtr(Fields.OrderDate)";
            // 
            // textBoxSubCategory
            // 
            this.textBoxSubCategory.Name = "textBoxSubCategory";
            this.textBoxSubCategory.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.2006926536560059D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxSubCategory.Style.BackgroundColor = System.Drawing.Color.Empty;
            this.textBoxSubCategory.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxSubCategory.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxSubCategory.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxSubCategory.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxSubCategory.Value = "=Fields.ProductSubCategory";
            // 
            // textBoxTotalYearLabel
            // 
            this.textBoxTotalYearLabel.Name = "textBoxTotalYearLabel";
            this.textBoxTotalYearLabel.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.72500014305114746D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.24000008404254913D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxTotalYearLabel.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.textBoxTotalYearLabel.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxTotalYearLabel.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxTotalYearLabel.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxTotalYearLabel.Style.Color = System.Drawing.Color.Black;
            this.textBoxTotalYearLabel.Style.Font.Bold = true;
            this.textBoxTotalYearLabel.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBoxTotalYearLabel.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxTotalYearLabel.Value = "Total";
            // 
            // textBoxYear
            // 
            tableGroup1.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("=Qtr(Fields.OrderDate)")});
            tableGroup1.Name = "Qtr";
            tableGroup1.ReportItem = this.textBoxQtr;
            tableGroup1.Sortings.AddRange(new Telerik.Reporting.Data.Sorting[] {
            new Telerik.Reporting.Data.Sorting("=Qtr(Fields.OrderDate)", Telerik.Reporting.Data.SortDirection.Asc)});
            toggleVisibilityAction1.Targets.AddRange(new Telerik.Reporting.IToggleVisibilityTarget[] {
            tableGroup1});
            this.textBoxYear.Action = toggleVisibilityAction1;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.3388891220092773D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.27208325266838074D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxYear.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.textBoxYear.Style.BorderColor.Bottom = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxYear.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxYear.Style.BorderColor.Left = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxYear.Style.BorderColor.Top = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.textBoxYear.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxYear.Style.Font.Bold = true;
            this.textBoxYear.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(13D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxYear.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBoxYear.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxYear.Value = "=Fields.OrderDate.Year";
            // 
            // textBoxGrandTotalYearLabel
            // 
            this.textBoxGrandTotalYearLabel.Name = "textBoxGrandTotalYearLabel";
            this.textBoxGrandTotalYearLabel.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.851180374622345D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.51208335161209106D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxGrandTotalYearLabel.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(171)))));
            this.textBoxGrandTotalYearLabel.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.textBoxGrandTotalYearLabel.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBoxGrandTotalYearLabel.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxGrandTotalYearLabel.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxGrandTotalYearLabel.Style.Font.Bold = true;
            this.textBoxGrandTotalYearLabel.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(10D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxGrandTotalYearLabel.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBoxGrandTotalYearLabel.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxGrandTotalYearLabel.Value = "Grand Total";
            // 
            // htmlTextBoxTitle
            // 
            this.htmlTextBoxTitle.Name = "htmlTextBoxTitle";
            this.htmlTextBoxTitle.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.1900694370269775D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.4387499988079071D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.htmlTextBoxTitle.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.htmlTextBoxTitle.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.htmlTextBoxTitle.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.htmlTextBoxTitle.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.htmlTextBoxTitle.Style.Color = System.Drawing.Color.White;
            this.htmlTextBoxTitle.Style.Padding.Bottom = new Telerik.Reporting.Drawing.Unit(2D, Telerik.Reporting.Drawing.UnitType.Point);
            this.htmlTextBoxTitle.Style.Padding.Top = new Telerik.Reporting.Drawing.Unit(2D, Telerik.Reporting.Drawing.UnitType.Point);
            this.htmlTextBoxTitle.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.htmlTextBoxTitle.Value = "<span style=\"font-weight: bold; font-size: 14pt\">SALES BY PRODUCT LINE PER PERIOD" +
                "</span><br /><span style=\"font-size: 8pt\">(USD in thousands)</span>";
            // 
            // textBoxTotalCategoryLabel
            // 
            this.textBoxTotalCategoryLabel.Name = "textBoxTotalCategoryLabel";
            this.textBoxTotalCategoryLabel.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.2006926536560059D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxTotalCategoryLabel.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.textBoxTotalCategoryLabel.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxTotalCategoryLabel.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxTotalCategoryLabel.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxTotalCategoryLabel.Style.Color = System.Drawing.Color.Black;
            this.textBoxTotalCategoryLabel.Style.Font.Bold = true;
            this.textBoxTotalCategoryLabel.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxTotalCategoryLabel.Value = "Total";
            // 
            // textBoxCategory
            // 
            tableGroup2.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("=Fields.ProductSubCategory")});
            tableGroup2.Name = "ProductSubCategory";
            tableGroup2.ReportItem = this.textBoxSubCategory;
            tableGroup2.Sortings.AddRange(new Telerik.Reporting.Data.Sorting[] {
            new Telerik.Reporting.Data.Sorting("=Fields.ProductSubCategory", Telerik.Reporting.Data.SortDirection.Asc)});
            toggleVisibilityAction2.Targets.AddRange(new Telerik.Reporting.IToggleVisibilityTarget[] {
            tableGroup2});
            this.textBoxCategory.Action = toggleVisibilityAction2;
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.2230457067489624D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.47999998927116394D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxCategory.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.textBoxCategory.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxCategory.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxCategory.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxCategory.Style.Font.Bold = true;
            this.textBoxCategory.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(11D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxCategory.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBoxCategory.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxCategory.Value = "=Fields.ProductCategory";
            // 
            // textBoxGrandTotalCategoryLabel
            // 
            this.textBoxGrandTotalCategoryLabel.Name = "textBoxGrandTotalCategoryLabel";
            this.textBoxGrandTotalCategoryLabel.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.4237382411956787D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxGrandTotalCategoryLabel.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(171)))));
            this.textBoxGrandTotalCategoryLabel.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.textBoxGrandTotalCategoryLabel.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxGrandTotalCategoryLabel.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBoxGrandTotalCategoryLabel.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxGrandTotalCategoryLabel.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxGrandTotalCategoryLabel.Style.Font.Bold = true;
            this.textBoxGrandTotalCategoryLabel.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBoxGrandTotalCategoryLabel.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxGrandTotalCategoryLabel.Value = "Grand Total";
            // 
            // detail
            // 
            this.detail.Height = new Telerik.Reporting.Drawing.Unit(1.8000000715255737D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.crosstab1});
            this.detail.Name = "detail";
            // 
            // crosstab1
            // 
            this.crosstab1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(new Telerik.Reporting.Drawing.Unit(0.61388885974884033D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstab1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(new Telerik.Reporting.Drawing.Unit(0.72500014305114746D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstab1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(new Telerik.Reporting.Drawing.Unit(0.851180374622345D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstab1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstab1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstab1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch)));
            this.crosstab1.Body.SetCellContent(0, 0, this.textBoxFact);
            this.crosstab1.Body.SetCellContent(1, 0, this.textBoxTotalCategory);
            this.crosstab1.Body.SetCellContent(1, 1, this.textBoxTotalCategoryYear);
            this.crosstab1.Body.SetCellContent(0, 1, this.textBoxTotalYear);
            this.crosstab1.Body.SetCellContent(1, 2, this.textBoxGrandTotalYearCategory);
            this.crosstab1.Body.SetCellContent(0, 2, this.textBoxGrandTotalSubCategoryYear);
            this.crosstab1.Body.SetCellContent(2, 2, this.textBoxGrandTotal);
            this.crosstab1.Body.SetCellContent(2, 1, this.GrandTotalCategoryYear);
            this.crosstab1.Body.SetCellContent(2, 0, this.textBoxGrandTotalCategoryQtr);
            tableGroup5.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("=Qtr(Fields.OrderDate)")});
            tableGroup5.Name = "Qtr";
            tableGroup5.ReportItem = this.textBoxQtr;
            tableGroup5.Sortings.AddRange(new Telerik.Reporting.Data.Sorting[] {
            new Telerik.Reporting.Data.Sorting("=Qtr(Fields.OrderDate)", Telerik.Reporting.Data.SortDirection.Asc)});
            tableGroup6.ReportItem = this.textBoxTotalYearLabel;
            tableGroup4.ChildGroups.Add(tableGroup5);
            tableGroup4.ChildGroups.Add(tableGroup6);
            tableGroup4.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("=Fields.OrderDate.Year")});
            tableGroup4.Name = "Year";
            tableGroup4.ReportItem = this.textBoxYear;
            tableGroup4.Sortings.AddRange(new Telerik.Reporting.Data.Sorting[] {
            new Telerik.Reporting.Data.Sorting("=Fields.OrderDate.Year", Telerik.Reporting.Data.SortDirection.Asc)});
            tableGroup7.ReportItem = this.textBoxGrandTotalYearLabel;
            tableGroup3.ChildGroups.Add(tableGroup4);
            tableGroup3.ChildGroups.Add(tableGroup7);
            tableGroup3.ReportItem = this.htmlTextBoxTitle;
            this.crosstab1.ColumnGroups.Add(tableGroup3);
            this.crosstab1.Corner.SetCellContent(0, 0, this.pictureBoxLogo, 3, 2);
            this.crosstab1.DataSource = this.sqlDataSource1;
            this.crosstab1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBoxFact,
            this.textBoxTotalCategory,
            this.textBoxTotalCategoryYear,
            this.textBoxTotalYear,
            this.textBoxGrandTotalYearCategory,
            this.textBoxGrandTotalSubCategoryYear,
            this.textBoxGrandTotal,
            this.GrandTotalCategoryYear,
            this.textBoxGrandTotalCategoryQtr,
            this.htmlTextBoxTitle,
            this.textBoxYear,
            this.textBoxQtr,
            this.textBoxTotalYearLabel,
            this.textBoxGrandTotalYearLabel,
            this.pictureBoxLogo,
            this.textBoxCategory,
            this.textBoxSubCategory,
            this.textBoxTotalCategoryLabel,
            this.textBoxGrandTotalCategoryLabel});
            this.crosstab1.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(-1.6821755366436264E-07D, Telerik.Reporting.Drawing.UnitType.Mm), new Telerik.Reporting.Drawing.Unit(-1.6821755366436264E-07D, Telerik.Reporting.Drawing.UnitType.Mm));
            this.crosstab1.Name = "crosstab1";
            tableGroup9.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("=Fields.ProductSubCategory")});
            tableGroup9.Name = "ProductSubCategory";
            tableGroup9.ReportItem = this.textBoxSubCategory;
            tableGroup9.Sortings.AddRange(new Telerik.Reporting.Data.Sorting[] {
            new Telerik.Reporting.Data.Sorting("=Fields.ProductSubCategory", Telerik.Reporting.Data.SortDirection.Asc)});
            tableGroup10.Name = "ProductSubCategoryTotal";
            tableGroup10.ReportItem = this.textBoxTotalCategoryLabel;
            tableGroup8.ChildGroups.Add(tableGroup9);
            tableGroup8.ChildGroups.Add(tableGroup10);
            tableGroup8.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("=Fields.ProductCategory")});
            tableGroup8.Name = "ProductCategory";
            tableGroup8.ReportItem = this.textBoxCategory;
            tableGroup8.Sortings.AddRange(new Telerik.Reporting.Data.Sorting[] {
            new Telerik.Reporting.Data.Sorting("=Fields.ProductCategory", Telerik.Reporting.Data.SortDirection.Asc)});
            tableGroup11.ReportItem = this.textBoxGrandTotalCategoryLabel;
            this.crosstab1.RowGroups.Add(tableGroup8);
            this.crosstab1.RowGroups.Add(tableGroup11);
            this.crosstab1.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(4.613807201385498D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(1.6708333492279053D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.crosstab1.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.crosstab1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.crosstab1.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            // 
            // textBoxFact
            // 
            navigateToReportAction1.Parameters.Add(new Telerik.Reporting.Parameter("ProductCategory", "=Fields.ProductCategory"));
            navigateToReportAction1.Parameters.Add(new Telerik.Reporting.Parameter("ProductSubcategory", "=Fields.ProductSubCategory"));
            navigateToReportAction1.Parameters.Add(new Telerik.Reporting.Parameter("FromDate", "=Min(Fields.OrderDate)"));
            navigateToReportAction1.Parameters.Add(new Telerik.Reporting.Parameter("ToDate", "=Max(Fields.OrderDate)"));
            navigateToReportAction1.ReportDocumentType = "=IIF(Fields.ProductCategory IS NULL,\"\",\"Telerik.Reporting.Examples.CSharp.Product" +
                "LineSales, CSharp.ReportLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToke" +
                "n=null\")";
            this.textBoxFact.Action = navigateToReportAction1;
            formattingRule1.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("Fields.ProductCategory IS NULL", Telerik.Reporting.Data.FilterOperator.NotEqual, "=True")});
            formattingRule1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            formattingRule1.Style.Font.Underline = true;
            this.textBoxFact.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1});
            this.textBoxFact.Format = "{0:N1}";
            this.textBoxFact.Name = "textBoxFact";
            this.textBoxFact.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.61388880014419556D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxFact.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxFact.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxFact.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxFact.Style.Color = System.Drawing.Color.Black;
            this.textBoxFact.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(9D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxFact.Style.Font.Underline = false;
            this.textBoxFact.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxFact.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxFact.Value = "=Sum(Fields.LineTotal)/1000.0";
            // 
            // textBoxTotalCategory
            // 
            this.textBoxTotalCategory.Format = "{0:N1}";
            this.textBoxTotalCategory.Name = "textBoxTotalCategory";
            this.textBoxTotalCategory.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.61388880014419556D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxTotalCategory.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.textBoxTotalCategory.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxTotalCategory.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxTotalCategory.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxTotalCategory.Style.Color = System.Drawing.Color.Black;
            this.textBoxTotalCategory.Style.Font.Bold = true;
            this.textBoxTotalCategory.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(9D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxTotalCategory.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxTotalCategory.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxTotalCategory.Value = "=Sum(Fields.LineTotal)/1000.0";
            // 
            // textBoxTotalCategoryYear
            // 
            this.textBoxTotalCategoryYear.Format = "{0:N1}";
            this.textBoxTotalCategoryYear.Name = "textBoxTotalCategoryYear";
            this.textBoxTotalCategoryYear.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.72500014305114746D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxTotalCategoryYear.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(171)))));
            this.textBoxTotalCategoryYear.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxTotalCategoryYear.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxTotalCategoryYear.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxTotalCategoryYear.Style.Font.Bold = true;
            this.textBoxTotalCategoryYear.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(9D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxTotalCategoryYear.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxTotalCategoryYear.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxTotalCategoryYear.Value = "=Sum(Fields.LineTotal)/1000.0";
            // 
            // textBoxTotalYear
            // 
            this.textBoxTotalYear.Format = "{0:N1}";
            this.textBoxTotalYear.Name = "textBoxTotalYear";
            this.textBoxTotalYear.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.72500014305114746D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxTotalYear.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.textBoxTotalYear.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.textBoxTotalYear.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxTotalYear.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxTotalYear.Style.Color = System.Drawing.Color.Black;
            this.textBoxTotalYear.Style.Font.Bold = true;
            this.textBoxTotalYear.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(9D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxTotalYear.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxTotalYear.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxTotalYear.Value = "=Sum(Fields.LineTotal)/1000.0";
            // 
            // textBoxGrandTotalYearCategory
            // 
            this.textBoxGrandTotalYearCategory.Format = "{0:N1}";
            this.textBoxGrandTotalYearCategory.Name = "textBoxGrandTotalYearCategory";
            this.textBoxGrandTotalYearCategory.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.851180374622345D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxGrandTotalYearCategory.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(215)))), ((int)(((byte)(122)))));
            this.textBoxGrandTotalYearCategory.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.textBoxGrandTotalYearCategory.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxGrandTotalYearCategory.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxGrandTotalYearCategory.Style.Font.Bold = true;
            this.textBoxGrandTotalYearCategory.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(9D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxGrandTotalYearCategory.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxGrandTotalYearCategory.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxGrandTotalYearCategory.Value = "=Sum(Fields.LineTotal)/1000.0";
            // 
            // textBoxGrandTotalSubCategoryYear
            // 
            this.textBoxGrandTotalSubCategoryYear.Format = "{0:N1}";
            this.textBoxGrandTotalSubCategoryYear.Name = "textBoxGrandTotalSubCategoryYear";
            this.textBoxGrandTotalSubCategoryYear.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.851180374622345D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxGrandTotalSubCategoryYear.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(171)))));
            this.textBoxGrandTotalSubCategoryYear.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.textBoxGrandTotalSubCategoryYear.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxGrandTotalSubCategoryYear.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxGrandTotalSubCategoryYear.Style.Font.Bold = true;
            this.textBoxGrandTotalSubCategoryYear.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(9D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxGrandTotalSubCategoryYear.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxGrandTotalSubCategoryYear.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxGrandTotalSubCategoryYear.Value = "= Sum(Fields.LineTotal)/1000.0";
            // 
            // textBoxGrandTotal
            // 
            this.textBoxGrandTotal.Format = "{0:N1}";
            this.textBoxGrandTotal.Name = "textBoxGrandTotal";
            this.textBoxGrandTotal.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.851180374622345D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxGrandTotal.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(215)))), ((int)(((byte)(122)))));
            this.textBoxGrandTotal.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.textBoxGrandTotal.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxGrandTotal.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxGrandTotal.Style.Font.Bold = true;
            this.textBoxGrandTotal.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(9D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxGrandTotal.Style.Font.Underline = true;
            this.textBoxGrandTotal.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxGrandTotal.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxGrandTotal.Value = "=Sum(Fields.LineTotal)/1000.0";
            // 
            // GrandTotalCategoryYear
            // 
            this.GrandTotalCategoryYear.Format = "{0:N1}";
            this.GrandTotalCategoryYear.Name = "GrandTotalCategoryYear";
            this.GrandTotalCategoryYear.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.72500014305114746D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.GrandTotalCategoryYear.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(215)))), ((int)(((byte)(122)))));
            this.GrandTotalCategoryYear.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.GrandTotalCategoryYear.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.GrandTotalCategoryYear.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.GrandTotalCategoryYear.Style.Font.Bold = true;
            this.GrandTotalCategoryYear.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(9D, Telerik.Reporting.Drawing.UnitType.Point);
            this.GrandTotalCategoryYear.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.GrandTotalCategoryYear.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.GrandTotalCategoryYear.Value = "=Sum(Fields.LineTotal)/1000.0";
            // 
            // textBoxGrandTotalCategoryQtr
            // 
            this.textBoxGrandTotalCategoryQtr.Format = "{0:N1}";
            this.textBoxGrandTotalCategoryQtr.Name = "textBoxGrandTotalCategoryQtr";
            this.textBoxGrandTotalCategoryQtr.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.61388880014419556D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.23999999463558197D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.textBoxGrandTotalCategoryQtr.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(171)))));
            this.textBoxGrandTotalCategoryQtr.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.textBoxGrandTotalCategoryQtr.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxGrandTotalCategoryQtr.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBoxGrandTotalCategoryQtr.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.textBoxGrandTotalCategoryQtr.Style.Font.Bold = true;
            this.textBoxGrandTotalCategoryQtr.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(10D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBoxGrandTotalCategoryQtr.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBoxGrandTotalCategoryQtr.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBoxGrandTotalCategoryQtr.Value = "=Sum(Fields.LineTotal)/1000.0";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.MimeType = "image/png";
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.4237382411956787D, Telerik.Reporting.Drawing.UnitType.Inch), new Telerik.Reporting.Drawing.Unit(0.95083332061767578D, Telerik.Reporting.Drawing.UnitType.Inch));
            this.pictureBoxLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Center;
            this.pictureBoxLogo.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.pictureBoxLogo.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.pictureBoxLogo.Style.BorderWidth.Default = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.pictureBoxLogo.Style.Padding.Left = new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.pictureBoxLogo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.pictureBoxLogo.Value = ((object)(resources.GetObject("pictureBoxLogo.Value")));
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Telerik.Reporting.Examples.CSharp.Properties.Settings.TelerikConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
            // 
            // ProductSales
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins.Bottom = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.PageSettings.Margins.Left = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.PageSettings.Margins.Right = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.PageSettings.Margins.Top = new Telerik.Reporting.Drawing.Unit(1D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(38D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(30D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.Width = new Telerik.Reporting.Drawing.Unit(4.7000002861022949D, Telerik.Reporting.Drawing.UnitType.Inch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Crosstab crosstab1;
        private Telerik.Reporting.TextBox textBoxFact;
        private Telerik.Reporting.TextBox textBoxYear;
        private Telerik.Reporting.PictureBox pictureBoxLogo;
        private Telerik.Reporting.TextBox textBoxCategory;
        private Telerik.Reporting.TextBox textBoxSubCategory;
        private Telerik.Reporting.TextBox textBoxTotalCategory;
        private Telerik.Reporting.TextBox textBoxTotalCategoryLabel;
        private Telerik.Reporting.TextBox textBoxQtr;
        private Telerik.Reporting.TextBox textBoxTotalCategoryYear;
        private Telerik.Reporting.TextBox textBoxTotalYear;
        private Telerik.Reporting.TextBox textBoxTotalYearLabel;
        private Telerik.Reporting.TextBox textBoxGrandTotalYearCategory;
        private Telerik.Reporting.TextBox textBoxGrandTotalSubCategoryYear;
        private Telerik.Reporting.TextBox textBoxGrandTotal;
        private Telerik.Reporting.TextBox GrandTotalCategoryYear;
        private Telerik.Reporting.TextBox textBoxGrandTotalCategoryQtr;
        private Telerik.Reporting.TextBox textBoxGrandTotalYearLabel;
        private Telerik.Reporting.TextBox textBoxGrandTotalCategoryLabel;
        private HtmlTextBox htmlTextBoxTitle;
        private SqlDataSource sqlDataSource1;
    }
}