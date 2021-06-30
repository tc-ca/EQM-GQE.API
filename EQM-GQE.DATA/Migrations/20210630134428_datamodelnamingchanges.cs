using Microsoft.EntityFrameworkCore.Migrations;

namespace EQM_GQE.DATA.Migrations
{
    public partial class datamodelnamingchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EFFECTIVE_TO_DATE_DTE",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DATE_EFFECTIVE_END_DTE");

            migrationBuilder.RenameColumn(
                name: "EFFECTIVE_FROM_DATE_DTE",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DATE_EFFECTIVE_BEGIN_DTE");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TITLE_TXT_FR",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DOCUMENT_TITLE_FTXT");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TITLE_TXT_EN",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DOCUMENT_TITLE_ETXT");

            migrationBuilder.RenameColumn(
                name: "CHANGE_SUMMARY_TXT_FR",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "CHANGE_SUMMARY_FTXT");

            migrationBuilder.RenameColumn(
                name: "CHANGE_SUMMARY_TXT_EN",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "CHANGE_SUMMARY_ETXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TITLE_FTXT",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DOCUMENT_TITLE_TXT_FR");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TITLE_ETXT",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "DOCUMENT_TITLE_TXT_EN");

            migrationBuilder.RenameColumn(
                name: "DATE_EFFECTIVE_END_DTE",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "EFFECTIVE_TO_DATE_DTE");

            migrationBuilder.RenameColumn(
                name: "DATE_EFFECTIVE_BEGIN_DTE",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "EFFECTIVE_FROM_DATE_DTE");

            migrationBuilder.RenameColumn(
                name: "CHANGE_SUMMARY_FTXT",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "CHANGE_SUMMARY_TXT_FR");

            migrationBuilder.RenameColumn(
                name: "CHANGE_SUMMARY_ETXT",
                table: "CY001_QUESTIONNAIRE_TEMPLATE",
                newName: "CHANGE_SUMMARY_TXT_EN");
        }
    }
}
