using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_Do_List.Migrations
{
    /// <inheritdoc />
    public partial class Relationonetomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserModelID",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserModelID",
                table: "Tasks",
                column: "UserModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserModelID",
                table: "Tasks",
                column: "UserModelID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserModelID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_UserModelID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "UserModelID",
                table: "Tasks");
        }
    }
}
