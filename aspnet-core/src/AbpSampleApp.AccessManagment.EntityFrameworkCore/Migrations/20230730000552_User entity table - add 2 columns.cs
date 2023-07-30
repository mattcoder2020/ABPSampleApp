using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbpSampleApp.AccessManagment.Migrations
{
    /// <inheritdoc />
    public partial class Userentitytableadd2columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "AbpUsers",
                type: "varchar(15)",
                maxLength: 15,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "WechatOpenId",
                table: "AbpUsers",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "WechatOpenId",
                table: "AbpUsers");
        }
    }
}
