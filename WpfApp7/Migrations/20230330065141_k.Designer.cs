﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WpfApp7.DB;

#nullable disable

namespace WpfApp7.Migrations
{
    [DbContext(typeof(BillingContext))]
    [Migration("20230330065141_k")]
    partial class k
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WpfApp7.DB.Bill", b =>
                {
                    b.Property<Guid>("IdBill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AccountIdAccount")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.HasKey("IdBill");

                    b.HasIndex("AccountIdAccount");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("WpfApp7.DB.account", b =>
                {
                    b.Property<Guid>("IdAccount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdAccount");

                    b.ToTable("Acoounts");
                });

            modelBuilder.Entity("WpfApp7.DB.Bill", b =>
                {
                    b.HasOne("WpfApp7.DB.account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountIdAccount");

                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}
