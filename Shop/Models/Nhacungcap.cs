using System;
using System.Collections.Generic;

namespace Shop.Models;

public partial class Nhacungcap
{
    public int MaNcc { get; set; }

    public string TenNcc { get; set; } = null!;

    public string? Diachi { get; set; }

    public string? DienThoai { get; set; }

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
