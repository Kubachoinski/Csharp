using Microsoft.EntityFrameworkCore;
using WebApplication2.Controllers;
using WebApplication2.Models;


namespace WebApplication2.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }
    }
}
