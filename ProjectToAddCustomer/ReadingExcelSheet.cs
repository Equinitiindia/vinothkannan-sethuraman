using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace ProjectToAddCustomer
{
    class ReadingExcelSheet
    {
        public static DataTable returingExcelData()
        {
            OleDbConnection conn = new OleDbConnection();
            string Path = @"C:\Users\Administrator\Documents\visual studio 2015\Projects\ProjectToAddCustomer\ProjectToAddCustomer\Data.xlsx";
            string sheetName = "TestData";
            DataTable dt = new DataTable();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "Select * from [" + sheetName + "$]";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            DataSet ds = new DataSet();
            da.Fill(ds,sheetName);
            dt = ds.Tables[0];
            return dt;
            }
        }
    }