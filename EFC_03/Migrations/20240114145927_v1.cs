using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC_03.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuNhap_PhieuXuat_PhieuNhapId",
                table: "ChiTietPhieuNhap");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuNhap_PhieuNhap_PhieuNhapId",
                table: "ChiTietPhieuNhap",
                column: "PhieuNhapId",
                principalTable: "PhieuNhap",
                principalColumn: "PhieuNhapId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuNhap_PhieuNhap_PhieuNhapId",
                table: "ChiTietPhieuNhap");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuNhap_PhieuXuat_PhieuNhapId",
                table: "ChiTietPhieuNhap",
                column: "PhieuNhapId",
                principalTable: "PhieuXuat",
                principalColumn: "PhieuXuatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
