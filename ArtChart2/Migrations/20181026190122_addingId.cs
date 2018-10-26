using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtChart2.Migrations
{
    public partial class addingId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtworkId1",
                table: "Artwork",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artwork_ArtworkId1",
                table: "Artwork",
                column: "ArtworkId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Artwork_Artwork_ArtworkId1",
                table: "Artwork",
                column: "ArtworkId1",
                principalTable: "Artwork",
                principalColumn: "ArtworkId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artwork_Artwork_ArtworkId1",
                table: "Artwork");

            migrationBuilder.DropIndex(
                name: "IX_Artwork_ArtworkId1",
                table: "Artwork");

            migrationBuilder.DropColumn(
                name: "ArtworkId1",
                table: "Artwork");
        }
    }
}
