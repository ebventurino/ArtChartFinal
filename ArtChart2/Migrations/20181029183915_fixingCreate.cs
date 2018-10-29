using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtChart2.Migrations
{
    public partial class fixingCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artwork_ArtType_ArtTypeId",
                table: "Artwork");

            migrationBuilder.DropTable(
                name: "ArtType");

            migrationBuilder.DropIndex(
                name: "IX_Artwork_ArtTypeId",
                table: "Artwork");

            migrationBuilder.DropColumn(
                name: "ArtTypeId",
                table: "Artwork");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtTypeId",
                table: "Artwork",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ArtType",
                columns: table => new
                {
                    ArtTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtType", x => x.ArtTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artwork_ArtTypeId",
                table: "Artwork",
                column: "ArtTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artwork_ArtType_ArtTypeId",
                table: "Artwork",
                column: "ArtTypeId",
                principalTable: "ArtType",
                principalColumn: "ArtTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
