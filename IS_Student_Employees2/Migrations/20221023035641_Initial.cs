using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS_Student_Employees2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stud_First = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stud_Last = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BYUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    International = table.Column<bool>(type: "bit", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exp_Hours = table.Column<float>(type: "real", nullable: true),
                    Semester = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: true),
                    Position_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empl_Record = table.Column<int>(type: "int", nullable: true),
                    Supervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hire_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Pay_Rate = table.Column<float>(type: "real", nullable: true),
                    Last_Pay_Increase = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Increase_Input_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Pay_Increase_Amount = table.Column<float>(type: "real", nullable: true),
                    Year_In_Program = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pay_Grad_Tuition = table.Column<bool>(type: "bit", nullable: true),
                    Name_Change_Complete = table.Column<bool>(type: "bit", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Terminated = table.Column<bool>(type: "bit", nullable: true),
                    Termination_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Qualtrics_Survey_Sent = table.Column<bool>(type: "bit", nullable: true),
                    Submitted_Form = table.Column<bool>(type: "bit", nullable: true),
                    Form_Submission_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Authorization_To_Work_Received = table.Column<bool>(type: "bit", nullable: true),
                    Authorization_To_Work_Email_Sent_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BYU_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
