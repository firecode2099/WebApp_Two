using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2
{
    public class AplicationDBContext:DbContext
    {


        public AplicationDBContext(DbContextOptions<AplicationDBContext>
            options) : base(options)
        {


        }

        public DbSet<TarjetaCredito> tarjetacredito { get; set; }


    }
}
