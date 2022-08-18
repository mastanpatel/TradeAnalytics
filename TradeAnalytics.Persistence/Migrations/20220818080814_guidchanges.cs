using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TradeAnalytics.Persistence.Migrations
{
    public partial class guidchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    PortfolioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.PortfolioId);
                });

            migrationBuilder.CreateTable(
                name: "TradeSecurities",
                columns: table => new
                {
                    TradeSecurityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeSecurities", x => x.TradeSecurityId);
                    table.ForeignKey(
                        name: "FK_TradeSecurities_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "PortfolioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TradeSecurityFees",
                columns: table => new
                {
                    TradeSecurityFeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeSecurityId = table.Column<int>(type: "int", nullable: false),
                    SecurityTransCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SecurityExchangeCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TurnOverFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DPCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeSecurityFees", x => x.TradeSecurityFeeId);
                    table.ForeignKey(
                        name: "FK_TradeSecurityFees_TradeSecurities_TradeSecurityId",
                        column: x => x.TradeSecurityId,
                        principalTable: "TradeSecurities",
                        principalColumn: "TradeSecurityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TradeSecurityFundamentals",
                columns: table => new
                {
                    TradeSecurityFundamentalsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeSecurityId = table.Column<int>(type: "int", nullable: false),
                    MarketCap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceToEarning = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceToBook = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceToEarning_Industry = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DebtToEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnOnEquityPerc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EarningPerShare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DividendYield = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FaceValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeSecurityFundamentals", x => x.TradeSecurityFundamentalsId);
                    table.ForeignKey(
                        name: "FK_TradeSecurityFundamentals_TradeSecurities_TradeSecurityId",
                        column: x => x.TradeSecurityId,
                        principalTable: "TradeSecurities",
                        principalColumn: "TradeSecurityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TradeSecurityPerformance",
                columns: table => new
                {
                    TradeSecurityPerformanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeSecurityId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpenPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrevClosed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Volume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Week_52_Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Week_52_High = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeSecurityPerformance", x => x.TradeSecurityPerformanceId);
                    table.ForeignKey(
                        name: "FK_TradeSecurityPerformance_TradeSecurities_TradeSecurityId",
                        column: x => x.TradeSecurityId,
                        principalTable: "TradeSecurities",
                        principalColumn: "TradeSecurityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Brokerage",
                columns: table => new
                {
                    BrokerageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeSecurityFeeId = table.Column<int>(type: "int", nullable: false),
                    BrokerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityType = table.Column<int>(type: "int", nullable: false),
                    ExchangeType = table.Column<int>(type: "int", nullable: false),
                    MinimumBrokerageAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinimumBrokeragePct = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrokerageAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brokerage", x => x.BrokerageId);
                    table.ForeignKey(
                        name: "FK_Brokerage_TradeSecurityFees_TradeSecurityFeeId",
                        column: x => x.TradeSecurityFeeId,
                        principalTable: "TradeSecurityFees",
                        principalColumn: "TradeSecurityFeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StampDuty",
                columns: table => new
                {
                    StampDutyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeSecurityFeeId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StampDutyPct = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StampDuty", x => x.StampDutyId);
                    table.ForeignKey(
                        name: "FK_StampDuty_TradeSecurityFees_TradeSecurityFeeId",
                        column: x => x.TradeSecurityFeeId,
                        principalTable: "TradeSecurityFees",
                        principalColumn: "TradeSecurityFeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TradeSecurityTransaction",
                columns: table => new
                {
                    TradeSecurityTransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeSecurityFeeId = table.Column<int>(type: "int", nullable: false),
                    TradeQuantity = table.Column<int>(type: "int", nullable: false),
                    TradeType = table.Column<int>(type: "int", nullable: false),
                    BuyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TurnOver = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProfitAndLoss = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeSecurityTransaction", x => x.TradeSecurityTransactionId);
                    table.ForeignKey(
                        name: "FK_TradeSecurityTransaction_TradeSecurityFees_TradeSecurityFeeId",
                        column: x => x.TradeSecurityFeeId,
                        principalTable: "TradeSecurityFees",
                        principalColumn: "TradeSecurityFeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "PortfolioId", "CreatedBy", "CreatedDate", "Desc", "IsActive", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "portfolioMastan is a mastan's portfolio.", true, null, null, "portfolioMastan" });

            migrationBuilder.InsertData(
                table: "TradeSecurities",
                columns: new[] { "TradeSecurityId", "CreatedBy", "CreatedDate", "Desc", "LastModifiedBy", "LastModifiedDate", "Name", "PortfolioId", "SecurityCode" },
                values: new object[] { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wipro Limited is an Indian multinational corporation that provides information technology, consulting and business process services.", null, null, "Wipro", 1, "Wipro" });

            migrationBuilder.InsertData(
                table: "TradeSecurityFundamentals",
                columns: new[] { "TradeSecurityFundamentalsId", "BookValue", "DebtToEquity", "DividendYield", "EarningPerShare", "FaceValue", "MarketCap", "PriceToBook", "PriceToEarning", "PriceToEarning_Industry", "ReturnOnEquityPerc", "TradeSecurityId" },
                values: new object[] { 1, 120.38m, 0.27m, 1.42m, 22.29m, 2m, 230618m, 3.51m, 18.93m, 28.31m, 20.18m, 1 });

            migrationBuilder.InsertData(
                table: "TradeSecurityPerformance",
                columns: new[] { "TradeSecurityPerformanceId", "Date", "OpenPrice", "PrevClosed", "TradeSecurityId", "Value", "Volume", "Week_52_High", "Week_52_Low" },
                values: new object[] { 1, new DateTime(2022, 8, 18, 13, 38, 13, 200, DateTimeKind.Local).AddTicks(5062), 420.05m, 422.00m, 1, 1340000000m, 3186358m, 739.85m, 421.75m });

            migrationBuilder.CreateIndex(
                name: "IX_Brokerage_TradeSecurityFeeId",
                table: "Brokerage",
                column: "TradeSecurityFeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StampDuty_TradeSecurityFeeId",
                table: "StampDuty",
                column: "TradeSecurityFeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TradeSecurities_PortfolioId",
                table: "TradeSecurities",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeSecurityFees_TradeSecurityId",
                table: "TradeSecurityFees",
                column: "TradeSecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeSecurityFundamentals_TradeSecurityId",
                table: "TradeSecurityFundamentals",
                column: "TradeSecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeSecurityPerformance_TradeSecurityId",
                table: "TradeSecurityPerformance",
                column: "TradeSecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeSecurityTransaction_TradeSecurityFeeId",
                table: "TradeSecurityTransaction",
                column: "TradeSecurityFeeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brokerage");

            migrationBuilder.DropTable(
                name: "StampDuty");

            migrationBuilder.DropTable(
                name: "TradeSecurityFundamentals");

            migrationBuilder.DropTable(
                name: "TradeSecurityPerformance");

            migrationBuilder.DropTable(
                name: "TradeSecurityTransaction");

            migrationBuilder.DropTable(
                name: "TradeSecurityFees");

            migrationBuilder.DropTable(
                name: "TradeSecurities");

            migrationBuilder.DropTable(
                name: "Portfolios");
        }
    }
}
