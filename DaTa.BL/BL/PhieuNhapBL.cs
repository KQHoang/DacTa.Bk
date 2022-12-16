using Dapper;
using DaTa.BL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace DaTa.BL.BL
{
    public class PhieuNhapBL:BaseBL<PhieuNhap>
    {
        public int getPhieuNhapIdMax()
        {
            using (SqlConnection = new SqlConnection(ConnectString))
            {
                var sqlQuery = $"Proc_GetPhieuNhapIdMax";
                var res = SqlConnection.QueryFirst<PhieuNhap>(sqlQuery, commandType: System.Data.CommandType.StoredProcedure);
                var result = res.MaPhieuNhap;
                return result;
            }
        }
    }
}
