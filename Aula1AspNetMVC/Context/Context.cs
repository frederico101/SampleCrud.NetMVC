using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula1AspNetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula1AspNetMVC.Context
{
    public class Aula1Context : DbContext 
        {
        public Aula1Context(DbContextOptions<Aula1Context> options)
            : base(options)
        {

        }

        public DbSet<Cliente> clientes { get; set; }
    }
       
}
