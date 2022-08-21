using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TradeAnalytics.Persistence.Migrations
{
    public partial class dbchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TradeSecurityPerformance",
                keyColumn: "TradeSecurityPerformanceId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 21, 11, 32, 44, 150, DateTimeKind.Local).AddTicks(9894));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TradeSecurityPerformance",
                keyColumn: "TradeSecurityPerformanceId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 18, 14, 23, 10, 617, DateTimeKind.Local).AddTicks(9038));
        }
    }
}
