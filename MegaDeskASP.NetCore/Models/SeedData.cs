using MegaDeskASP.NetCore.Data;
using Microsoft.EntityFrameworkCore;


namespace MegaDeskASP.NetCore.Models
{
    public class SeedData
    {
            public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MegaDeskASPNetCoreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MegaDeskASPNetCoreContext>>()))
        {
            if (context == null || context.Desk == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Desk.Any())
            {
                return;   // DB has been seeded
            }

            context.Desk.AddRange(
                new Desk
                {
                    CustomerName = "Max Alves",
                    QuoteDate = DateTime.Parse("2023-3-12"),
                    DeskWidth = 20,
                    DeskDepth = 12.5m,
                    NumberOfDrawers = 1,
                    SurfaceMaterial= "Pine" ,
                    DeliveryChoice = "3 days" ,
                    QuoteTotal = 300 

                },

                new Desk
                {
                    CustomerName = "Alisson James",
                    QuoteDate = DateTime.Parse("2023-2-12"),
                    DeskWidth = 20,
                    DeskDepth = 12.5m,
                    NumberOfDrawers = 1,
                    SurfaceMaterial = "Wood",
                    DeliveryChoice = "3 days",
                    QuoteTotal = 300
                },

                new Desk
                {
                    CustomerName = "Stephen Curry",
                    QuoteDate = DateTime.Parse("2023-4-12"),
                    DeskWidth = 20,
                    DeskDepth = 12.5m,
                    NumberOfDrawers = 1,
                    SurfaceMaterial = "Pine",
                    DeliveryChoice = "3 days",
                    QuoteTotal = 300
                },

                new Desk
                {
                    CustomerName = "James Spencer",
                    QuoteDate = DateTime.Parse("2023-2-12"),
                    DeskWidth = 20,
                    DeskDepth = 12.5m,
                    NumberOfDrawers = 1,
                    SurfaceMaterial = "Pine",
                    DeliveryChoice = "3 days",
                    QuoteTotal = 300
                }
            );
            context.SaveChanges();
        }
    }
    }
}
