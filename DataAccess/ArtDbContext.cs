using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ArtDbContext : DbContext
    {
        public ArtDbContext(DbContextOptions opt) : base(opt)
        {

        }
public DbSet<Page2> Pages2 { get; set; }


  
    }
}