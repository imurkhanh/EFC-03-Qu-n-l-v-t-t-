using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC_03.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NgayNhap",
                table: "PhieuXuat",
                newName: "NgayXuat");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NgayXuat",
                table: "PhieuXuat",
                newName: "NgayNhap");
        }
    }
}
