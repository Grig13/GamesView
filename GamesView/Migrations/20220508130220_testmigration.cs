using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesView.Migrations
{
    public partial class testmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Newss_Admins_AdminId",
                table: "Newss");

            migrationBuilder.DropIndex(
                name: "IX_Newss_AdminId",
                table: "Newss");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Newss");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Reviews",
                newName: "ScoreValue");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewText",
                table: "Reviews",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "GameDescription",
                table: "Reviews",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameDescription",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "GameName",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "ScoreValue",
                table: "Reviews",
                newName: "GameId");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewText",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Newss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Newss_AdminId",
                table: "Newss",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Newss_Admins_AdminId",
                table: "Newss",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
