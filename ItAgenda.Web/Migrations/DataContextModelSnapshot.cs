﻿// <auto-generated />
using System;
using ItAgenda.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ItAgenda.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Email")
                        .IsRequired()
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

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.Requerimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmpleadoId");

                    b.Property<DateTime>("FechaAprobacion");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<int?>("TipoPrioridadId");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("TipoPrioridadId");

                    b.ToTable("Requerimentos");
                });

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.RequerimientoDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Detalle")
                        .HasMaxLength(50);

                    b.Property<int?>("RequerimentoId");

                    b.HasKey("Id");

                    b.HasIndex("RequerimentoId");

                    b.ToTable("RequerimientoDetalles");
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

                    b.Property<string>("Nombre")
                        .IsRequired()
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

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.Requerimento", b =>
                {
                    b.HasOne("ItAgenda.Web.Data.Entities.Empleado", "Empleado")
                        .WithMany("Requerimentos")
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("ItAgenda.Web.Data.Entities.TipoPrioridad", "TipoPrioridad")
                        .WithMany("Requerimentos")
                        .HasForeignKey("TipoPrioridadId");
                });

            modelBuilder.Entity("ItAgenda.Web.Data.Entities.RequerimientoDetalle", b =>
                {
                    b.HasOne("ItAgenda.Web.Data.Entities.Requerimento", "Requerimento")
                        .WithMany("RequerimientoDetalles")
                        .HasForeignKey("RequerimentoId");
                });
#pragma warning restore 612, 618
        }
    }
}
