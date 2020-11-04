﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blog_template_practice;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20201024150948_Test2")]
    partial class Test2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("blog_template_practice.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "~/Images/spencer.jpg",
                            Name = "Here in Spencer Mansion"
                        },
                        new
                        {
                            Id = 2,
                            Image = "~/Images/leon.jpg",
                            Name = "Undead, Weapons, Herbs and other arbitrary items..."
                        },
                        new
                        {
                            Id = 3,
                            Image = "~/Images/lab.jpg",
                            Name = "There's an Underground Laboratory?!"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Jill Valentine",
                            Body = "Thanks to Brad and his awful piloting skills, we have crashed and stuck in this creepy mansion! Thank God we have Wesker here to take care of us!",
                            CategoryId = 1,
                            PublishDate = new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "This Mansion is a real downer"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Barry Burton",
                            Body = "I open a door, Zombie! Go down a hall, Zombie! Check out the dormitory, a giant plant trying to eat Jill! Always something else with this place!",
                            CategoryId = 2,
                            PublishDate = new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Is it just me or are all these 'residents evil...'"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Chris Redfield",
                            Body = "I was stuck, with nowhere to go and decided to insert a couple of disks (that were hidden all too well...) into statues and the next thing I know, I'm decending into an underground laboratory!",
                            CategoryId = 3,
                            PublishDate = new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "So I drained a fountain and found a Laboratory!"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.HasOne("blog_template_practice.Models.Category", "Category")
                        .WithMany("Contents")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
