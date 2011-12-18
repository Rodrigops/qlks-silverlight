using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Web;
using System.Configuration;

namespace QuanLyKhachSan
{
    public class Common
    {
        public static int UserID()
        {
            return int.Parse(HttpContext.Current.Session["UserID"].ToString());
        }
        #region GetConnectionstring
        /// <summary>
        /// method to retrieve connection stringed in the web.config file
        /// </summary>
        /// <param name="str">Name of the connection</param>
        /// <remarks>Need a reference to the System.Configuration Namespace</remarks>
        /// <returns></returns>
        /// 
        public static string GetConnectionString(string str)
        {
            //variable to hold our return value
            string conn = string.Empty;
            //check if a value was provided
            if (!string.IsNullOrEmpty(str))
            {
                //name provided so search for that connection
                conn = ConfigurationManager.ConnectionStrings[str].ConnectionString;

            }
            else
            //name not provided, get the 'default' connection
            {
                conn = ConfigurationManager.ConnectionStrings["YourConnName"].ConnectionString;
            }
            //return the value
            return conn;
        }
        #endregion
        public string EncryptPasswordMD5(string Password)
        {
            try
            {
                UTF32Encoding u = new UTF32Encoding();
                byte[] bytes = u.GetBytes(Password);
                MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
                byte[] strmd5 = MD5.ComputeHash(bytes);
                byte[] strSHA1 = u.GetBytes(Convert.ToBase64String(strmd5));
                SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
                byte[] kq = sha1.ComputeHash(strSHA1);
                return Convert.ToBase64String(kq);
            }
            catch
            {
                return "";
            }
        }
        public string Decrypt(string EncryptString)
        {
            try
            {
                string Password = "!@#quanlykhachsan$%^";
                RijndaelManaged managed = new RijndaelManaged();
                byte[] buffer = Convert.FromBase64String(EncryptString);
                byte[] rgbSalt = Encoding.ASCII.GetBytes(Password.Length.ToString());
                PasswordDeriveBytes bytes = new PasswordDeriveBytes(Password, rgbSalt);
                ICryptoTransform transform = managed.CreateDecryptor(bytes.GetBytes(0x20), bytes.GetBytes(0x10));
                MemoryStream stream = new MemoryStream(buffer);
                CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
                byte[] buffer3 = new byte[stream.Length];
                int count = stream2.Read(buffer3, 0, buffer3.Length);
                stream.Close();
                stream2.Close();
                return Encoding.Unicode.GetString(buffer3, 0, count);
            }
            catch
            {
                return "";
            }

        }
        public string Encrypt(string Username)
        {
            string sRet = "";
            byte[] inArray = null;
            try
            {
                string Password = "!@#quanlykhachsan$%^";
                RijndaelManaged managed = new RijndaelManaged();
                byte[] buffer = Encoding.Unicode.GetBytes(Username);
                byte[] rgbSalt = Encoding.ASCII.GetBytes(Password.Length.ToString());
                PasswordDeriveBytes bytes = new PasswordDeriveBytes(Password, rgbSalt);
                ICryptoTransform transform = managed.CreateEncryptor(bytes.GetBytes(0x20), bytes.GetBytes(0x10));
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                inArray = stream.ToArray();
                stream.Close();
                stream2.Close();
            }
            catch
            {
            }

            try
            {
                sRet = Convert.ToBase64String(inArray);
            }
            catch
            {
            }
            return sRet;
        }
    }
}