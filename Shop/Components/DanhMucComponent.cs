using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Components
{
    [ViewComponent(Name = "DanhMuc")]
    public class DanhMucComponent : ViewComponent
    {
        private ShopContext data;
        public DanhMucComponent(ShopContext context)
        {
            data = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Danhmuc = (from dm in data.Danhmucs select dm).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", Danhmuc));
        }
    }
}
