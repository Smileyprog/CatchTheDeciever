using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CatchTheDeceiver.Data.Migrations
{
    public partial class user_added_from : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserAddedApplicationUserId",
                table: "PotentialDecievers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PotentialDecievers_UserAddedApplicationUserId",
                table: "PotentialDecievers",
                column: "UserAddedApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PotentialDecievers_AspNetUsers_UserAddedApplicationUserId",
                table: "PotentialDecievers",
                column: "UserAddedApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PotentialDecievers_AspNetUsers_UserAddedApplicationUserId",
                table: "PotentialDecievers");

            migrationBuilder.DropIndex(
                name: "IX_PotentialDecievers_UserAddedApplicationUserId",
                table: "PotentialDecievers");

            migrationBuilder.DropColumn(
                name: "UserAddedApplicationUserId",
                table: "PotentialDecievers");
        }
    }
}
