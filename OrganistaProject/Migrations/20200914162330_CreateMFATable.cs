﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganistaProject.Migrations
{
    public partial class CreateMFATable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessageFromAdmins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },

                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageFromAdmins", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                 name: "MessageFromAdmins");
        }
    }
}
