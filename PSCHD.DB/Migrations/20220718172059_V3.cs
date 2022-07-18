using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSCHD.DB.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Finishes_MagiCards_MagicCardId",
                table: "Finishes");

            migrationBuilder.DropIndex(
                name: "IX_Finishes_MagicCardId",
                table: "Finishes");

            migrationBuilder.DropColumn(
                name: "MagicCardId",
                table: "Finishes");

            migrationBuilder.CreateTable(
                name: "CardFinishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FinishId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardFinishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardFinishes_Finishes_FinishId",
                        column: x => x.FinishId,
                        principalTable: "Finishes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardFinishes_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardFinishes_FinishId",
                table: "CardFinishes",
                column: "FinishId");

            migrationBuilder.CreateIndex(
                name: "IX_CardFinishes_MagicCardId",
                table: "CardFinishes",
                column: "MagicCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardFinishes");

            migrationBuilder.AddColumn<int>(
                name: "MagicCardId",
                table: "Finishes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Finishes_MagicCardId",
                table: "Finishes",
                column: "MagicCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Finishes_MagiCards_MagicCardId",
                table: "Finishes",
                column: "MagicCardId",
                principalTable: "MagiCards",
                principalColumn: "Id");
        }
    }
}
