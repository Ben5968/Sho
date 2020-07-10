using Microsoft.EntityFrameworkCore.Migrations;

namespace Sho.Data.Migrations
{
    public partial class UpdateUserAllianceTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserAlliances_AllianceId",
                table: "UserAlliances",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAlliances_UserID",
                table: "UserAlliances",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAlliances_Alliances_AllianceId",
                table: "UserAlliances",
                column: "AllianceId",
                principalTable: "Alliances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAlliances_Users_UserID",
                table: "UserAlliances",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAlliances_Alliances_AllianceId",
                table: "UserAlliances");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAlliances_Users_UserID",
                table: "UserAlliances");

            migrationBuilder.DropIndex(
                name: "IX_UserAlliances_AllianceId",
                table: "UserAlliances");

            migrationBuilder.DropIndex(
                name: "IX_UserAlliances_UserID",
                table: "UserAlliances");
        }
    }
}
