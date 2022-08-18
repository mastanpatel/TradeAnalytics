using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TradeAnalytics.Persistence.Migrations
{
    public partial class addedIsCurrent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCurrent",
                table: "TradeSecurityPerformance",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrent",
                table: "TradeSecurityFundamentals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "TradeSecurityPerformance",
                keyColumn: "TradeSecurityPerformanceId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 18, 14, 23, 10, 617, DateTimeKind.Local).AddTicks(9038));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCurrent",
                table: "TradeSecurityPerformance");

            migrationBuilder.DropColumn(
                name: "IsCurrent",
                table: "TradeSecurityFundamentals");

            migrationBuilder.UpdateData(
                table: "TradeSecurityPerformance",
                keyColumn: "TradeSecurityPerformanceId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 18, 13, 38, 13, 200, DateTimeKind.Local).AddTicks(5062));
        }
    }
}
