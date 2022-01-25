﻿// <auto-generated />
using System;
using LibraryMVC.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryMVC.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20220125125748_PublishYearSettedRequired")]
    partial class PublishYearSettedRequired
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryMVC.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BookPublishYear")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookAuthor = "Lev Tolstoy",
                            BookName = "Anna Karenina",
                            BookPublishYear = 1877,
                            Description = "Regarded as Tolstoy's most important novel, Anna Karenina is an absolutely heartbreaking and heartbreaking story. Trapped in her loveless marriage, Anna does the unthinkable and gives up everything she has for the handsome Count Vronsky."
                        },
                        new
                        {
                            Id = 2,
                            BookAuthor = "Harper Lee",
                            BookName = "To Kill a Mockingbird",
                            BookPublishYear = 1960,
                            Description = "One of the most beloved stories of all time, translated into more than forty languages, laying the groundwork for an Oscar-winning feature film and a Pulitzer Prize-winning film that was chosen as one of the best novels of the twentieth century, To Kill a Mockingbird is a gripping, heart-wrenching and heart-wrenching story set in America's south, poisoned by brutal prejudice. A remarkable growth story. In a world of bewitching beauty and brutal inequalities, the story of a man who risks everything to defend a \"nigger\" who has been wrongly accused of a horrific crime is told through the eyes of a child protagonist."
                        },
                        new
                        {
                            Id = 3,
                            BookAuthor = "Jen Jacques Rousseau",
                            BookName = "Emile",
                            BookPublishYear = 1762,
                            Description = "Emile, or On Education, or Emile, or the Treatise on Education, is a treatise on the nature of education and the nature of man, written by Jean-Jacques Rousseau. Considered by Rousseau \"the best and most important of all my writings\"."
                        },
                        new
                        {
                            Id = 4,
                            BookAuthor = "Oğuz Atay",
                            BookName = "Bir Bilim Adamının Romanı",
                            BookPublishYear = 1975,
                            Description = "A Scientist's Novel, Oğuz Atay's professor from ITU Faculty of Civil Engineering. Dr. It is the novel of Mustafa Inan in which he tells his life story."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
