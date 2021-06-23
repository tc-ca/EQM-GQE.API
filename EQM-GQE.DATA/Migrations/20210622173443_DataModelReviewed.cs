using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EQM_GQE.DATA.Migrations
{
    public partial class DataModelReviewed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_BusinessLines_BusinessLineId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_DocumentStatus_DocumentStatusId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_DocumentTypes_DocumentTypeId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_SecurityClassifications_SecurityClassificati~",
                table: "Questionnaires");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SecurityClassifications",
                table: "SecurityClassifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questionnaires",
                table: "Questionnaires");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentTypes",
                table: "DocumentTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentStatus",
                table: "DocumentStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BusinessLines",
                table: "BusinessLines");

            migrationBuilder.RenameTable(
                name: "SecurityClassifications",
                newName: "TY003_SECURITY_CLASSIFICATION");

            migrationBuilder.RenameTable(
                name: "Questionnaires",
                newName: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.RenameTable(
                name: "DocumentTypes",
                newName: "TY002_DOCUMENT_TYPE");

            migrationBuilder.RenameTable(
                name: "DocumentStatus",
                newName: "TY004_DOCUMENT_STATUS");

            migrationBuilder.RenameTable(
                name: "BusinessLines",
                newName: "TY001_BUSINESS_LINE");

            migrationBuilder.RenameColumn(
                name: "SecurityClassification_FR",
                table: "TY003_SECURITY_CLASSIFICATION",
                newName: "CLASSIFICATION_FRBL");

            migrationBuilder.RenameColumn(
                name: "SecurityClassification_EN",
                table: "TY003_SECURITY_CLASSIFICATION",
                newName: "CLASSIFICATION_ELBL");

            migrationBuilder.RenameColumn(
                name: "SecurityClassificationId",
                table: "TY003_SECURITY_CLASSIFICATION",
                newName: "SECURITY_CLASSIFICATION_CD");

            migrationBuilder.RenameColumn(
                name: "Template",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "TEMPLATE_TXT");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "PARENT_TEMPLATE_ID");

            migrationBuilder.RenameColumn(
                name: "OrganisationAccessibility",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "ORGANIZATION_ACCESSIBILITY_IND");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DATE_LAST_UPDATE_DTE");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "USER_UPDATE_ID");

            migrationBuilder.RenameColumn(
                name: "EffectiveDate",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "EFFECTIVE_DATE_DTE");

            migrationBuilder.RenameColumn(
                name: "DocumentVersion",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DOCUMENT_VERSION_NUM");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DATE_CREATED_DTE");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "USER_CREATE_ID");

            migrationBuilder.RenameColumn(
                name: "ActiveStatus",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "ACTIVE_STATUS_IND");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "QUESTIONNAIRE_TEMPLATE_ID");

            migrationBuilder.RenameColumn(
                name: "DocumentTitle",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DOCUMENT_TITLE_TXT_FR");

            migrationBuilder.RenameColumn(
                name: "ChangeSummary",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DOCUMENT_TITLE_TXT_EN");

            migrationBuilder.RenameIndex(
                name: "IX_Questionnaires_SecurityClassificationId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "IX_CY001_QUESTIONNAIRE_TEMPLATE_SecurityClassificationId");

            migrationBuilder.RenameIndex(
                name: "IX_Questionnaires_DocumentTypeId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DocumentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Questionnaires_DocumentStatusId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DocumentStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Questionnaires_BusinessLineId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "IX_CY001_QUESTIONNAIRE_TEMPLATE_BusinessLineId");

            migrationBuilder.RenameColumn(
                name: "DocumentType_FR",
                table: "TY002_DOCUMENT_TYPE",
                newName: "DOCUMENT_TYPE_FRBL");

            migrationBuilder.RenameColumn(
                name: "DocumentType_EN",
                table: "TY002_DOCUMENT_TYPE",
                newName: "DOCUMENT_TYPE_ELBL");

            migrationBuilder.RenameColumn(
                name: "DocumentTypeId",
                table: "TY002_DOCUMENT_TYPE",
                newName: "DOCUMENT_TYPE_CD");

            migrationBuilder.RenameColumn(
                name: "DocumentStatus_FR",
                table: "TY004_DOCUMENT_STATUS",
                newName: "DOCUMENT_STATUS_FLBL");

            migrationBuilder.RenameColumn(
                name: "DocumentStatus_EN",
                table: "TY004_DOCUMENT_STATUS",
                newName: "DOCUMENT_STATUS_ELBL");

            migrationBuilder.RenameColumn(
                name: "DocumentStatusId",
                table: "TY004_DOCUMENT_STATUS",
                newName: "DOCUMENT_STATUS_CD");

            migrationBuilder.RenameColumn(
                name: "BusinessName_FR",
                table: "TY001_BUSINESS_LINE",
                newName: "BUSINESS_NAME_FNM");

            migrationBuilder.RenameColumn(
                name: "BusinessName_EN",
                table: "TY001_BUSINESS_LINE",
                newName: "BUSINESS_NAME_ENM");

            migrationBuilder.RenameColumn(
                name: "Abbreviation_FR",
                table: "TY001_BUSINESS_LINE",
                newName: "BUSINESS_ABBR_FRBL");

            migrationBuilder.RenameColumn(
                name: "Abbreviation_EN",
                table: "TY001_BUSINESS_LINE",
                newName: "BUSINESS_ABBR_ELBL");

            migrationBuilder.RenameColumn(
                name: "BusinessLineId",
                table: "TY001_BUSINESS_LINE",
                newName: "BUSINESS_LINE_CD");

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_CREATED_DTE",
                table: "TY003_SECURITY_CLASSIFICATION",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_DELETED_DTE",
                table: "TY003_SECURITY_CLASSIFICATION",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_LAST_UPDATE_DTE",
                table: "TY003_SECURITY_CLASSIFICATION",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<long>(
                name: "SecurityClassificationId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "DocumentTypeId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "DocumentStatusId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "BusinessLineId",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "CHANGE_SUMMARY_TXT_EN",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CHANGE_SUMMARY_TXT_FR",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_DELETED_DTE",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_CREATED_DTE",
                table: "TY002_DOCUMENT_TYPE",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_DELETED_DTE",
                table: "TY002_DOCUMENT_TYPE",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_LAST_UPDATE_DTE",
                table: "TY002_DOCUMENT_TYPE",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_CREATED_DTE",
                table: "TY004_DOCUMENT_STATUS",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_DELETED_DTE",
                table: "TY004_DOCUMENT_STATUS",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_LAST_UPDATE_DTE",
                table: "TY004_DOCUMENT_STATUS",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_CREATED_DTE",
                table: "TY001_BUSINESS_LINE",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_DELETED_DTE",
                table: "TY001_BUSINESS_LINE",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_LAST_UPDATE_DTE",
                table: "TY001_BUSINESS_LINE",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TY003_SECURITY_CLASSIFICATION",
                table: "TY003_SECURITY_CLASSIFICATION",
                column: "SECURITY_CLASSIFICATION_CD");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CY001_QUESTIONNAIRE_TEMPLATE",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                column: "QUESTIONNAIRE_TEMPLATE_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TY002_DOCUMENT_TYPE",
                table: "TY002_DOCUMENT_TYPE",
                column: "DOCUMENT_TYPE_CD");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TY004_DOCUMENT_STATUS",
                table: "TY004_DOCUMENT_STATUS",
                column: "DOCUMENT_STATUS_CD");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TY001_BUSINESS_LINE",
                table: "TY001_BUSINESS_LINE",
                column: "BUSINESS_LINE_CD");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_TY004_DOCUMENT_STATUS",
                table: "TY004_DOCUMENT_STATUS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TY003_SECURITY_CLASSIFICATION",
                table: "TY003_SECURITY_CLASSIFICATION");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TY002_DOCUMENT_TYPE",
                table: "TY002_DOCUMENT_TYPE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TY001_BUSINESS_LINE",
                table: "TY001_BUSINESS_LINE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CY001_QUESTIONNAIRE_TEMPLATE",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "DATE_CREATED_DTE",
                table: "TY004_DOCUMENT_STATUS");

            migrationBuilder.DropColumn(
                name: "DATE_DELETED_DTE",
                table: "TY004_DOCUMENT_STATUS");

            migrationBuilder.DropColumn(
                name: "DATE_LAST_UPDATE_DTE",
                table: "TY004_DOCUMENT_STATUS");

            migrationBuilder.DropColumn(
                name: "DATE_CREATED_DTE",
                table: "TY003_SECURITY_CLASSIFICATION");

            migrationBuilder.DropColumn(
                name: "DATE_DELETED_DTE",
                table: "TY003_SECURITY_CLASSIFICATION");

            migrationBuilder.DropColumn(
                name: "DATE_LAST_UPDATE_DTE",
                table: "TY003_SECURITY_CLASSIFICATION");

            migrationBuilder.DropColumn(
                name: "DATE_CREATED_DTE",
                table: "TY002_DOCUMENT_TYPE");

            migrationBuilder.DropColumn(
                name: "DATE_DELETED_DTE",
                table: "TY002_DOCUMENT_TYPE");

            migrationBuilder.DropColumn(
                name: "DATE_LAST_UPDATE_DTE",
                table: "TY002_DOCUMENT_TYPE");

            migrationBuilder.DropColumn(
                name: "DATE_CREATED_DTE",
                table: "TY001_BUSINESS_LINE");

            migrationBuilder.DropColumn(
                name: "DATE_DELETED_DTE",
                table: "TY001_BUSINESS_LINE");

            migrationBuilder.DropColumn(
                name: "DATE_LAST_UPDATE_DTE",
                table: "TY001_BUSINESS_LINE");

            migrationBuilder.DropColumn(
                name: "CHANGE_SUMMARY_TXT_EN",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "CHANGE_SUMMARY_TXT_FR",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.DropColumn(
                name: "DATE_DELETED_DTE",
                table: "CY001_QUESTIONNAIRE_TEMPLATE");

            migrationBuilder.RenameTable(
                name: "TY004_DOCUMENT_STATUS",
                newName: "DocumentStatus");

            migrationBuilder.RenameTable(
                name: "TY003_SECURITY_CLASSIFICATION",
                newName: "SecurityClassifications");

            migrationBuilder.RenameTable(
                name: "TY002_DOCUMENT_TYPE",
                newName: "DocumentTypes");

            migrationBuilder.RenameTable(
                name: "TY001_BUSINESS_LINE",
                newName: "BusinessLines");

            migrationBuilder.RenameTable(
                name: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "Questionnaires");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_STATUS_FLBL",
                table: "DocumentStatus",
                newName: "DocumentStatus_FR");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_STATUS_ELBL",
                table: "DocumentStatus",
                newName: "DocumentStatus_EN");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_STATUS_CD",
                table: "DocumentStatus",
                newName: "DocumentStatusId");

            migrationBuilder.RenameColumn(
                name: "CLASSIFICATION_FRBL",
                table: "SecurityClassifications",
                newName: "SecurityClassification_FR");

            migrationBuilder.RenameColumn(
                name: "CLASSIFICATION_ELBL",
                table: "SecurityClassifications",
                newName: "SecurityClassification_EN");

            migrationBuilder.RenameColumn(
                name: "SECURITY_CLASSIFICATION_CD",
                table: "SecurityClassifications",
                newName: "SecurityClassificationId");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TYPE_FRBL",
                table: "DocumentTypes",
                newName: "DocumentType_FR");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TYPE_ELBL",
                table: "DocumentTypes",
                newName: "DocumentType_EN");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TYPE_CD",
                table: "DocumentTypes",
                newName: "DocumentTypeId");

            migrationBuilder.RenameColumn(
                name: "BUSINESS_NAME_FNM",
                table: "BusinessLines",
                newName: "BusinessName_FR");

            migrationBuilder.RenameColumn(
                name: "BUSINESS_NAME_ENM",
                table: "BusinessLines",
                newName: "BusinessName_EN");

            migrationBuilder.RenameColumn(
                name: "BUSINESS_ABBR_FRBL",
                table: "BusinessLines",
                newName: "Abbreviation_FR");

            migrationBuilder.RenameColumn(
                name: "BUSINESS_ABBR_ELBL",
                table: "BusinessLines",
                newName: "Abbreviation_EN");

            migrationBuilder.RenameColumn(
                name: "BUSINESS_LINE_CD",
                table: "BusinessLines",
                newName: "BusinessLineId");

            migrationBuilder.RenameColumn(
                name: "USER_UPDATE_ID",
                table: "Questionnaires",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "USER_CREATE_ID",
                table: "Questionnaires",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "TEMPLATE_TXT",
                table: "Questionnaires",
                newName: "Template");

            migrationBuilder.RenameColumn(
                name: "PARENT_TEMPLATE_ID",
                table: "Questionnaires",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "ORGANIZATION_ACCESSIBILITY_IND",
                table: "Questionnaires",
                newName: "OrganisationAccessibility");

            migrationBuilder.RenameColumn(
                name: "EFFECTIVE_DATE_DTE",
                table: "Questionnaires",
                newName: "EffectiveDate");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_VERSION_NUM",
                table: "Questionnaires",
                newName: "DocumentVersion");

            migrationBuilder.RenameColumn(
                name: "DATE_LAST_UPDATE_DTE",
                table: "Questionnaires",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "DATE_CREATED_DTE",
                table: "Questionnaires",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "ACTIVE_STATUS_IND",
                table: "Questionnaires",
                newName: "ActiveStatus");

            migrationBuilder.RenameColumn(
                name: "QUESTIONNAIRE_TEMPLATE_ID",
                table: "Questionnaires",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TITLE_TXT_FR",
                table: "Questionnaires",
                newName: "DocumentTitle");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TITLE_TXT_EN",
                table: "Questionnaires",
                newName: "ChangeSummary");

            migrationBuilder.RenameIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_SecurityClassificationId",
                table: "Questionnaires",
                newName: "IX_Questionnaires_SecurityClassificationId");

            migrationBuilder.RenameIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DocumentTypeId",
                table: "Questionnaires",
                newName: "IX_Questionnaires_DocumentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_DocumentStatusId",
                table: "Questionnaires",
                newName: "IX_Questionnaires_DocumentStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_CY001_QUESTIONNAIRE_TEMPLATE_BusinessLineId",
                table: "Questionnaires",
                newName: "IX_Questionnaires_BusinessLineId");

            migrationBuilder.AlterColumn<long>(
                name: "SecurityClassificationId",
                table: "Questionnaires",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DocumentTypeId",
                table: "Questionnaires",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DocumentStatusId",
                table: "Questionnaires",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "BusinessLineId",
                table: "Questionnaires",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentStatus",
                table: "DocumentStatus",
                column: "DocumentStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SecurityClassifications",
                table: "SecurityClassifications",
                column: "SecurityClassificationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentTypes",
                table: "DocumentTypes",
                column: "DocumentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BusinessLines",
                table: "BusinessLines",
                column: "BusinessLineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questionnaires",
                table: "Questionnaires",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_BusinessLines_BusinessLineId",
                table: "Questionnaires",
                column: "BusinessLineId",
                principalTable: "BusinessLines",
                principalColumn: "BusinessLineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_DocumentStatus_DocumentStatusId",
                table: "Questionnaires",
                column: "DocumentStatusId",
                principalTable: "DocumentStatus",
                principalColumn: "DocumentStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_DocumentTypes_DocumentTypeId",
                table: "Questionnaires",
                column: "DocumentTypeId",
                principalTable: "DocumentTypes",
                principalColumn: "DocumentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_SecurityClassifications_SecurityClassificati~",
                table: "Questionnaires",
                column: "SecurityClassificationId",
                principalTable: "SecurityClassifications",
                principalColumn: "SecurityClassificationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
