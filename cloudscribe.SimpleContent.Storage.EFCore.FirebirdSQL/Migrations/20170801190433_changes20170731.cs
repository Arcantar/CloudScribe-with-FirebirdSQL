using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace cloudscribe.SimpleContent.Storage.EFCore.FirebirdSQL.Migrations
{
    public partial class changes20170731 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DisableEditor",
                table: "cs_Page",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisableEditor",
                table: "cs_Page");
        }
    }
}
