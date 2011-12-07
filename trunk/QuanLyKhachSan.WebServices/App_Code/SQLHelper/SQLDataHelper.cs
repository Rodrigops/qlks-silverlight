using System;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class SQLDataHelper
    {
        private SqlCommand cmd;
        private bool isOpen;

        public SQLDataHelper()
        {
            //string strSqlConnection = "Data Source=USER-PC1117oyx;Initial Catalog=ttewjkqv_qlks;User ID=kscaothang;Password=123654123";
            //string strSqlConnection = @"Data Source=NHOCCUNG-PC\SQLEXPRESS;Initial Catalog=ttewjkqv_qlks;User ID=sa;Password=ng0ctr@m!@#";
            string strSqlConnection = "Data Source=123.30.187.3;Initial Catalog=ttewjkqv_qlks;User ID=ttewjkqv_groupqlks;Password=gqlks@2011";
            //string strSqlConnection = @"Data Source=SE7EN-PC\SE7EN;Initial Catalog=ttewjkqv_qlks;User ID=sa;Password=123456";
            SqlConnection conn = new SqlConnection(strSqlConnection);
            this.cmd = conn.CreateCommand();
        }

        public void Addparameter(string name, object parameter)
        {
            SqlParameter sqlpr = cmd.CreateParameter();
            sqlpr.ParameterName = name;
            sqlpr.Value = parameter;
            cmd.Parameters.Add(sqlpr);
        }

        public SqlDataReader executereader(string commandtext, CommandType type)
        {
            SqlDataReader rd = null;
            try
            {
                this.Open();
                cmd.CommandText = commandtext;
                cmd.CommandType = type;
                rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
            }
            return rd;

        }

        public DataTable executetodatatable(string commandtext, CommandType type)
        {
            DataTable dt = new DataTable();

            try
            {
                this.Open();
                cmd.CommandText = commandtext;
                cmd.CommandType = type;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
            }
            return dt;

        }

		public object executesalar (string commandtext, CommandType type)
		{
			object row = null;
			try
			{
				this.Open();
				cmd.CommandText = commandtext;
				cmd.CommandType = type;
				row = cmd.ExecuteScalar();

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				cmd.Dispose();
				this.Close();
			}
			return row;
		}

        public void executenonquery(string commandtext, CommandType type)
        {
            try
            {
                this.Open();
                cmd.CommandText = commandtext;
                cmd.CommandType = type;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        public void ClearParameter()
        {
            cmd.Parameters.Clear();
        }
        //Mở kết nối
        public void Open()
        {
            if (isOpen)
            {
                return;
            }
            if (this.InTransaction)
            {
                return;
            }
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
                isOpen = true;
            }

        }

        public void Close()
        {
            cmd.Connection.Close();
            isOpen = false;
        }

        public void Dispose()
        {
            cmd.Connection.Dispose();
            cmd.Dispose();
            this.Close();
        }
        private bool inTran = false;
        protected bool InTransaction
        {
            set { inTran = value; }
            get { return inTran; }
        }
    }
}