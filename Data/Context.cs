﻿using AgendaCEP.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaCEP.Data
{ 
        public class Context : DbContext
        {
            public Context(DbContextOptions<Context> options) : base(options) { }

            public DbSet<Contato> Contatos { get; set; }
        }
}