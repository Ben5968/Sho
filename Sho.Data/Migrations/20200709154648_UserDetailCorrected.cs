using Microsoft.EntityFrameworkCore.Migrations;

namespace Sho.Data.Migrations
{
    public partial class UserDetailCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_AllianceId",
                table: "UserDetails",
                column: "AllianceId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetails_Alliances_AllianceId",
                table: "UserDetails",
                column: "AllianceId",
                principalTable: "Alliances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetails_Alliances_AllianceId",
                table: "UserDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserDetails_AllianceId",
                table: "UserDetails");
        }
    }
}
