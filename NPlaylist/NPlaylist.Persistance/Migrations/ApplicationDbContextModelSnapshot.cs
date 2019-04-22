﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NPlaylist.Data;

namespace NPlaylist.Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NPlaylist.Data.DbModels.Audio", b =>
                {
                    b.Property<Guid>("AudioId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("MetaAudioMetaId");

                    b.Property<Guid>("OwnerId");

                    b.Property<string>("Path");

                    b.HasKey("AudioId");

                    b.HasIndex("MetaAudioMetaId");

                    b.ToTable("AudioEntries");
                });

            modelBuilder.Entity("NPlaylist.Data.DbModels.AudioMeta", b =>
                {
                    b.Property<Guid>("AudioMetaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Album");

                    b.Property<string>("Author");

                    b.Property<string>("Title");

                    b.HasKey("AudioMetaId");

                    b.ToTable("AudioMetaEntries");
                });

            modelBuilder.Entity("NPlaylist.Data.DbModels.Audio", b =>
                {
                    b.HasOne("NPlaylist.Data.DbModels.AudioMeta", "Meta")
                        .WithMany()
                        .HasForeignKey("MetaAudioMetaId");
                });
#pragma warning restore 612, 618
        }
    }
}
