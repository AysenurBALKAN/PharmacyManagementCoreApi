﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PDataAccessLayer.Concrete;

namespace PDataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240125084445_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PEntityLayer.Concrete.MedicineInfo", b =>
                {
                    b.Property<int>("MedicineBarcode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveIngredient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Instructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Piece")
                        .HasColumnType("int");

                    b.Property<int?>("ReceiptId")
                        .HasColumnType("int");

                    b.HasKey("MedicineBarcode");

                    b.HasIndex("ReceiptId");

                    b.ToTable("MedicineInfos");
                });

            modelBuilder.Entity("PEntityLayer.Concrete.PatientInfo", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allergy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientPhoneNum")
                        .HasColumnType("int");

                    b.Property<string>("PatientSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReceiptId")
                        .HasColumnType("int");

                    b.HasKey("PatientId");

                    b.HasIndex("ReceiptId");

                    b.ToTable("PatientInfos");
                });

            modelBuilder.Entity("PEntityLayer.Concrete.Receipt", b =>
                {
                    b.Property<int>("ReceiptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("ReceiptId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("PEntityLayer.Concrete.MedicineInfo", b =>
                {
                    b.HasOne("PEntityLayer.Concrete.Receipt", "Receipt")
                        .WithMany("MedicineInfos")
                        .HasForeignKey("ReceiptId");

                    b.Navigation("Receipt");
                });

            modelBuilder.Entity("PEntityLayer.Concrete.PatientInfo", b =>
                {
                    b.HasOne("PEntityLayer.Concrete.Receipt", "Receipt")
                        .WithMany("PatientInfos")
                        .HasForeignKey("ReceiptId");

                    b.Navigation("Receipt");
                });

            modelBuilder.Entity("PEntityLayer.Concrete.Receipt", b =>
                {
                    b.Navigation("MedicineInfos");

                    b.Navigation("PatientInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
