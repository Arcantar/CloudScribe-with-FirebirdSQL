using Microsoft.EntityFrameworkCore.Migrations;

namespace cloudscribe.DynamicPolicy.Storage.EFCore.FirebirdSQL.Migrations
{
    public partial class csdynamicpolicy20190708 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_csp_AuthPolicyClaimValue_csp_AuthPolicyClaim_ClaimRequirementId",
            //    table: "csp_AuthPolicyClaimValue");

            migrationBuilder.AddForeignKey(
                name: "FK_csp_AuthPoimRequiremen~",
                table: "csp_AuthPolicyClaimValue",
                column: "ClaimRequirementId",
                principalTable: "csp_AuthPolicyClaim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_csputhPolicyClaim_ClaimRequiremen~",
                table: "csp_AuthPolicyClaimValue");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_csp_AuthPolicyClaimValue_csp_AuthPolicyClaim_ClaimRequirementId",
            //    table: "csp_AuthPolicyClaimValue",
            //    column: "ClaimRequirementId",
            //    principalTable: "csp_AuthPolicyClaim",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
