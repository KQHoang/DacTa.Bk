using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.BL.Models
{
    public class PhieuNhap
    {   
        public int MaPhieuNhap { get; set; }

        public DateTime Ngay { get; set; }

        public int MaTaiKhoan { get; set; }

        public int TrangThai { get; set; }

        public decimal TongTien { get; set; }

        public string Mota { get; set; }
    }
}
