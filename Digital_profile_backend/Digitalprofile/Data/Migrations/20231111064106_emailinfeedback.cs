using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digitalprofile.Data.Migrations
{
    /// <inheritdoc />
    public partial class emailinfeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserFeedback",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserFeedback");
        }
    }
}
