using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganistaProject.Migrations
{
    public partial class CreateProductAttributesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isHome",
                table: "Products",
                newName: "IsHome");

            migrationBuilder.RenameColumn(
                name: "isFeatured",
                table: "Products",
                newName: "IsFeatured");

            migrationBuilder.RenameColumn(
                name: "isApproved",
                table: "Products",
                newName: "IsApproved");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HtmlContent",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ProductId",
                table: "ProductAttributes",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HtmlContent",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "IsHome",
                table: "Products",
                newName: "isHome");

            migrationBuilder.RenameColumn(
                name: "IsFeatured",
                table: "Products",
                newName: "isFeatured");

            migrationBuilder.RenameColumn(
                name: "IsApproved",
                table: "Products",
                newName: "isApproved");
        }
    }
}
