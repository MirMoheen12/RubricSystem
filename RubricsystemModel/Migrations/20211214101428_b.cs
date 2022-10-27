using Microsoft.EntityFrameworkCore.Migrations;

namespace RubricsystemModel.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubcategoryId",
                table: "Answers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_SubcategoryId",
                table: "Answers",
                column: "SubcategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Subcategories_SubcategoryId",
                table: "Answers",
                column: "SubcategoryId",
                principalTable: "Subcategories",
                principalColumn: "SubcategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Subcategories_SubcategoryId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_SubcategoryId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "SubcategoryId",
                table: "Answers");
        }
    }
}
