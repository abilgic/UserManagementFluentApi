using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementFluentApi.Migrations
{
    public partial class updatepassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "UserPasswords",
                newName: "Password1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password1",
                table: "UserPasswords",
                newName: "Password");
        }
    }
}
