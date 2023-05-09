using Microsoft.EntityFrameworkCore;
using api_assignment.model;
namespace api_assignment.data
{
    public class AppDb_context : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) 
            : base(options)
        {|
        }
    public DbSet<Login> Login { get; set; }
    }




       


     

       