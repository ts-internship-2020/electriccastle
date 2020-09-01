using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class electriccastleContext : DbContext
    {
        public electriccastleContext()
        {
        }

        public electriccastleContext(DbContextOptions<electriccastleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Conference> Conference { get; set; }
        public virtual DbSet<ConferenceParticipant> ConferenceParticipant { get; set; }
        public virtual DbSet<ConferenceXdictionarySpeaker> ConferenceXdictionarySpeaker { get; set; }
        public virtual DbSet<Demo> Demo { get; set; }
        public virtual DbSet<DictionaryCity> DictionaryCity { get; set; }
        public virtual DbSet<DictionaryConferenceCategory> DictionaryConferenceCategory { get; set; }
        public virtual DbSet<DictionaryConferenceType> DictionaryConferenceType { get; set; }
        public virtual DbSet<DictionaryCountry> DictionaryCountry { get; set; }
        public virtual DbSet<DictionaryDistrict> DictionaryDistrict { get; set; }
        public virtual DbSet<DictionaryParticipantState> DictionaryParticipantState { get; set; }
        public virtual DbSet<DictionarySpeaker> DictionarySpeaker { get; set; }
        public virtual DbSet<Location> Location { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ts-internship-2019.database.windows.net;Database=electric-castle;User Id=usr2020;Password=n39fn0n2_j32-(#;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conference>(entity =>
            {
                entity.Property(e => e.ConferenceName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizerEmail)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OrganizerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.DictionaryConferenceCategory)
                    .WithMany(p => p.Conference)
                    .HasForeignKey(d => d.DictionaryConferenceCategoryId)
                    .HasConstraintName("FK__Conferenc__Dicti__395884C4");

                entity.HasOne(d => d.DictionaryConferenceType)
                    .WithMany(p => p.Conference)
                    .HasForeignKey(d => d.DictionaryConferenceTypeId)
                    .HasConstraintName("FK__Conferenc__Dicti__3A4CA8FD");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Conference)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Conferenc__Locat__3B40CD36");
            });

            modelBuilder.Entity<ConferenceParticipant>(entity =>
            {
                entity.HasKey(e => new { e.ConferenceId, e.ParticipantEmail })
                    .HasName("PK__Conferen__D492EDE75CAEE4A0");

                entity.Property(e => e.ParticipantEmail).HasMaxLength(255);

                entity.Property(e => e.EmailCode).HasMaxLength(255);

                entity.HasOne(d => d.Conference)
                    .WithMany(p => p.ConferenceParticipant)
                    .HasForeignKey(d => d.ConferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Conferenc__Confe__42E1EEFE");

                entity.HasOne(d => d.DictionaryParticipantState)
                    .WithMany(p => p.ConferenceParticipant)
                    .HasForeignKey(d => d.DictionaryParticipantStateId)
                    .HasConstraintName("FK__Conferenc__Dicti__43D61337");
            });

            modelBuilder.Entity<ConferenceXdictionarySpeaker>(entity =>
            {
                entity.HasKey(e => new { e.DictionarySpeakerId, e.ConferenceId })
                    .HasName("PK__Conferen__3D98D7D8AB380C84");

                entity.ToTable("ConferenceXDictionarySpeaker");

                entity.HasOne(d => d.Conference)
                    .WithMany(p => p.ConferenceXdictionarySpeaker)
                    .HasForeignKey(d => d.ConferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Conferenc__Confe__4A8310C6");

                entity.HasOne(d => d.DictionarySpeaker)
                    .WithMany(p => p.ConferenceXdictionarySpeaker)
                    .HasForeignKey(d => d.DictionarySpeakerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Conferenc__Dicti__498EEC8D");
            });

            modelBuilder.Entity<Demo>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<DictionaryCity>(entity =>
            {
                entity.HasIndex(e => e.CityCode)
                    .HasName("UQ__Dictiona__B488218C40F9F666")
                    .IsUnique();

                entity.Property(e => e.DictionaryCityId).ValueGeneratedNever();

                entity.Property(e => e.CityCode).HasMaxLength(10);

                entity.Property(e => e.DictionaryCityName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.DictionaryDistrict)
                    .WithMany(p => p.DictionaryCity)
                    .HasForeignKey(d => d.DictionaryDistrictId)
                    .HasConstraintName("FK__Dictionar__Dicti__339FAB6E");
            });

            modelBuilder.Entity<DictionaryConferenceCategory>(entity =>
            {
                entity.HasIndex(e => e.ConferenceCategoryCode)
                    .HasName("UQ__Dictiona__14403A5C732B5D8D")
                    .IsUnique();

                entity.Property(e => e.DictionaryConferenceCategoryId).ValueGeneratedNever();

                entity.Property(e => e.ConferenceCategoryCode).HasMaxLength(10);

                entity.Property(e => e.DictionaryConferenceCategoryName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DictionaryConferenceType>(entity =>
            {
                entity.HasIndex(e => e.ConferenceTypeCode)
                    .HasName("UQ__Dictiona__8E75D3C4B01762DD")
                    .IsUnique();

                entity.Property(e => e.DictionaryConferenceTypeId).ValueGeneratedNever();

                entity.Property(e => e.ConferenceTypeCode).HasMaxLength(10);

                entity.Property(e => e.DictionaryConferenceTypeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DictionaryCountry>(entity =>
            {
                entity.HasIndex(e => e.CountryCode)
                    .HasName("UQ__Dictiona__5D9B0D2C287CA2B9")
                    .IsUnique();

                entity.Property(e => e.DictionaryCountryId).ValueGeneratedNever();

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.DictionaryCountryName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DictionaryDistrict>(entity =>
            {
                entity.HasIndex(e => e.DistrictCode)
                    .HasName("UQ__Dictiona__3D4E86AB2DC5EDC1")
                    .IsUnique();

                entity.Property(e => e.DictionaryDistrictId).ValueGeneratedNever();

                entity.Property(e => e.DictionaryDistrictName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DistrictCode).HasMaxLength(10);

                entity.HasOne(d => d.DictionaryCountry)
                    .WithMany(p => p.DictionaryDistrict)
                    .HasForeignKey(d => d.DictionaryCountryId)
                    .HasConstraintName("FK__Dictionar__Dicti__2FCF1A8A");
            });

            modelBuilder.Entity<DictionaryParticipantState>(entity =>
            {
                entity.HasIndex(e => e.ParticipantStateCode)
                    .HasName("UQ__Dictiona__578660B31BA0768B")
                    .IsUnique();

                entity.Property(e => e.DictionaryParticipantStateId).ValueGeneratedNever();

                entity.Property(e => e.DictionaryParticipantStateName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ParticipantStateCode).HasMaxLength(10);
            });

            modelBuilder.Entity<DictionarySpeaker>(entity =>
            {
                entity.HasIndex(e => e.SpeakerCode)
                    .HasName("UQ__Dictiona__6F859B8746657D78")
                    .IsUnique();

                entity.Property(e => e.DictionarySpeakerId).ValueGeneratedNever();

                entity.Property(e => e.DictionarySpeakerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Nationality).HasMaxLength(255);

                entity.Property(e => e.Picture)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('https://images.unsplash.com/photo-1544502062-f82887f03d1c?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=827&q=80')");

                entity.Property(e => e.Rating).HasColumnType("numeric(30, 2)");

                entity.Property(e => e.SpeakerCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.AdressDetails).HasMaxLength(255);

                entity.Property(e => e.Latitude).HasMaxLength(255);

                entity.Property(e => e.Longitude).HasMaxLength(255);

                entity.HasOne(d => d.DictionaryCity)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.DictionaryCityId)
                    .HasConstraintName("FK__Location__Dictio__367C1819");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
