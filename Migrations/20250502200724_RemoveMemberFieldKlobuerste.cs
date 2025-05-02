using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubFlow.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMemberFieldKlobuerste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Klobuerste",
                table: "tb_members");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Klobuerste",
                table: "tb_members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
