#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Journal_DataAttributes.Models;

    public class Journal_DataAttributesContext : DbContext
    {
        public Journal_DataAttributesContext (DbContextOptions<Journal_DataAttributesContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
