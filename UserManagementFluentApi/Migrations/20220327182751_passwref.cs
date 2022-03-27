using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementFluentApi.Migrations
{
    public partial class passwref : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPasswords_Users_UserPasswordId",
                table: "UserPasswords");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserRoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserRoleId",
                table: "UserRoles");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPasswords_Users_UserPasswordId",
                table: "UserPasswords",
                column: "UserPasswordId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPasswords_Users_UserPasswordId",
                table: "UserPasswords");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserRoles");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserRoleId",
                table: "UserRoles",
                column: "UserRoleId");

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
    }
}
