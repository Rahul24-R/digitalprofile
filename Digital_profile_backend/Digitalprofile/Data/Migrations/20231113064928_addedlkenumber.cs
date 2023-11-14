using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digitalprofile.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedlkenumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LikeNumber",
                table: "UserFeedback",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikeNumber",
                table: "UserFeedback");
        }
    }
}
