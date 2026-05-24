//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using TaskManager.Domain.Entities;

//namespace ProjectTasksManagement.Infrastructure.Persistence
//{
//    public class AppDbContext : DbContext
//    {
//        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

//        public DbSet<User> Users => Set<User>();
//        public DbSet<Role> Roles => Set<Role>();
//        public DbSet<UserRole> UserRoles => Set<UserRole>();
//        public DbSet<Project> Projects => Set<Project>();
//        public DbSet<TaskItem> Tasks => Set<TaskItem>();

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            // User configuration
//            modelBuilder.Entity<User>(entity =>
//            {
//                entity.HasKey(e => e.Id);
//                entity.HasIndex(e => e.Username).IsUnique();
//                entity.HasIndex(e => e.Email).IsUnique();
//                entity.Property(e => e.Username).IsRequired().HasMaxLength(50);
//                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
//                entity.Property(e => e.PasswordHash).IsRequired();
//            });

//            // Role configuration
//            modelBuilder.Entity<Role>(entity =>
//            {
//                entity.HasKey(e => e.Id);
//                entity.HasIndex(e => e.Name).IsUnique();
//                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
//                entity.Property(e => e.Description).HasMaxLength(200);
//            });

//            // UserRole junction table configuration
//            modelBuilder.Entity<UserRole>(entity =>
//            {
//                entity.HasKey(e => new { e.UserId, e.RoleId });

//                entity.HasOne(ur => ur.User)
//                      .WithMany(u => u.UserRoles)
//                      .HasForeignKey(ur => ur.UserId)
//                      .OnDelete(DeleteBehavior.Cascade);

//                entity.HasOne(ur => ur.Role)
//                      .WithMany(r => r.UserRoles)
//                      .HasForeignKey(ur => ur.RoleId)
//                      .OnDelete(DeleteBehavior.Cascade);

//                entity.Property(e => e.AssignedAt).IsRequired();
//                entity.Property(e => e.AssignedBy).IsRequired();
//            });

//            // Seed default roles
//            modelBuilder.Entity<Role>().HasData(
//                new Role { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "User", Description = "Regular user with basic permissions", CreatedAt = DateTime.UtcNow },
//                new Role { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), Name = "Manager", Description = "Can manage projects and assign tasks", CreatedAt = DateTime.UtcNow },
//                new Role { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), Name = "Admin", Description = "Full system access", CreatedAt = DateTime.UtcNow }
//            );

//            // Project configuration
//            modelBuilder.Entity<Project>(entity =>
//            {
//                entity.HasKey(e => e.Id);
//                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
//                entity.HasOne(e => e.User)
//                      .WithMany(u => u.Projects)
//                      .HasForeignKey(e => e.UserId)
//                      .OnDelete(DeleteBehavior.Restrict);
//            });

//            // Task configuration
//            modelBuilder.Entity<TaskItem>(entity =>
//            {
//                entity.HasKey(e => e.Id);
//                entity.Property(e => e.Title).IsRequired().HasMaxLength(200);
//                entity.HasOne(e => e.Project)
//                      .WithMany(p => p.Tasks)
//                      .HasForeignKey(e => e.ProjectId)
//                      .OnDelete(DeleteBehavior.Cascade);
//            });
//        }
//    }

//}


