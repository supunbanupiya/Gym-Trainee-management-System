﻿// <auto-generated />
using System;
using Gtm_Mgt_Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gtm_Mgt_Demo.Migrations
{
    [DbContext(typeof(GymDbContext))]
    [Migration("20240426061927_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gtm_Mgt_Demo.Models.BloodGroup", b =>
                {
                    b.Property<int>("BloodGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BloodGroupID"));

                    b.Property<string>("BloodGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BloodGroupID");

                    b.ToTable("BloodGroups");
                });

            modelBuilder.Entity("Gtm_Mgt_Demo.Models.GymTrainee", b =>
                {
                    b.Property<int>("TraineeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraineeId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("BloodGroupID")
                        .HasColumnType("int");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("MonthlyFee")
                        .HasColumnType("int");

                    b.Property<int>("TrainingLevelID")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("TraineeId");

                    b.HasIndex("BloodGroupID");

                    b.HasIndex("TrainingLevelID");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("Gtm_Mgt_Demo.Models.MonthlyFeeVoucher", b =>
                {
                    b.Property<int>("MonthlyFeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonthlyFeeID"));

                    b.Property<DateTime>("FeeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("MonthlyFeeID");

                    b.HasIndex("TraineeId");

                    b.ToTable("MonthlyFeeVouchers");
                });

            modelBuilder.Entity("Gtm_Mgt_Demo.Models.TrainingLevel", b =>
                {
                    b.Property<int>("TrainingLevelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainingLevelID"));

                    b.Property<string>("TrainingLevelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainingLevelID");

                    b.ToTable("TrainingLevels");
                });

            modelBuilder.Entity("Gtm_Mgt_Demo.Models.GymTrainee", b =>
                {
                    b.HasOne("Gtm_Mgt_Demo.Models.BloodGroup", "BloodGroup")
                        .WithMany("GymTrainees")
                        .HasForeignKey("BloodGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gtm_Mgt_Demo.Models.TrainingLevel", "TrainingLevel")
                        .WithMany("GymTrainees")
                        .HasForeignKey("TrainingLevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BloodGroup");

                    b.Navigation("TrainingLevel");
                });

            modelBuilder.Entity("Gtm_Mgt_Demo.Models.MonthlyFeeVoucher", b =>
                {
                    b.HasOne("Gtm_Mgt_Demo.Models.GymTrainee", "GymTrainee")
                        .WithMany()
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GymTrainee");
                });

            modelBuilder.Entity("Gtm_Mgt_Demo.Models.BloodGroup", b =>
                {
                    b.Navigation("GymTrainees");
                });

            modelBuilder.Entity("Gtm_Mgt_Demo.Models.TrainingLevel", b =>
                {
                    b.Navigation("GymTrainees");
                });
#pragma warning restore 612, 618
        }
    }
}