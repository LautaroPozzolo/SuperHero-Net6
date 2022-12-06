using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroAPI.Migrations
{
    public partial class addSuperPowerRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuperPower",
                table: "superHeroes");

            migrationBuilder.AddColumn<int>(
                name: "SuperHeroId",
                table: "superPowers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_superPowers_SuperHeroId",
                table: "superPowers",
                column: "SuperHeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_superPowers_superHeroes_SuperHeroId",
                table: "superPowers",
                column: "SuperHeroId",
                principalTable: "superHeroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_superPowers_superHeroes_SuperHeroId",
                table: "superPowers");

            migrationBuilder.DropIndex(
                name: "IX_superPowers_SuperHeroId",
                table: "superPowers");

            migrationBuilder.DropColumn(
                name: "SuperHeroId",
                table: "superPowers");

            migrationBuilder.AddColumn<string>(
                name: "SuperPower",
                table: "superHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
