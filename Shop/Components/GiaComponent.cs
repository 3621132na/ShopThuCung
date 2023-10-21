using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Components
{
    [ViewComponent(Name = "Gia")]
    public class GiaComponent : ViewComponent
    {
        private ShopContext data;
        public GiaComponent(ShopContext context)
        {
            data = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return await Task.FromResult((IViewComponentResult)View("Default"));
        }
        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<Giohang> lstGiohang = HttpContext.Session.Get<List<Giohang>>("GioHang");
            if (lstGiohang != null)
                iTongSoLuong = lstGiohang.Sum(n => n.iSoluong);
            return iTongSoLuong;
        }

        private double TongTien()
        {
            double iTongTien = 0;
            List<Giohang> lstGiohang = HttpContext.Session.Get<List<Giohang>>("GioHang");
            if (lstGiohang != null)
                iTongTien = lstGiohang.Sum(n => n.dThanhtien);
            return iTongTien;
        }
    }
}
