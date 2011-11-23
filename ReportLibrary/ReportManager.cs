namespace Telerik.Reporting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;
    using System.Text;

    public class ReportInfo
    {
        string name;
        string description;
        Type reportType;
        bool isVisible;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        
        public Type ReportType
        {
            get { return this.reportType; }
            set { this.reportType = value; }
        }
        
        public bool IsVisible
        {
            get { return this.isVisible; }
            set { this.isVisible = value; }
        }

        public ReportInfo(string name
            , string description
            , Type reportType
            , bool isVisible)
        {
            this.name = name;
            this.description = description;
            this.reportType = reportType;
            this.isVisible = isVisible;
        }
    }

    public class ReportManager
    {
        Assembly reportAssembly;

        public ReportManager()
            : this(typeof(ReportManager).Assembly)
        {
        }

        public ReportManager(Assembly reportAssembly)
        {
            this.reportAssembly = reportAssembly;
        }

        public IEnumerable<ReportInfo> GetReports()
        {
            if (null != this.reportAssembly)
            {
                foreach (Type t in this.reportAssembly.GetTypes())
                {
                    if (typeof(Telerik.Reporting.IReportDocument).IsAssignableFrom(t)
                        && !t.IsAbstract)
                    {
                        yield return CreateReportInfo(t);
                    }
                }
            }
        }

        static ReportInfo CreateReportInfo(Type t)
        {
            string description = string.Empty;
            bool isVisible = true;
            object[] attributes = null;

            attributes = t.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                description = ((DescriptionAttribute)attributes[0]).Description;
            }

            attributes = t.GetCustomAttributes(typeof(BrowsableAttribute), false);
            if (attributes.Length > 0)
            {
                isVisible = ((BrowsableAttribute)attributes[0]).Browsable;
            }

            return new ReportInfo(FormatName(t.Name)
                , FormatDescription(description)
                , t
                , isVisible);
        }

        static string FormatDescription(string text)
        {
            if (!text.EndsWith("."))
            {
                text += ".";
            }
            return text;
        }

        static string FormatName(string name)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (i == 0)
                {
                    c = Char.ToUpper(c);
                }
                else if (Char.IsUpper(c))
                {
                    sb.Append(" ");
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
