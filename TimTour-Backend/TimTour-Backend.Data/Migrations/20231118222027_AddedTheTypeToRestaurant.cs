using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimTour_Backend.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedTheTypeToRestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Restaurants");
        }
    }
}
