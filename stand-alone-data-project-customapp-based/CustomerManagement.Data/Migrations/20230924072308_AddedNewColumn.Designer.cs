﻿// <auto-generated />
using CustomerManagement.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CustomerManagement.Data.Migrations
{
    [DbContext(typeof(CustomerManagementDbContext))]
    [Migration("20230924072308_AddedNewColumn")]
    partial class AddedNewColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CustomerManagement.Data.DBEntities.CustomerDetail", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("text");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.HasKey("CustomerId");

                    b.ToTable("CustomerDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
