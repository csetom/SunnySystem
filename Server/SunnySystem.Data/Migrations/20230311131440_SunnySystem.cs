using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SunnySystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SunnySystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "components",
                columns: table => new
                {
                    componentid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    cost = table.Column<int>(type: "INTEGER", nullable: true),
                    max = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("componentsmain_pkey", x => x.componentid);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    address = table.Column<string>(type: "TEXT", nullable: true),
                    phone = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    username = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false),
                    privilage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "warehouse",
                columns: table => new
                {
                    binid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    row = table.Column<int>(type: "INTEGER", nullable: true),
                    column = table.Column<int>(type: "INTEGER", nullable: true),
                    stash = table.Column<int>(type: "INTEGER", nullable: true),
                    componentid = table.Column<int>(type: "INTEGER", nullable: true),
                    piece = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("warehouse_pkey", x => x.binid);
                    table.ForeignKey(
                        name: "fk_warehouse_componentid",
                        column: x => x.componentid,
                        principalTable: "components",
                        principalColumn: "componentid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    project_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    project_name = table.Column<string>(type: "TEXT", nullable: true),
                    start_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    end_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.project_id);
                    table.ForeignKey(
                        name: "fk_project_customerid",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "username", "password", "privilage" },
                values: new object[] { "Admin", "Admin", -1 });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_customer_id",
                table: "Projects",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_warehouse_componentid",
                table: "warehouse",
                column: "componentid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "warehouse");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "components");
        }
    }
}
