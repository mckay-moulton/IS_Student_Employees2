﻿// <auto-generated />
using System;
using IS_Student_Employees2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IS_Student_Employees2.Migrations
{
    [DbContext(typeof(IS_Student_Employees2Context))]
    partial class IS_Student_Employees2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IS_Student_Employees2.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Authorization_To_Work_Email_Sent_Date")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Authorization_To_Work_Received")
                        .HasColumnType("bit");

                    b.Property<string>("BYUID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BYU_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Empl_Record")
                        .HasColumnType("int");

                    b.Property<float?>("Exp_Hours")
                        .HasColumnType("real");

                    b.Property<DateTime?>("Form_Submission_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Hire_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Increase_Input_Date")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("International")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Last_Pay_Increase")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Name_Change_Complete")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Pay_Grad_Tuition")
                        .HasColumnType("bit");

                    b.Property<float?>("Pay_Increase_Amount")
                        .HasColumnType("real");

                    b.Property<float?>("Pay_Rate")
                        .HasColumnType("real");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Position_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Qualtrics_Survey_Sent")
                        .HasColumnType("bit");

                    b.Property<string>("Semester")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stud_First")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stud_Last")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Submitted_Form")
                        .HasColumnType("bit");

                    b.Property<string>("Supervisor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Terminated")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Termination_Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.Property<string>("Year_In_Program")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
