using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class Createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMIN",
                columns: table => new
                {
                    UserAdmin = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    PassAdmin = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ADMIN__AF86462BD99B60B4", x => x.UserAdmin);
                });

            migrationBuilder.CreateTable(
                name: "DANHMUC",
                columns: table => new
                {
                    MaDM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.MaDM);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Taikhoan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Matkhau = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Ngaysinh = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhang", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "KHUYENMAI",
                columns: table => new
                {
                    MaKhuyenMai = table.Column<int>(type: "int", nullable: false),
                    LoaiMaKhuyenMai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenKhuyenMai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeMaKhuyenMai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GiaTri = table.Column<double>(type: "float", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    HanSuDung = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHUYENMAI", x => x.MaKhuyenMai);
                });

            migrationBuilder.CreateTable(
                name: "NHACUNGCAP",
                columns: table => new
                {
                    MaNCC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNCC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DienThoai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "NhanXet",
                columns: table => new
                {
                    MaNhanXet = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HinhAnh = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MaKH = table.Column<int>(type: "int", nullable: true),
                    MaSP = table.Column<int>(type: "int", nullable: true),
                    MaHD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanXet", x => x.MaNhanXet);
                });

            migrationBuilder.CreateTable(
                name: "LOAI",
                columns: table => new
                {
                    MaL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDM = table.Column<int>(type: "int", nullable: true),
                    TenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai", x => x.MaL);
                    table.ForeignKey(
                        name: "FK_DanhMuc",
                        column: x => x.MaDM,
                        principalTable: "DANHMUC",
                        principalColumn: "MaDM");
                });

            migrationBuilder.CreateTable(
                name: "DIACHI",
                columns: table => new
                {
                    MaDiaChi = table.Column<int>(type: "int", nullable: false),
                    MaKH = table.Column<int>(type: "int", nullable: true),
                    TenNguoiNhann = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sdt = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIACHI", x => x.MaDiaChi);
                    table.ForeignKey(
                        name: "FK_DIACHI_KHACHHANG",
                        column: x => x.MaKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MaKH");
                });

            migrationBuilder.CreateTable(
                name: "DONDATHANG",
                columns: table => new
                {
                    MaDonHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngaydat = table.Column<DateTime>(type: "date", nullable: true),
                    Ngaygiao = table.Column<DateTime>(type: "date", nullable: true),
                    MaKH = table.Column<int>(type: "int", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TongGia = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Tinhtranggiaohang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Sdt = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaVoucher = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonDatHang", x => x.MaDonHang);
                    table.ForeignKey(
                        name: "FK_Khachhang",
                        column: x => x.MaKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MaKH");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Giaban = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Anhbia = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ngaycapnhat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Soluongton = table.Column<int>(type: "int", nullable: true),
                    MaL = table.Column<int>(type: "int", nullable: true),
                    MaNCC = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_Loai",
                        column: x => x.MaL,
                        principalTable: "LOAI",
                        principalColumn: "MaL");
                    table.ForeignKey(
                        name: "FK_NhaCungCap",
                        column: x => x.MaNCC,
                        principalTable: "NHACUNGCAP",
                        principalColumn: "MaNCC");
                });

            migrationBuilder.CreateTable(
                name: "CHITIETDONTHANG",
                columns: table => new
                {
                    MaDonHang = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    Dongia = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTDatHang", x => new { x.MaDonHang, x.MaSP });
                    table.ForeignKey(
                        name: "FK_DonHang",
                        column: x => x.MaDonHang,
                        principalTable: "DONDATHANG",
                        principalColumn: "MaDonHang");
                    table.ForeignKey(
                        name: "FK_SanPham",
                        column: x => x.MaSP,
                        principalTable: "SANPHAM",
                        principalColumn: "MaSP");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETDONTHANG_MaSP",
                table: "CHITIETDONTHANG",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_DIACHI_MaKH",
                table: "DIACHI",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_DONDATHANG_MaKH",
                table: "DONDATHANG",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "UQ__KHACHHAN__7FB3F64FC08A3864",
                table: "KHACHHANG",
                column: "Taikhoan",
                unique: true,
                filter: "[Taikhoan] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__KHACHHAN__A9D105342273C2BD",
                table: "KHACHHANG",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LOAI_MaDM",
                table: "LOAI",
                column: "MaDM");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MaL",
                table: "SANPHAM",
                column: "MaL");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MaNCC",
                table: "SANPHAM",
                column: "MaNCC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMIN");

            migrationBuilder.DropTable(
                name: "CHITIETDONTHANG");

            migrationBuilder.DropTable(
                name: "DIACHI");

            migrationBuilder.DropTable(
                name: "KHUYENMAI");

            migrationBuilder.DropTable(
                name: "NhanXet");

            migrationBuilder.DropTable(
                name: "DONDATHANG");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropTable(
                name: "LOAI");

            migrationBuilder.DropTable(
                name: "NHACUNGCAP");

            migrationBuilder.DropTable(
                name: "DANHMUC");
        }
    }
}
