﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StreamingAPI;

namespace StreamingAPI.Migrations
{
    [DbContext(typeof(StreamingDBContext))]
    [Migration("20200928150243_Added sala relation")]
    partial class Addedsalarelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.7.20365.15");

            modelBuilder.Entity("Asistencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEgreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Salas")
                        .HasColumnType("int");

                    b.Property<int?>("ParticipanteId")
                        .HasColumnType("int");

                    b.Property<int>("Rol_Usuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParticipanteId");

                    b.ToTable("Asistencias");
                });

            modelBuilder.Entity("Participante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VideoRoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VideoRoomId");

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("ControlAsistencia")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EsPersistente")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaUltimoUso")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreSala")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSala")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TiempoAcumuladoUso")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("SharedModels.ChatService.Mensaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contenido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora_Fecha_Envio")
                        .HasColumnType("datetime2");

                    b.Property<int>("ParticipanteId")
                        .HasColumnType("int");

                    b.Property<bool>("Privado")
                        .HasColumnType("bit");

                    b.Property<string>("Url_Archivo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParticipanteId");

                    b.ToTable("Mensajes");
                });

            modelBuilder.Entity("SharedModels.StreamingService.ConferenceRecordFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DuenioId")
                        .HasColumnType("int");

                    b.Property<string>("NombreArchivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VideoRoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DuenioId");

                    b.HasIndex("VideoRoomId");

                    b.ToTable("ConferenceRecordFiles");
                });

            modelBuilder.Entity("SharedModels.StreamingService.VideoRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DuenioId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duracion")
                        .HasColumnType("time");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DuenioId");

                    b.HasIndex("SalaId");

                    b.ToTable("VideoRooms");
                });

            modelBuilder.Entity("SharedModels.UserService.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CUIL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Miembros")
                        .HasColumnType("int");

                    b.Property<string>("NombreEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("SharedModels.UserService.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Asistencia", b =>
                {
                    b.HasOne("Participante", "Participante")
                        .WithMany("Asistencia")
                        .HasForeignKey("ParticipanteId");
                });

            modelBuilder.Entity("Participante", b =>
                {
                    b.HasOne("SharedModels.StreamingService.VideoRoom", null)
                        .WithMany("Participantes")
                        .HasForeignKey("VideoRoomId");
                });

            modelBuilder.Entity("SharedModels.ChatService.Mensaje", b =>
                {
                    b.HasOne("Participante", "Participante")
                        .WithMany()
                        .HasForeignKey("ParticipanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SharedModels.StreamingService.ConferenceRecordFile", b =>
                {
                    b.HasOne("Participante", "Duenio")
                        .WithMany()
                        .HasForeignKey("DuenioId");

                    b.HasOne("SharedModels.StreamingService.VideoRoom", "VideoRoom")
                        .WithMany()
                        .HasForeignKey("VideoRoomId");
                });

            modelBuilder.Entity("SharedModels.StreamingService.VideoRoom", b =>
                {
                    b.HasOne("Participante", "Duenio")
                        .WithMany()
                        .HasForeignKey("DuenioId");

                    b.HasOne("Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaId");
                });
#pragma warning restore 612, 618
        }
    }
}
