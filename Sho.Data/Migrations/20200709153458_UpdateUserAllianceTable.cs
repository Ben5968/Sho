using Microsoft.EntityFrameworkCore.Migrations;

namespace Sho.Data.Migrations
{
    public partial class UpdateUserAllianceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "UserAlliances",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "UserAlliances");
        }
    }
}
