using System;
using Microsoft.EntityFrameworkCore;

namespace LoginApi.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ):base(options)
        {
            
        }
        public DbSet<User> users{get; set;}     
    }
}