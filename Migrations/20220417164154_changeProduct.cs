using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DingjiaHpmc.Migrations
{
    public partial class changeProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    detail = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "feedback",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    message = table.Column<string>(type: "text", nullable: true),
                    date_create = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_update = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_answered = table.Column<bool>(type: "bit", nullable: true),
                    client_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedback", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gallery_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gallery_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    category = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(38,0)", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    info = table.Column<string>(type: "ntext", nullable: true),
                    tech_detail = table.Column<string>(type: "ntext", nullable: true),
                    Date_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.id);
                    table.ForeignKey(
                        name: "product_FK",
                        column: x => x.category,
                        principalTable: "category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gallery",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gallery", x => x.id);
                    table.ForeignKey(
                        name: "gallery_FK",
                        column: x => x.type,
                        principalTable: "gallery_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "product_images",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    product = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_images", x => x.id);
                    table.ForeignKey(
                        name: "product_images_FK",
                        column: x => x.product,
                        principalTable: "product",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_gallery_type",
                table: "gallery",
                column: "type");

            migrationBuilder.CreateIndex(
                name: "IX_product_category",
                table: "product",
                column: "category");

            migrationBuilder.CreateIndex(
                name: "IX_product_images_product",
                table: "product_images",
                column: "product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contents");

            migrationBuilder.DropTable(
                name: "feedback");

            migrationBuilder.DropTable(
                name: "gallery");

            migrationBuilder.DropTable(
                name: "product_images");

            migrationBuilder.DropTable(
                name: "gallery_type");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
