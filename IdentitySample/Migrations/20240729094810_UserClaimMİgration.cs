using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentitySample.Migrations
{
    /// <inheritdoc />
    public partial class UserClaimMİgration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LocalCLaim",
                table: "AspNetUserClaims",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalCLaim",
                table: "AspNetUserClaims");
        }
    }
}
