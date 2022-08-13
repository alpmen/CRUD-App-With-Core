using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreAppSinav.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GorevDepartmans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAd = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    Detay = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevDepartmans", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    perid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true),
                    soyad = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true),
                    sehir = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true),
                    departid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.perid);
                    table.ForeignKey(
                        name: "FK_Personels_GorevDepartmans_departid",
                        column: x => x.departid,
                        principalTable: "GorevDepartmans",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personels_departid",
                table: "Personels",
                column: "departid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "GorevDepartmans");
        }
    }
}
