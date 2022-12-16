using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.BL.Models
{
    public class SanPham
    {
        public SanPham()
        {
            MaSanPham = new int();
        }
        public int MaSanPham { get; set; }

        public int MaThuongHieu { get; set; }

        public string TenSanPham { get; set; }

        public decimal DonGiaNhap { get; set; }

        public decimal DonGiaBan { get; set; }

        public int SoLuong { get; set; }

        public string HinhAnh { get; set; }

        public string MoTa { get; set; }

    }
}
