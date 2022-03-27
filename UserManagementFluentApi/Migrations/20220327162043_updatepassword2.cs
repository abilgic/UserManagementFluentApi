using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementFluentApi.Migrations
{
    public partial class updatepassword2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPasswords_Users_UserPasswordId",
                table: "UserPasswords");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserRoleId",
                table: "UserRoles");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPasswords_Users_UserPasswordId",
                table: "UserPasswords",
                column: "UserPasswordId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserRoleId",
                table: "UserRoles",
                column: "UserRoleId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPasswords_Users_UserPasswordId",
                table: "UserPasswords");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserRoleId",
                table: "UserRoles");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPasswords_Users_UserPasswordId",
                table: "UserPasswords",
                column: "UserPasswordId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserRoleId",
                table: "UserRoles",
                column: "UserRoleId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
