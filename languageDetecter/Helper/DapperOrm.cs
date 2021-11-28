using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace languageDetecter.Helper
{
    public class DapperOrm
    {
        private static string connecionsString = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;

        public static List<T> Get<T>(string sql)
        {
            using (SqlConnection con = new SqlConnection(connecionsString))
            {
                con.Open();
                return con.Query<T>(sql).ToList();
            }
        }



        public static void InsertUpdate<T>(string sql, DynamicParameters param)
        {
            using (SqlConnection con = new SqlConnection(connecionsString))
            {
                con.Open();
                con.Execute(sql, param);
            }
        }
        public static void Update<T>(string sql, DynamicParameters param)
        {
            using (SqlConnection con = new SqlConnection(connecionsString))
            {
                con.Open();
                con.Execute(sql, param);
            }
        }

        internal static void InsertUpdate<T>(string sql)
        {
            throw new NotImplementedException();
        }

        public static void SoftDelete<T>(string sql)
        {
            using (SqlConnection con = new SqlConnection(connecionsString))
            {
                con.Open();
                con.Execute(sql);
            }
        }

        public static void DeleteBack<T>(string sql)
        {
            using (SqlConnection con = new SqlConnection(connecionsString))
            {
                con.Open();
                con.Execute(sql);
            }
        }


        public static T Detail<T>(string sql)
        {
            using (SqlConnection con = new SqlConnection(connecionsString))
            {
                con.Open();
                return con.Query<T>(sql).FirstOrDefault();
            }
        }

    }
}