using Microsoft.EntityFrameworkCore.Migrations;

namespace BeaconApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "beaconItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    BeaconId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ExtraInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_beaconItems", x => x.BeaconId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "beaconItems");
        }
    }
}
