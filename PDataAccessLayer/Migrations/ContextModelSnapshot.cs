﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PDataAccessLayer.Concrete;

namespace PDataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasKey("MedicineBarcode");

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

                    b.HasKey("PatientId");

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

                    b.Property<int>("MedicineInfoId")
                        .HasColumnType("int");

                    b.Property<int>("PatientInfoId")
                        .HasColumnType("int");

                    b.HasKey("ReceiptId");

                    b.HasIndex("MedicineInfoId");

                    b.HasIndex("PatientInfoId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("PEntityLayer.Concrete.Receipt", b =>
                {
                    b.HasOne("PEntityLayer.Concrete.MedicineInfo", "MedicineInfo")
                        .WithMany("Receipts")
                        .HasForeignKey("MedicineInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PEntityLayer.Concrete.PatientInfo", "PatientInfo")
                        .WithMany("Receipts")
                        .HasForeignKey("PatientInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicineInfo");

                    b.Navigation("PatientInfo");
                });

            modelBuilder.Entity("PEntityLayer.Concrete.MedicineInfo", b =>
                {
                    b.Navigation("Receipts");
                });

            modelBuilder.Entity("PEntityLayer.Concrete.PatientInfo", b =>
                {
                    b.Navigation("Receipts");
                });
#pragma warning restore 612, 618
        }
    }
}
