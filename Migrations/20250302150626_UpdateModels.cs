using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineComplex.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cineplexes_Addresses_AddressId",
                table: "Cineplexes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cineplexes_BankAccounts_BankAccountId",
                table: "Cineplexes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cineplexes_Users_Id",
                table: "Cineplexes");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Auths_UserId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_Token",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Cineplexes_AddressId",
                table: "Cineplexes");

            migrationBuilder.DropIndex(
                name: "IX_Cineplexes_BankAccountId",
                table: "Cineplexes");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Cineplexes");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Cineplexes",
                newName: "UserProfileId");

            migrationBuilder.RenameColumn(
                name: "BankAccountId",
                table: "Cineplexes",
                newName: "NumberOfTheatres");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Cineplexes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "TEXT",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PinCode",
                table: "Addresses",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressId = table.Column<int>(type: "INTEGER", nullable: false),
                    BankAccountId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserProfiles_BankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cineplexes_UserProfileId",
                table: "Cineplexes",
                column: "UserProfileId",
                unique: true);

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
                name: "IX_UserProfiles_UserId",
                table: "UserProfiles",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cineplexes_UserProfiles_UserProfileId",
                table: "Cineplexes",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Users_UserId",
                table: "Sessions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cineplexes_UserProfiles_UserProfileId",
                table: "Cineplexes");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Users_UserId",
                table: "Sessions");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropIndex(
                name: "IX_Cineplexes_UserProfileId",
                table: "Cineplexes");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PinCode",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "Cineplexes",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "NumberOfTheatres",
                table: "Cineplexes",
                newName: "BankAccountId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Cineplexes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Cineplexes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_Token",
                table: "Sessions",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cineplexes_AddressId",
                table: "Cineplexes",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cineplexes_BankAccountId",
                table: "Cineplexes",
                column: "BankAccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cineplexes_Addresses_AddressId",
                table: "Cineplexes",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cineplexes_BankAccounts_BankAccountId",
                table: "Cineplexes",
                column: "BankAccountId",
                principalTable: "BankAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cineplexes_Users_Id",
                table: "Cineplexes",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Auths_UserId",
                table: "Sessions",
                column: "UserId",
                principalTable: "Auths",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
