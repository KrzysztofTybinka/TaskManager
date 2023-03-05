using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Web.Helpers;
using TaskManager.Areas.Identity.Data;
using TaskManager.Models;

namespace TaskManager.Areas.Identity.Data;

public class AppDbContext : IdentityDbContext<TaskManagerUser>
{
    public DbSet<Models.Task> Tasks { get; set; }
    public DbSet<Status> Statuses { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole() { Id = "e45e7052-fab1-4848-9057-162971c9e740", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole() { Id = "420c2f8f-3315-425f-b865-13e9146991b6", Name = "User", NormalizedName = "USER" });

        builder.Entity<TaskManagerUser>().HasData(
            new TaskManagerUser() { Id = "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168", UserName = "admin", Email = "admin@admin.com" ,EmailConfirmed = true, PasswordHash = Crypto.HashPassword("Zaq12wsx!"), PhoneNumberConfirmed = true },
            new TaskManagerUser() { Id = "896ef532-034c-4425-8d71-75f90b17e6fa", UserName = "user", Email = "user@user.com", EmailConfirmed = true, PasswordHash = Crypto.HashPassword("Zaq12wsx!"), PhoneNumberConfirmed = true });

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { UserId = "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168", RoleId = "e45e7052-fab1-4848-9057-162971c9e740" }, 
            new IdentityUserRole<string> { UserId = "896ef532-034c-4425-8d71-75f90b17e6fa", RoleId = "420c2f8f-3315-425f-b865-13e9146991b6" });
            
        builder.Entity<Status>().HasData(
            new Status() { Id = "To do" },
            new Status() { Id = "Pending" },
            new Status() { Id = "Done" });

        builder.Entity<Models.Task>()
            .HasOne(s => s.Status)
            .WithMany()
            .HasForeignKey(t => t.StatusId);

        builder.Entity<Models.Task>()
            .HasOne(p => p.Publisher)
            .WithMany()
            .HasForeignKey(p => p.PublisherId);

        builder.Entity<Models.Task>()
            .HasOne(a => a.Assignee)
            .WithMany()
            .HasForeignKey(a => a.AssigneeId);

    }
}
