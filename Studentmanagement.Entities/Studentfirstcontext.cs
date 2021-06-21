﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Studentmanagement.Entities
{
    public partial class Studentfirstcontext : DbContext
    {
        public Studentfirstcontext()
        {
        }

        public Studentfirstcontext(DbContextOptions<Studentfirstcontext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Studentfirstsample");
            }
        }

        public virtual DbSet<DepartmentDetail> DepartmentDetail { get; set; }
        public virtual DbSet<Employeelogin> Employeelogin { get; set; }
        public virtual DbSet<Employeemanagement> Employeemanagement { get; set; }
        public virtual DbSet<Studentinfo> Studentinfo { get; set; }
        public virtual DbSet<Studentmark> Studentmark { get; set; }

        //Below is a fluent API which is used in EF to configure an entity to map it with
        //database table(s),default schema, etc. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DepartmentDetail>(entity =>
            {
                entity.Property(e => e.DepartmentId).ValueGeneratedNever();

                entity.Property(e => e.DepartmentName).IsUnicode(false);
            });

            modelBuilder.Entity<Employeelogin>(entity =>
            {
                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<Employeemanagement>(entity =>
            {
                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.CreatedTimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fullname).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Phonenumber).IsUnicode(false);

                entity.Property(e => e.UpdatedTimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username).IsUnicode(false);

                entity.Property(e => e.Work).IsUnicode(false);
            });

            modelBuilder.Entity<Studentinfo>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__studenti__32C52B995B83592C");

                entity.Property(e => e.CreatedTimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.UpdatedTimeStamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Studentmark>(entity =>
            {
                entity.Property(e => e.CreatedTimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Total).HasComputedColumnSql("([Mark1]+[Mark2])", false);

                entity.Property(e => e.UpdatedTimeStamp).HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}