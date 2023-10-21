using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Shop.Models
{
    public class Giohang
    {
        private readonly ShopContext _context;
        public int iMaSp { set; get; }
        public string sTenSp { set; get; }
        public string sAnhbia { set; get; }
        public Double dDongia { set; get; }
        public int iSoluong { set; get; }
        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }
        public Giohang(int MaSp)
        {
            iMaSp = MaSp;
            Sanpham sp = null;
            if (_context != null)
            {
                sp = _context.Sanphams.SingleOrDefault(n => n.MaSp == iMaSp);

                if (sp != null)
                {
                    sTenSp = sp.TenSp;
                    sAnhbia = sp.Anhbia;
                    dDongia = sp.Giaban != null ? double.Parse(sp.Giaban.ToString()) : 0;
                    iSoluong = 1;
                }
            }
        }
    }
}
