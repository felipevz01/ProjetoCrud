﻿using Microsoft.EntityFrameworkCore;

namespace ProjetoCrud.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}

