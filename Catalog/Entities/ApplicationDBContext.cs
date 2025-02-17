﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
