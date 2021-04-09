using Microsoft.EntityFrameworkCore;
using LoginService.Models;

namespace LoginService.EntityFrameworkCore
{
    //We should not allocate the memory of AppicationDBContext class explicitly 
    public class ApplicationDBContext : DbContext
    {
        
        //Do Apply Constructor Chaining 
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> users{get; set;}
    }
}