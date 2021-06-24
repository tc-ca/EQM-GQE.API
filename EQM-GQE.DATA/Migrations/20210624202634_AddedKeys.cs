using Microsoft.EntityFrameworkCore.Migrations;

namespace EQM_GQE.DATA.Migrations
{
    public partial class AddedKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY001_BUSINESS_LINE_BusinessLi~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY002_DOCUMENT_TYPE_DocumentTy~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY003_SECURITY_CLASSIFICATION_~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY004_DOCUMENT_STATUS_Document~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_BusinessLineId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DocumentStatusId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DocumentTypeId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_SecurityClassificationId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "BusinessLineId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "DocumentStatusId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "DocumentTypeId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "SecurityClassificationId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.AddColumn<int>(
                name: "BUSINESS_LINE_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DOCUMENT_STATUS_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DOCUMENT_TYPE_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SECURITY_CLASSIFICATION_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_BUSINESS_LINE_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "BUSINESS_LINE_CD");

            migrationBuilder.CreateIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DOCUMENT_STATUS_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "DOCUMENT_STATUS_CD");

            migrationBuilder.CreateIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DOCUMENT_TYPE_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "DOCUMENT_TYPE_CD");

            migrationBuilder.CreateIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_SECURITY_CLASSIFICATION_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "SECURITY_CLASSIFICATION_CD");

            migrationBuilder.AddForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY001_BUSINESS_LINE_BUSINESS_L~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "BUSINESS_LINE_CD",
                principalTable: "TY001_BUSINESS_LINE",
                principalColumn: "BUSINESS_LINE_CD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY002_DOCUMENT_TYPE_DOCUMENT_T~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "DOCUMENT_TYPE_CD",
                principalTable: "TY002_DOCUMENT_TYPE",
                principalColumn: "DOCUMENT_TYPE_CD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY003_SECURITY_CLASSIFICATION_~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "SECURITY_CLASSIFICATION_CD",
                principalTable: "TY003_SECURITY_CLASSIFICATION",
                principalColumn: "SECURITY_CLASSIFICATION_CD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY004_DOCUMENT_STATUS_DOCUMENT~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "DOCUMENT_STATUS_CD",
                principalTable: "TY004_DOCUMENT_STATUS",
                principalColumn: "DOCUMENT_STATUS_CD",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY001_BUSINESS_LINE_BUSINESS_L~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY002_DOCUMENT_TYPE_DOCUMENT_T~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY003_SECURITY_CLASSIFICATION_~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY004_DOCUMENT_STATUS_DOCUMENT~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_BUSINESS_LINE_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DOCUMENT_STATUS_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DOCUMENT_TYPE_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_SECURITY_CLASSIFICATION_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "BUSINESS_LINE_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "DOCUMENT_STATUS_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "DOCUMENT_TYPE_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "SECURITY_CLASSIFICATION_CD",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.AddColumn<int>(
                name: "BusinessLineId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentStatusId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentTypeId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecurityClassificationId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_BusinessLineId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "BusinessLineId");

            migrationBuilder.CreateIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DocumentStatusId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "DocumentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DocumentTypeId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_SecurityClassificationId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "SecurityClassificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY001_BUSINESS_LINE_BusinessLi~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "BusinessLineId",
                principalTable: "TY001_BUSINESS_LINE",
                principalColumn: "BUSINESS_LINE_CD",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY002_DOCUMENT_TYPE_DocumentTy~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "DocumentTypeId",
                principalTable: "TY002_DOCUMENT_TYPE",
                principalColumn: "DOCUMENT_TYPE_CD",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY003_SECURITY_CLASSIFICATION_~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "SecurityClassificationId",
                principalTable: "TY003_SECURITY_CLASSIFICATION",
                principalColumn: "SECURITY_CLASSIFICATION_CD",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CY001_QUESTIONNAIRE_TEMPLATE_TY004_DOCUMENT_STATUS_Document~",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "DocumentStatusId",
                principalTable: "TY004_DOCUMENT_STATUS",
                principalColumn: "DOCUMENT_STATUS_CD",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
