using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EQM_GQE.DATA.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessLines",
                columns: table => new
                {
                    BusinessLineId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessName_FR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abbreviation_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abbreviation_FR = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessLines", x => x.BusinessLineId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentStatus",
                columns: table => new
                {
                    DocumentStatusId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentStatus_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentStatus_FR = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentStatus", x => x.DocumentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    DocumentTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentType_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType_FR = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.DocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SecurityClassifications",
                columns: table => new
                {
                    SecurityClassificationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecurityClassification_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityClassification_FR = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityClassifications", x => x.SecurityClassificationId);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Template = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessLineId = table.Column<long>(type: "bigint", nullable: false),
                    DocumentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    DocumentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    SecurityClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveStatus = table.Column<bool>(type: "bit", nullable: false),
                    DocumentVersion = table.Column<int>(type: "int", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangeSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganisationAccessibility = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questionnaires_BusinessLines_BusinessLineId",
                        column: x => x.BusinessLineId,
                        principalTable: "BusinessLines",
                        principalColumn: "BusinessLineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questionnaires_DocumentStatus_DocumentStatusId",
                        column: x => x.DocumentStatusId,
                        principalTable: "DocumentStatus",
                        principalColumn: "DocumentStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questionnaires_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questionnaires_SecurityClassifications_SecurityClassificationId",
                        column: x => x.SecurityClassificationId,
                        principalTable: "SecurityClassifications",
                        principalColumn: "SecurityClassificationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_BusinessLineId",
                table: "Questionnaires",
                column: "BusinessLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_DocumentStatusId",
                table: "Questionnaires",
                column: "DocumentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_DocumentTypeId",
                table: "Questionnaires",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_SecurityClassificationId",
                table: "Questionnaires",
                column: "SecurityClassificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questionnaires");

            migrationBuilder.DropTable(
                name: "BusinessLines");

            migrationBuilder.DropTable(
                name: "DocumentStatus");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "SecurityClassifications");
        }
    }
}
