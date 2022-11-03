using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Entities
{
    public partial class AssignmentDBContext : DbContext
    {
        public AssignmentDBContext()
        {
        }

        public AssignmentDBContext(DbContextOptions<AssignmentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=WINDOWS-UNR7VLH\\SQLEXPRESS;Database=AssignmentDB;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Book");

                entity.Property(e => e.Author)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.BookName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Lang)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Publisher)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
