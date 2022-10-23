using System.ComponentModel.DataAnnotations;

namespace IS_Student_Employees2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Stud_First { get; set; }

        public string Stud_Last { get; set; }
        public string? BYUID { get; set; }
        public bool? International { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public float? Exp_Hours { get; set; }
        public string? Semester { get; set; }
        public int? Year { get; set; }
        public int? Phone { get; set; }
        public string? Position_Type { get; set; }
        public string? Class_Code { get; set; }
        public int? Empl_Record { get; set; }
        public string? Supervisor { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Hire_Date { get; set; }
        public float? Pay_Rate { get; set; }
        // end of first column in presentation
        [DataType(DataType.Date)]
        public DateTime? Last_Pay_Increase { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Increase_Input_Date { get; set; }
        public float? Pay_Increase_Amount { get; set; }
        public string? Year_In_Program { get; set; }
        public bool? Pay_Grad_Tuition { get; set; }
        public bool? Name_Change_Complete { get; set; }
        public string Notes { get; set; }
        public bool? Terminated { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Termination_Date { get; set; }
        public bool? Qualtrics_Survey_Sent { get; set; }
        public bool? Submitted_Form { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Form_Submission_Date { get; set; }
        public bool? Authorization_To_Work_Received { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Authorization_To_Work_Email_Sent_Date { get; set; }
        public string? BYU_Name { get; set; }




    }
}
