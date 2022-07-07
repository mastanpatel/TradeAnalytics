using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TradeAnalytics.Persistence.Migrations
{
    public partial class updationofentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TradeSecurityPerformance",
                keyColumn: "TradeSecurityPerformanceId",
                keyValue: new Guid("79bfacfa-59e2-48e1-a494-ed445804221e"),
                column: "Date",
                value: new DateTime(2022, 7, 5, 12, 3, 16, 896, DateTimeKind.Local).AddTicks(2522));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TradeSecurityPerformance",
                keyColumn: "TradeSecurityPerformanceId",
                keyValue: new Guid("79bfacfa-59e2-48e1-a494-ed445804221e"),
                column: "Date",
                value: new DateTime(2022, 7, 5, 10, 11, 48, 598, DateTimeKind.Local).AddTicks(2572));
        }
    }
}
