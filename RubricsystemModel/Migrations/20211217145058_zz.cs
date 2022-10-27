using Microsoft.EntityFrameworkCore.Migrations;

namespace RubricsystemModel.Migrations
{
    public partial class zz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Subcategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Subcategories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Subcategories");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Subcategories");
        }
    }
}
