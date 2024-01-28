namespace MoiteRecepti.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MoiteRecepti.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
           if (dbContext.Categories.Any())
            {
                return;
            }

           await dbContext.Categories.AddAsync(new Category { Name = "Салати" });
           await dbContext.Categories.AddAsync(new Category { Name = "Супи" });
           await dbContext.Categories.AddAsync(new Category { Name = "Основни ястия" });

           await dbContext.SaveChangesAsync();
        }
    }
}
