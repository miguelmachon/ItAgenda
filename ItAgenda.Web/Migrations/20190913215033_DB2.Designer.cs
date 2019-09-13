﻿// <auto-generated />
using System;
using ItAgenda.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ItAgenda.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190913215033_DB2")]
    partial class DB2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("DepartamentoId");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Nrc")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.It", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("EmpresaId");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("SistemaId");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("SistemaId");

                    b.ToTable("Its");
                });

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.Sistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Sistemas");
                });

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.TipoPrioridad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Nombre")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TipoPrioridades");
                });

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.TipoRequerimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TipoRequerimientos");
                });

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.Empleado", b =>
                {
                    b.HasOne("ItAgenda.Web.Data.Entities.Departamento", "Departamento")
                        .WithMany("Empleados")
                        .HasForeignKey("DepartamentoId");
                });

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.It", b =>
                {
                    b.HasOne("ItAgenda.Web.Data.Entities.Empresa", "Empresa")
                        .WithMany("Its")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("ItAgenda.Web.Data.Entities.Sistema", "Sistema")
                        .WithMany("Its")
                        .HasForeignKey("SistemaId");
                });
#pragma warning restore 612, 618
        }
    }
}