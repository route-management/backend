using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Entities.Models.Entities
{
    public partial class RouteManagementContext : DbContext
    {
        public RouteManagementContext()
        {
        }

        public RouteManagementContext(DbContextOptions<RouteManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblPilot> TblPilots { get; set; }
        public virtual DbSet<TblRoute> TblRoutes { get; set; }
        public virtual DbSet<TblRouteTrain> TblRouteTrains { get; set; }
        public virtual DbSet<TblRouteTrainStop> TblRouteTrainStops { get; set; }
        public virtual DbSet<TblStop> TblStops { get; set; }
        public virtual DbSet<TblTrain> TblTrains { get; set; }
        public virtual DbSet<VwTrainStopsForRoute> VwTrainStopsForRoutes { get; set; }
        public virtual DbSet<VwTrainsNotAssignedToRoute> VwTrainsNotAssignedToRoutes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=RouteManagement;User ID=sa;Password=Password1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblPilot>(entity =>
            {
                entity.ToTable("tblPilots");

                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.StaffId)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblRoute>(entity =>
            {
                entity.ToTable("tblRoutes");

                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EndPoint)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.StartPoint)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblRouteTrain>(entity =>
            {
                entity.ToTable("tblRouteTrains");

                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RouteId)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TrainId)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.TblRouteTrains)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Train)
                    .WithMany(p => p.TblRouteTrains)
                    .HasForeignKey(d => d.TrainId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblRouteTrainStop>(entity =>
            {
                entity.ToTable("tblRouteTrainStops");

                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EstimateArrivalTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RouteTrainId)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.StopId)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.RouteTrain)
                    .WithMany(p => p.TblRouteTrainStops)
                    .HasForeignKey(d => d.RouteTrainId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Stop)
                    .WithMany(p => p.TblRouteTrainStops)
                    .HasForeignKey(d => d.StopId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblStop>(entity =>
            {
                entity.ToTable("tblStops");

                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblTrain>(entity =>
            {
                entity.ToTable("tblTrains");

                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PilotId)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Pilot)
                    .WithMany(p => p.TblTrains)
                    .HasForeignKey(d => d.PilotId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VwTrainStopsForRoute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTrainStopsForRoute");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EstimateArrivalTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<VwTrainsNotAssignedToRoute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTrainsNotAssignedToRoute");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
