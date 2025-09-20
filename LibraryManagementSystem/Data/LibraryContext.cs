using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Data
{
    public class LibraryContext : DbContext
    {

        public LibraryContext(DbContextOptions options) : base(options) 
        {
        }
    }
}
