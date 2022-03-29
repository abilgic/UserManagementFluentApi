using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementFluentApi.Migrations
{
    public partial class firstdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserIdentityCards_Users_UserIdentityCardId",
                table: "UserIdentityCards");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPasswords_Users_UserPasswordId",
                table: "UserPasswords");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserRoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserPasswords_UserPasswordId",
                table: "UserPasswords");

            migrationBuilder.DropIndex(
                name: "IX_UserIdentityCards_UserIdentityCardId",
                table: "UserIdentityCards");

            migrationBuilder.DropColumn(
                name: "UserPasswordId",
                table: "UserPasswords");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserIdentityCards");

            migrationBuilder.DropColumn(
                name: "UserIdentityCardId",
                table: "UserIdentityCards");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserRoleId",
                table: "UserRoles",
                column: "UserRoleId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserRoleId",
                table: "UserRoles");

            migrationBuilder.AddColumn<int>(
                name: "UserPasswordId",
                table: "UserPasswords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserIdentityCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserIdentityCardId",
                table: "UserIdentityCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserPasswords_UserPasswordId",
                table: "UserPasswords",
                column: "UserPasswordId");

            migrationBuilder.CreateIndex(
                name: "IX_UserIdentityCards_UserIdentityCardId",
                table: "UserIdentityCards",
                column: "UserIdentityCardId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserIdentityCards_Users_UserIdentityCardId",
                table: "UserIdentityCards",
                column: "UserIdentityCardId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
