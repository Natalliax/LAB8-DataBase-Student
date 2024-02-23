﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8.Models
{
    internal class EntityContext : DbContext
    {
        public EntityContext(): base ("DefaultConnection")
        {
            Database.SetInitializer(new DataBaseInitializer());

        }
        public DbSet <Student> Students { get; set; }
    }
}
