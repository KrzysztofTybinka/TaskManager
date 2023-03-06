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
