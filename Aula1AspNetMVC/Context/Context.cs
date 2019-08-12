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
        public Aula1Context()
            : base()
        {

        }

        public DbSet<Cliente> clientes { get; set; }
    }
       
}
