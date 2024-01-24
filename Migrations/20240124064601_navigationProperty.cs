using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie.Migrations
{
    public partial class navigationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_Movies_MovieId",
                table: "Awards");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Awards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_Movies_MovieId",
                table: "Awards",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_Movies_MovieId",
                table: "Awards");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Awards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_Movies_MovieId",
                table: "Awards",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");
        }
    }
}
