using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared_Traveling.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CityOfDeparture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressOfDeparture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HourOfDeparture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityOfDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressOfDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HourOfDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableSeats = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AprovedRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TravelPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AprovedRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AprovedRequests_TravelPosts_TravelPostId",
                        column: x => x.TravelPostId,
                        principalTable: "TravelPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AprovedRequests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelPostId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_TravelPosts_TravelPostId",
                        column: x => x.TravelPostId,
                        principalTable: "TravelPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AprovedRequests_TravelPostId",
                table: "AprovedRequests",
                column: "TravelPostId");

            migrationBuilder.CreateIndex(
                name: "IX_AprovedRequests_UserId",
                table: "AprovedRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TravelPostId",
                table: "Requests",
                column: "TravelPostId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelPosts_UserId",
                table: "TravelPosts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AprovedRequests");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "TravelPosts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
