using Battleship.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Battleship.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}

       
        public DbSet<Board> Boards { get; set; }
        public DbSet<Ship> Ships { get; set; }
    }
}