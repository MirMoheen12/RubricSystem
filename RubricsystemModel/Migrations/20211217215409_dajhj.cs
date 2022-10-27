using Microsoft.EntityFrameworkCore.Migrations;

namespace RubricsystemModel.Migrations
{
    public partial class dajhj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "marksClasses",
                columns: table => new
                {
                    MarksID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marksClasses", x => x.MarksID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "marksClasses");
        }
    }
}
