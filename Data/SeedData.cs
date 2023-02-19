using Kcalculator.Models;
using Microsoft.EntityFrameworkCore;

namespace Kcalculator.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RestaurantContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RestaurantContext>>()))
            {
                context.Database.EnsureCreated();

                // Look for menus
                if (context.Menus.Any())
                {
                    return;   // DB has been seeded
                }
                context.Menus.AddRange(
                    new Menu { Name = "Regular" },
                    new Menu { Name = "Breakfast" },
                    new Menu { Name = "Lunch" }
                );
                context.SaveChanges();

                // Look for items
                if (context.Items.Any())
                {
                    return;   // DB has been seeded
                }
                context.Items.AddRange(
                    new Item { Name = "Eggs", Calories = 30 },
                    new Item { Name = "Porrige", Calories = 40 }
                );
                context.SaveChanges();
            }
        }
    }
}