using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubFlow.Migrations
{
    /// <inheritdoc />
    public partial class AddMembersMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_clubs",
                columns: table => new
                {
                    ClubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_clubs", x => x.ClubId);
                });

            migrationBuilder.CreateTable(
                name: "tb_users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Authorized = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_members",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberShipPayment = table.Column<double>(type: "float", nullable: false),
                    MemberLocation = table.Column<int>(type: "int", nullable: false),
                    FKUserId = table.Column<int>(type: "int", nullable: false),
                    FKCulbId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_members", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_tb_members_tb_clubs_FKCulbId",
                        column: x => x.FKCulbId,
                        principalTable: "tb_clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_members_tb_users_FKUserId",
                        column: x => x.FKUserId,
                        principalTable: "tb_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_members_FKCulbId",
                table: "tb_members",
                column: "FKCulbId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_members_FKUserId",
                table: "tb_members",
                column: "FKUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_members");

            migrationBuilder.DropTable(
                name: "tb_clubs");

            migrationBuilder.DropTable(
                name: "tb_users");
        }
    }
}
