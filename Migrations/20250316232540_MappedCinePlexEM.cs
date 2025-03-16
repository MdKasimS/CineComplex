using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineComplex.Migrations
{
    /// <inheritdoc />
    public partial class MappedCinePlexEM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_UserProfiles_UserProfileId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cineplexes_UserProfiles_UserProfileId",
                table: "Cineplexes");

            migrationBuilder.DropIndex(
                name: "IX_Cineplexes_UserProfileId",
                table: "Cineplexes");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "Users",
                newName: "AccountProfileId");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "Cineplexes",
                newName: "AccountProfileId");

            migrationBuilder.RenameColumn(
                name: "FranchiseOperator",
                table: "Cineplexes",
                newName: "OperatorName");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "Addresses",
                newName: "AccountProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_UserProfileId",
                table: "Addresses",
                newName: "IX_Addresses_AccountProfileId");

            migrationBuilder.AddColumn<string>(
                name: "CineplexName",
                table: "Cineplexes",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Cineplexes",
                type: "TEXT",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Cineplexes",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Cineplexes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CinemaCode = table.Column<string>(type: "TEXT", nullable: false),
                    MovieName = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false),
                    DirectorName = table.Column<string>(type: "TEXT", nullable: false),
                    ProducerName = table.Column<string>(type: "TEXT", nullable: false),
                    Language = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<double>(type: "REAL", nullable: false),
                    Story = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Theatre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    TheatreNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    CinePlexId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserProfileId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theatre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Theatre_Cineplexes_Id",
                        column: x => x.Id,
                        principalTable: "Cineplexes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Theatre_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RowNum = table.Column<int>(type: "INTEGER", nullable: false),
                    ColumnNum = table.Column<string>(type: "TEXT", nullable: false),
                    SeatAvailability = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeOfSeat = table.Column<int>(type: "INTEGER", nullable: false),
                    TheatreId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seat_Theatre_TheatreId",
                        column: x => x.TheatreId,
                        principalTable: "Theatre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Show",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlatinumSeatRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    GoldSeatRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    SilverSeatRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    TheatreId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Show", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Show_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Show_Theatre_TheatreId",
                        column: x => x.TheatreId,
                        principalTable: "Theatre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StatusOfTciket = table.Column<int>(type: "INTEGER", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ShowId = table.Column<int>(type: "INTEGER", nullable: false),
                    SeatId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Show_ShowId",
                        column: x => x.ShowId,
                        principalTable: "Show",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cineplexes_AccountProfileId",
                table: "Cineplexes",
                column: "AccountProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_TheatreId",
                table: "Seat",
                column: "TheatreId");

            migrationBuilder.CreateIndex(
                name: "IX_Show_MovieId",
                table: "Show",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Show_TheatreId",
                table: "Show",
                column: "TheatreId");

            migrationBuilder.CreateIndex(
                name: "IX_Theatre_UserProfileId",
                table: "Theatre",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_SeatId",
                table: "Ticket",
                column: "SeatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ShowId",
                table: "Ticket",
                column: "ShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_UserProfiles_AccountProfileId",
                table: "Addresses",
                column: "AccountProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cineplexes_UserProfiles_AccountProfileId",
                table: "Cineplexes",
                column: "AccountProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_UserProfiles_AccountProfileId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cineplexes_UserProfiles_AccountProfileId",
                table: "Cineplexes");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Show");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Theatre");

            migrationBuilder.DropIndex(
                name: "IX_Cineplexes_AccountProfileId",
                table: "Cineplexes");

            migrationBuilder.DropColumn(
                name: "CineplexName",
                table: "Cineplexes");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Cineplexes");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Cineplexes");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Cineplexes");

            migrationBuilder.RenameColumn(
                name: "AccountProfileId",
                table: "Users",
                newName: "UserProfileId");

            migrationBuilder.RenameColumn(
                name: "OperatorName",
                table: "Cineplexes",
                newName: "FranchiseOperator");

            migrationBuilder.RenameColumn(
                name: "AccountProfileId",
                table: "Cineplexes",
                newName: "UserProfileId");

            migrationBuilder.RenameColumn(
                name: "AccountProfileId",
                table: "Addresses",
                newName: "UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_AccountProfileId",
                table: "Addresses",
                newName: "IX_Addresses_UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Cineplexes_UserProfileId",
                table: "Cineplexes",
                column: "UserProfileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_UserProfiles_UserProfileId",
                table: "Addresses",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cineplexes_UserProfiles_UserProfileId",
                table: "Cineplexes",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
