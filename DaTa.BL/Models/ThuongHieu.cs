using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.BL.Models
{
    public class ThuongHieu
    {
        public ThuongHieu()
        {
            MaThuongHieu = new int();
        }
        public int MaThuongHieu { get; set; }

        public string TenThuongHieu { get; set; }

        public string MoTa { get; set; }
    }
}
