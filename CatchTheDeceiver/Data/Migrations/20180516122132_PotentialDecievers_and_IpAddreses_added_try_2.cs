using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CatchTheDeceiver.Data.Migrations
{
    public partial class PotentialDecievers_and_IpAddreses_added_try_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IpAddresses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpAddresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PotentialDecievers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IpAddressID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotentialDecievers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PotentialDecievers_IpAddresses_IpAddressID",
                        column: x => x.IpAddressID,
                        principalTable: "IpAddresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PotentialDecievers_IpAddressID",
                table: "PotentialDecievers",
                column: "IpAddressID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PotentialDecievers");

            migrationBuilder.DropTable(
                name: "IpAddresses");
        }
    }
}
