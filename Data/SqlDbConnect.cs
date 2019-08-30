using Microsoft.Dexterity.Applications;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DYNC.ComprobanteFiscal
{
    class SqlDbConnect
    {
        private SqlConnection _con;
        public SqlCommand Cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;
        private string CompanyName;

        public SqlDbConnect(string connectionstring = null)
        {
            //CompanyName = Dynamics.Globals.SqlDataSourceName.Value;
            string dbname = Dynamics.Globals.SystemDatabaseName.Value;
            string UserName = Dynamics.Globals.SqlLoginId.Value;
            string UserPassword = Dynamics.Globals.SqlPassword.Value;
            string datasource = Dynamics.Globals.SqlDataSourceName;

            //string SqlServer = Dynamics.Globals.SqlDboUser.Value;

            // _con = new SqlConnection(connectionstring ?? @"Data Source=APPBBDD\DYNCBBDD;Initial Catalog=DEVELOPMENT;Persist Security Info=True;User ID=dyncuser;Password=mrV$oeyNqofP");
            _con = new SqlConnection(connectionstring ?? @"Data Source=DYNCSERVER\GP;Initial Catalog=DEVELOPMENT;Persist Security Info=True;User ID=" + UserName + ";Password=" + UserPassword + "");
            //_con = new SqlConnection(connectionstring ?? @"Data Source=APPBBDD\DYNCBBDD;Initial Catalog=DEVELOPMENT;Persist Security Info=True;User ID=dyncuser;Password=mrV$oeyNqofP");
            _con.Open();
        }

        public void SqlQuery(string queryText)
        {
            Cmd = new SqlCommand(queryText, _con);
        }

        public DataTable QueryEx()
        {
            _da = new SqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;
        }

        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
        }
    }
}