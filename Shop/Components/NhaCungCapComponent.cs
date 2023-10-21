using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Components
{
    [ViewComponent(Name = "NhaCungCap")]
    public class NhaCungCapComponent : ViewComponent
    {
        private ShopContext data;
        public NhaCungCapComponent(ShopContext context)
        {
            data = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Nhacungcap = (from ncc in data.Nhacungcaps select ncc).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", Nhacungcap));
        }
    }
}
