using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//reflecting all the configuration classes in the assembly and applying them to the model builder
        }
    }
}
