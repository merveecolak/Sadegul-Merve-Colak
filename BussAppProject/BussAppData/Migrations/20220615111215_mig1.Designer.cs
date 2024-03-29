﻿// <auto-generated />
using BussAppData.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BussAppData.Migrations
{
    [DbContext(typeof(BussDbContext))]
    [Migration("20220615111215_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("BussAppEntity.Bus", b =>
                {
                    b.Property<int>("BusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusDriverName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BusPlaque")
                        .HasColumnType("TEXT");

                    b.Property<int>("BusSeatNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("BusId");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("BussAppEntity.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("CityName")
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BussAppEntity.Expedition", b =>
                {
                    b.Property<int>("ExpeditionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BusId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExpeditionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExpeditionFinish")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExpeditionHour")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ExpeditionPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExpeditionStart")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExpeditionStation")
                        .HasColumnType("TEXT");

                    b.HasKey("ExpeditionId");

                    b.HasIndex("BusId");

                    b.ToTable("Expeditions");
                });

            modelBuilder.Entity("BussAppEntity.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("ExpeditionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Finish")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hour")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("PassengerId");

                    b.HasIndex("ExpeditionId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("BussAppEntity.Expedition", b =>
                {
                    b.HasOne("BussAppEntity.Bus", "Bus")
                        .WithMany("Expeditions")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");
                });

            modelBuilder.Entity("BussAppEntity.Passenger", b =>
                {
                    b.HasOne("BussAppEntity.Expedition", "Expedition")
                        .WithMany("passenger")
                        .HasForeignKey("ExpeditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expedition");
                });

            modelBuilder.Entity("BussAppEntity.Bus", b =>
                {
                    b.Navigation("Expeditions");
                });

            modelBuilder.Entity("BussAppEntity.Expedition", b =>
                {
                    b.Navigation("passenger");
                });
#pragma warning restore 612, 618
        }
    }
}
