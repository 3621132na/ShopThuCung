using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Components
{
    [ViewComponent(Name = "Loai")]
    public class LoaiComponent : ViewComponent
    {
        private ShopContext data;
        public LoaiComponent(ShopContext context)
        {
            data = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int danhmuc)
        {
            var Loai = (from l in data.Loais where l.MaDm == danhmuc select l).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", Loai));
        }
    }
}
