using System.ComponentModel.DataAnnotations;

namespace IS_Student_Employees2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "First")]
        public string Stud_First { get; set; }
        [Display(Name = "Last")]
        public string Stud_Last { get; set; }
        [Display(Name = "BYU ID")]
        public string? BYUID { get; set; }
        public bool? International { get; set; } = false;
        public string? Gender { get; set; }
        public string? Email { get; set; }
        [Display(Name = "Expected Hours")]
        public float? Exp_Hours { get; set; }
        public string? Semester { get; set; }
        public int? Year { get; set; }
        public int? Phone { get; set; }
        [Display(Name = "Position Type")]
        public string? Position_Type { get; set; }
        [Display(Name = "Class Code")]
        public string? Class_Code { get; set; }
        [Display(Name = "Employee Record")]
        public int? Empl_Record { get; set; }
        public string? Supervisor { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Hire Date")]
        public DateTime? Hire_Date { get; set; }
        [Display(Name = "Pay Rate")]
        public float? Pay_Rate { get; set; }
        // end of first column in presentation
        [DataType(DataType.Date)]
        [Display(Name = "Last Pay Increase")]
        public DateTime? Last_Pay_Increase { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Increase Input Date")]
        public DateTime? Increase_Input_Date { get; set; }
        [Display(Name = "Pay Increase Amount")]
        public float? Pay_Increase_Amount { get; set; }
        [Display(Name = "Year In Program")]
        public string? Year_In_Program { get; set; }
        [Display(Name = "Pay Grad Tuition")]
        public bool? Pay_Grad_Tuition { get; set; }
        [Display(Name = "Name Change Complete")]
        public bool? Name_Change_Complete { get; set; }
        public string? Notes { get; set; } = "None";
        public bool? Terminated { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Termination Date")]
        public DateTime? Termination_Date { get; set; }
        [Display(Name = "Qualtrics Survey Sent")]
        public bool? Qualtrics_Survey_Sent { get; set; }
        [Display(Name = "Submitted Form")]
        public bool? Submitted_Form { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Form Submission Date")]
        public DateTime? Form_Submission_Date { get; set; }
        [Display(Name = "Authorized To Work Received")]
        public bool? Authorization_To_Work_Received { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Auth. Email Sent Date")]
        public DateTime? Authorization_To_Work_Email_Sent_Date { get; set; }
        [Display(Name = "BYU Name")]
        public string? BYU_Name { get; set; }




    }
}
