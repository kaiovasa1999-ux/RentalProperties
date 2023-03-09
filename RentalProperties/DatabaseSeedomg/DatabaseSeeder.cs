using Microsoft.EntityFrameworkCore;
using RentalProperties.Data;
using RentalProperties.Data.Models;

namespace RentalProperties.DatabaseSeedomg
{
    public static class DatabaseSeeder
    {
        public static IApplicationBuilder Initialize(this IApplicationBuilder app)
        {
            using var scopedService = app.ApplicationServices.CreateScope();
            var serviceProvider = scopedService.ServiceProvider;
            var db = serviceProvider.GetRequiredService<ApplicationDbContext>();
            db.Database.Migrate();
            return app;
        }
    }
}
