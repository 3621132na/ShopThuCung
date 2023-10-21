using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Components
{
    [ViewComponent(Name = "SanPhamBanChay")]
    public class SanPhamBanChayComponent : ViewComponent
    {
        private ShopContext data;
        public SanPhamBanChayComponent(ShopContext context)
        {
            data = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Sanpham = (from sp in data.Sanphams select sp).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", Sanpham));
        }
    }
}
