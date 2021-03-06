﻿// <auto-generated />
using BeaconApi.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeaconApi.Migrations
{
    [DbContext(typeof(BeaconContext))]
    [Migration("20181130171419_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("BeaconApi.models.BeaconItem", b =>
                {
                    b.Property<string>("BeaconId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExtraInfo");

                    b.Property<long>("Id");

                    b.Property<string>("Name");

                    b.HasKey("BeaconId");

                    b.ToTable("beaconItems");
                });
#pragma warning restore 612, 618
        }
    }
}
