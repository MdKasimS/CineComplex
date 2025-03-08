using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineComplex.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAllModelsOfRegisteringUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_Addresses_AddressId",
                table: "UserProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_BankAccounts_BankAccountId",
                table: "UserProfiles");

            migrationBuilder.DropIndex(
                name: "IX_UserProfiles_AddressId",
                table: "UserProfiles");

            migrationBuilder.DropIndex(
                name: "IX_UserProfiles_BankAccountId",
                table: "UserProfiles");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "BankAccountId",
                table: "UserProfiles");

            migrationBuilder.AddColumn<int>(
                name: "UserProfileId",
                table: "BankAccounts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserProfileId",
                table: "Addresses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_UserProfileId",
                table: "BankAccounts",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserProfileId",
                table: "Addresses",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_UserProfiles_UserProfileId",
                table: "Addresses",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_UserProfiles_UserProfileId",
                table: "BankAccounts",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_UserProfiles_UserProfileId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_UserProfiles_UserProfileId",
                table: "BankAccounts");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_BankAccounts_UserProfileId",
                table: "BankAccounts");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_UserProfileId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "UserProfiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BankAccountId",
                table: "UserProfiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_AddressId",
                table: "UserProfiles",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_BankAccountId",
                table: "UserProfiles",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_Addresses_AddressId",
                table: "UserProfiles",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_BankAccounts_BankAccountId",
                table: "UserProfiles",
                column: "BankAccountId",
                principalTable: "BankAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
