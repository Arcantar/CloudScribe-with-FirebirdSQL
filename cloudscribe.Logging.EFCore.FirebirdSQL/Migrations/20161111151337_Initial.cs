using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cloudscribe.Logging.EFCore.FirebirdSQL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cs_SystemLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("FbSql:ValueGeneratedOnAdd", true),
                    Culture = table.Column<string>(maxLength: 10, nullable: true),
                    EventId = table.Column<int>(nullable: false),
                    IpAddress = table.Column<string>(maxLength: 50, nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false),
                    LogLevel = table.Column<string>(maxLength: 20, nullable: true),
                    Logger = table.Column<string>(maxLength: 255, nullable: true),
                    Message = table.Column<string>(nullable: true),
                    ShortUrl = table.Column<string>(maxLength: 255, nullable: true),
                    StateJson = table.Column<string>(nullable: true),
                    Thread = table.Column<string>(maxLength: 255, nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cs_SystemLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cs_SystemLog");
        }
    }
}
