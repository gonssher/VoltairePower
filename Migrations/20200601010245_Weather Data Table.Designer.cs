﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoltairePower.Models;

namespace VoltairePower.Migrations
{
    [DbContext(typeof(VoltairePowerContext))]
    [Migration("20200601010245_Weather Data Table")]
    partial class WeatherDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VoltairePower.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustName")
                        .IsRequired()
                        .HasColumnType("nvarchar(22)")
                        .HasMaxLength(22);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompletedReg")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<int>("StreetNumber")
                        .HasColumnType("int");

                    b.Property<string>("UnitNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("VoltairePower.Models.DataGet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active_Energy_Delivered_Received_kWh")
                        .HasColumnType("int");

                    b.Property<int>("Active_Power_Kw")
                        .HasColumnType("int");

                    b.Property<int>("Current_Phase_Average_Mean_A")
                        .HasColumnType("int");

                    b.Property<int>("Diffuse_Horizontal_Radiation_WM2")
                        .HasColumnType("int");

                    b.Property<int>("Global_Horizontal_Radiation_WM2")
                        .HasColumnType("int");

                    b.Property<int>("Timestamp")
                        .HasColumnType("int");

                    b.Property<int>("Weather_Relative_Humidity_Percent")
                        .HasColumnType("int");

                    b.Property<int>("Weather_Temperature_Celsius")
                        .HasColumnType("int");

                    b.Property<int>("Wind_Direction_Degree")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LiveDataFeed");
                });

            modelBuilder.Entity("VoltairePower.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("VoltairePower.Models.SolarSheetDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Impp")
                        .HasColumnType("int");

                    b.Property<int>("InverterMakes")
                        .HasColumnType("int");

                    b.Property<int>("InverterModel")
                        .HasColumnType("int");

                    b.Property<int>("InverterSize")
                        .HasColumnType("int");

                    b.Property<int>("Isc")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSolarStrings")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfWatts")
                        .HasColumnType("int");

                    b.Property<int>("NumberofInverters")
                        .HasColumnType("int");

                    b.Property<int>("SolarSize")
                        .HasColumnType("int");

                    b.Property<int>("SolarStringsolarConnection")
                        .HasColumnType("int");

                    b.Property<string>("SolarStringsolarModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemCoeffoicient")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Vmpp")
                        .HasColumnType("int");

                    b.Property<int>("Voc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("SolarSheetDetails");
                });

            modelBuilder.Entity("VoltairePower.Models.Weather.City", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Clouds")
                        .HasColumnType("int");

                    b.Property<int>("Humidity")
                        .HasColumnType("int");

                    b.Property<int>("Pressure")
                        .HasColumnType("int");

                    b.Property<int>("Sunrise")
                        .HasColumnType("int");

                    b.Property<int>("Sunshine")
                        .HasColumnType("int");

                    b.Property<float>("Temp")
                        .HasColumnType("real");

                    b.Property<string>("Weather")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Wind")
                        .HasColumnType("real");

                    b.HasKey("Name");

                    b.ToTable("WeatherData");
                });

            modelBuilder.Entity("VoltairePower.Models.Login", b =>
                {
                    b.HasOne("VoltairePower.Models.Customer", null)
                        .WithMany("Logins")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("VoltairePower.Models.SolarSheetDetail", b =>
                {
                    b.HasOne("VoltairePower.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });
#pragma warning restore 612, 618
        }
    }
}