using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuickBook.Models;

namespace QuickBook.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Ensure database is created
            await context.Database.EnsureCreatedAsync();

            // Create roles
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (!await roleManager.RoleExistsAsync("User"))
            {
                await roleManager.CreateAsync(new IdentityRole("User"));
            }

            // Create admin user
            var adminEmail = "admin@quickbook.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            
            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    FullName = "Administrator",
                    EmailConfirmed = true,
                    CreatedAt = DateTime.UtcNow
                };

                var result = await userManager.CreateAsync(adminUser, "admin123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }

            // Create demo user
            var demoEmail = "user@quickbook.com";
            var demoUser = await userManager.FindByEmailAsync(demoEmail);
            
            if (demoUser == null)
            {
                demoUser = new ApplicationUser
                {
                    UserName = demoEmail,
                    Email = demoEmail,
                    FullName = "Demo User",
                    EmailConfirmed = true,
                    CreatedAt = DateTime.UtcNow
                };

                var result = await userManager.CreateAsync(demoUser, "user123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(demoUser, "User");
                }
            }

            // Seed services if none exist
            if (!await context.Services.AnyAsync())
            {
                var services = new[]
                {
                    new Service
                    {
                        Name = "Consultation",
                        Description = "General consultation service with our experts",
                        Duration = 30,
                        Price = 50.00m,
                        CreatedAt = DateTime.UtcNow
                    },
                    new Service
                    {
                        Name = "Therapy Session",
                        Description = "One-on-one therapy session with certified therapist",
                        Duration = 60,
                        Price = 100.00m,
                        CreatedAt = DateTime.UtcNow
                    },
                    new Service
                    {
                        Name = "Group Session",
                        Description = "Group therapy session with multiple participants",
                        Duration = 90,
                        Price = 75.00m,
                        CreatedAt = DateTime.UtcNow
                    },
                    new Service
                    {
                        Name = "Assessment",
                        Description = "Initial assessment and evaluation session",
                        Duration = 45,
                        Price = 80.00m,
                        CreatedAt = DateTime.UtcNow
                    }
                };

                await context.Services.AddRangeAsync(services);
                await context.SaveChangesAsync();
            }
        }
    }
}