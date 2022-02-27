using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAppForUcheApi.Migrations
{
    public partial class announcementupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagelink",
                table: "Announcement");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagelink",
                table: "Announcement",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
