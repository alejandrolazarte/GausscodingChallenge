using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ApplicationTest.Config
{
    public static class ApplicationDbContextInMemory
    {
        public static ApplicationDbContext Get() 
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("GaussDb"); 

            return new ApplicationDbContext(options.Options);
        }
    }
}
