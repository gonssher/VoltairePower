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
    [Migration("20200910144607_changing events")]
    partial class changingevents
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VoltairePower.Models.CheckList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<bool>("Mac_out")
                        .HasColumnType("bit");

                    b.Property<bool>("Marray_tilt")
                        .HasColumnType("bit");

                    b.Property<bool>("Mbattery_test")
                        .HasColumnType("bit");

                    b.Property<bool>("Mcharge_ctrl_settings")
                        .HasColumnType("bit");

                    b.Property<bool>("Mclean_elect_equipment")
                        .HasColumnType("bit");

                    b.Property<bool>("Menergy_prod")
                        .HasColumnType("bit");

                    b.Property<bool>("Minspect_array_mount")
                        .HasColumnType("bit");

                    b.Property<bool>("Minspect_panel")
                        .HasColumnType("bit");

                    b.Property<bool>("Mmonitor_volt_current")
                        .HasColumnType("bit");

                    b.Property<bool>("Mpanel_clean")
                        .HasColumnType("bit");

                    b.Property<bool>("Mshading_issue")
                        .HasColumnType("bit");

                    b.Property<bool>("Sac_out")
                        .HasColumnType("bit");

                    b.Property<bool>("Sarray_tilt")
                        .HasColumnType("bit");

                    b.Property<bool>("Sbattery_test")
                        .HasColumnType("bit");

                    b.Property<bool>("Scharge_ctrl_settings")
                        .HasColumnType("bit");

                    b.Property<bool>("Sclean_elect_equipment")
                        .HasColumnType("bit");

                    b.Property<bool>("Senergy_prod")
                        .HasColumnType("bit");

                    b.Property<bool>("Sinspect_array_mount")
                        .HasColumnType("bit");

                    b.Property<bool>("Sinspect_panel")
                        .HasColumnType("bit");

                    b.Property<bool>("Smonitor_volt_current")
                        .HasColumnType("bit");

                    b.Property<bool>("Spanel_clean")
                        .HasColumnType("bit");

                    b.Property<bool>("Sshading_issue")
                        .HasColumnType("bit");

                    b.Property<bool>("ac_out")
                        .HasColumnType("bit");

                    b.Property<bool>("array_tilt")
                        .HasColumnType("bit");

                    b.Property<bool>("battery_test")
                        .HasColumnType("bit");

                    b.Property<bool>("charge_ctrl_settings")
                        .HasColumnType("bit");

                    b.Property<bool>("clean_elect_equipment")
                        .HasColumnType("bit");

                    b.Property<bool>("energy_prod")
                        .HasColumnType("bit");

                    b.Property<bool>("inspect_array_mount")
                        .HasColumnType("bit");

                    b.Property<bool>("inspect_panel")
                        .HasColumnType("bit");

                    b.Property<bool>("monitor_volt_current")
                        .HasColumnType("bit");

                    b.Property<bool>("panel_clean")
                        .HasColumnType("bit");

                    b.Property<bool>("shading_issue")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("CheckLists");
                });

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

            modelBuilder.Entity("VoltairePower.Models.Data_Layer.PopulatingLineGraph", b =>
                {
                    b.Property<double>("Id")
                        .HasColumnType("float");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<double>("TranslatedVoltage")
                        .HasColumnType("float");

                    b.Property<double>("Voltage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("LineChart");
                });

            modelBuilder.Entity("VoltairePower.Models.Graph_Tables.PredictedActual", b =>
                {
                    b.Property<double>("Id")
                        .HasColumnType("float");

                    b.Property<double>("ExtraplatedCurrent")
                        .HasColumnType("float");

                    b.Property<double>("PredictedCurrent")
                        .HasColumnType("float");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PredictedData");
                });

            modelBuilder.Entity("VoltairePower.Models.LiveFeedData", b =>
                {
                    b.Property<double>("Id")
                        .HasColumnType("float");

                    b.Property<double>("Active_Energy_Delivered_Received_kWh")
                        .HasColumnType("float");

                    b.Property<double>("Active_Power_Kw")
                        .HasColumnType("float");

                    b.Property<double>("Current_Phase_Average_Mean_A")
                        .HasColumnType("float");

                    b.Property<double>("Diffuse_Horizontal_Radiation_WM2")
                        .HasColumnType("float");

                    b.Property<double>("Global_Horizontal_Radiation_WM2")
                        .HasColumnType("float");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<double>("Weather_Relative_Humidity_Percent")
                        .HasColumnType("float");

                    b.Property<double>("Weather_Temperature_Celsius")
                        .HasColumnType("float");

                    b.Property<double>("Wind_Direction_Degree")
                        .HasColumnType("float");

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

                    b.Property<string>("AcFreqNorminal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AcOpVolt")
                        .HasColumnType("float");

                    b.Property<string>("AcVolt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrayLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrayLocationLong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("DcInput")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("InverterSize")
                        .HasColumnType("float");

                    b.Property<double>("LengthOfString")
                        .HasColumnType("float");

                    b.Property<string>("MaxContinuousOC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MaxDc")
                        .HasColumnType("float");

                    b.Property<double>("ModuleOpenShortCircuit")
                        .HasColumnType("float");

                    b.Property<double>("ModulePerSeries")
                        .HasColumnType("float");

                    b.Property<double>("ModuleShortCircuit")
                        .HasColumnType("float");

                    b.Property<double>("ModuleTempCoeff")
                        .HasColumnType("float");

                    b.Property<int>("NumberOfSolarStrings")
                        .HasColumnType("int");

                    b.Property<int>("NumberofInverters")
                        .HasColumnType("int");

                    b.Property<double>("PeakInvEff")
                        .HasColumnType("float");

                    b.Property<double>("PeakPwrTv")
                        .HasColumnType("float");

                    b.Property<double>("PowerFact")
                        .HasColumnType("float");

                    b.Property<string>("SolarModuleMake")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolarModulePwr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SolarSize")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("TypeofWire")
                        .HasColumnType("int");

                    b.Property<int>("WireGPerStr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("SolarSheetDetails");
                });

            modelBuilder.Entity("VoltairePower.Models.UnplaanedEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("EventCause")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelfActionTaken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.ToTable("UnplannedEvent");
                });

            modelBuilder.Entity("VoltairePower.Models.Weather.City", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Clouds")
                        .HasColumnType("int");

                    b.Property<int>("Humidity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<DateTime>("WeatherDateTime")
                        .HasColumnType("datetime2");

                    b.Property<float>("Wind")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("WeatherData");
                });

            modelBuilder.Entity("VoltairePower.Models.CheckList", b =>
                {
                    b.HasOne("VoltairePower.Models.Customer", "Customer")
                        .WithOne("CheckList")
                        .HasForeignKey("VoltairePower.Models.CheckList", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VoltairePower.Models.Login", b =>
                {
                    b.HasOne("VoltairePower.Models.Customer", "Customer")
                        .WithMany("Logins")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("VoltairePower.Models.SolarSheetDetail", b =>
                {
                    b.HasOne("VoltairePower.Models.Customer", "Customer")
                        .WithOne("SolarSheetDetail")
                        .HasForeignKey("VoltairePower.Models.SolarSheetDetail", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VoltairePower.Models.UnplaanedEvent", b =>
                {
                    b.HasOne("VoltairePower.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
