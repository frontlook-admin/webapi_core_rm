using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wepapi_core.Data.migration_helper
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employee_manager",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    intv_no = table.Column<long>(nullable: true),
                    f_name = table.Column<string>(nullable: true),
                    m_name = table.Column<string>(nullable: true),
                    l_name = table.Column<string>(nullable: true),
                    qualification = table.Column<string>(nullable: true),
                    school = table.Column<string>(nullable: true),
                    adr1 = table.Column<string>(nullable: true),
                    adr2 = table.Column<string>(nullable: true),
                    adr3 = table.Column<string>(nullable: true),
                    st_no = table.Column<string>(nullable: true),
                    st_name = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    pin = table.Column<string>(nullable: true),
                    employment_type = table.Column<string>(nullable: true),
                    interview_date = table.Column<DateTime>(nullable: true),
                    online_diary_no = table.Column<string>(nullable: true),
                    dispatch_no = table.Column<string>(nullable: true),
                    join_date = table.Column<DateTime>(nullable: true),
                    dated = table.Column<DateTime>(nullable: true),
                    gen_applied_post = table.Column<string>(nullable: true),
                    gen_basic_pay = table.Column<string>(nullable: true),
                    gen_pay_scale_level = table.Column<string>(nullable: true),
                    gen_payscale = table.Column<string>(nullable: true),
                    adhoc_net_salary = table.Column<string>(nullable: true),
                    adhoc_tenure = table.Column<string>(nullable: true),
                    adhoc_from_date = table.Column<DateTime>(nullable: true),
                    adhoc_to_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_manager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employee_recruit",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    intv_no = table.Column<long>(nullable: false),
                    f_name = table.Column<string>(nullable: true),
                    m_name = table.Column<string>(nullable: true),
                    l_name = table.Column<string>(nullable: true),
                    qualification = table.Column<string>(nullable: true),
                    school = table.Column<string>(nullable: true),
                    adr1 = table.Column<string>(nullable: true),
                    adr2 = table.Column<string>(nullable: true),
                    adr3 = table.Column<string>(nullable: true),
                    st_no = table.Column<string>(nullable: true),
                    st_name = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    pin = table.Column<string>(nullable: true),
                    employment_type = table.Column<string>(nullable: true),
                    interview_date = table.Column<DateTime>(nullable: true),
                    online_diary_no = table.Column<string>(nullable: true),
                    dispatch_no = table.Column<string>(nullable: true),
                    join_date = table.Column<DateTime>(nullable: true),
                    dated = table.Column<DateTime>(nullable: true),
                    gen_applied_post = table.Column<string>(nullable: true),
                    gen_basic_pay = table.Column<string>(nullable: true),
                    gen_pay_scale_level = table.Column<string>(nullable: true),
                    gen_payscale = table.Column<string>(nullable: true),
                    adhoc_net_salary = table.Column<string>(nullable: true),
                    adhoc_tenure = table.Column<string>(nullable: true),
                    adhoc_from_date = table.Column<DateTime>(nullable: true),
                    adhoc_to_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_recruit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user_manager",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    f_name = table.Column<string>(nullable: true),
                    m_name = table.Column<string>(nullable: true),
                    l_name = table.Column<string>(nullable: true),
                    p_address = table.Column<string>(nullable: true),
                    l_address = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_manager", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    f_name = table.Column<string>(nullable: true),
                    m_name = table.Column<string>(nullable: true),
                    l_name = table.Column<string>(nullable: true),
                    p_address = table.Column<string>(nullable: true),
                    l_address = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "versions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    version1 = table.Column<long>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_versions", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee_manager");

            migrationBuilder.DropTable(
                name: "employee_recruit");

            migrationBuilder.DropTable(
                name: "user_manager");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "versions");
        }
    }
}
