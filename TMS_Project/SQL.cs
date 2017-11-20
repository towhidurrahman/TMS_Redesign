﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TMS_Project
{
    class SQL
    {
        public SqlDataAdapter SqlDtAdptr;
        public DataTable DtTbl;
        public string condb;

        public DataTable get_rs(string STRSQL, string database, string source)
        {

            SqlConnection SqlConn = new SqlConnection("Server='" + source + "';Database='" + database + "';user=sa;pwd=erp;");

            try
            {
                SqlConn.Open();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }

            SqlCommand SqlCmd = new SqlCommand();

            SqlCmd.CommandText = STRSQL;
            SqlCmd.Connection = SqlConn;
            SqlCmd.CommandTimeout = 600;

            SqlDtAdptr = new SqlDataAdapter(SqlCmd);
            DtTbl = new DataTable();
            SqlDtAdptr.Fill(DtTbl);

            return DtTbl;
        }
    }


}
