using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace DaTa.BL.BL
{
    public class BaseBL<Entity>
    {
        protected string ConnectString;
        protected SqlConnection SqlConnection;
        protected String TableName;

        public BaseBL()
        {
            ConnectString = "Data Source=KQHOANG;Initial Catalog=DacTa;Integrated Security=True";
            TableName = typeof(Entity).Name;
        }

        public IEnumerable<Entity> Get()
        {
            using(SqlConnection = new SqlConnection(ConnectString))
            {
                var sql = $"select * from {TableName}";
                var res = SqlConnection.Query<Entity>(sql) ;
                return res;
            }
        }

        public int Insert(Entity entity)
        {
            using (SqlConnection = new SqlConnection(ConnectString))
            {
                var sqlQuery = $"Proc_Insert{TableName}";
                var res = SqlConnection.Execute(sqlQuery, param: entity, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
