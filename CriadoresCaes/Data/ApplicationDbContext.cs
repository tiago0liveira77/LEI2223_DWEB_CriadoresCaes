﻿using CriadorDeCaes.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CriadoresCaes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // ********************************************
        // Criação das tabelas da BD
        // ********************************************
        public DbSet<Animais> Animais { get; set; }
        public DbSet<Criadores> Criadores { get; set; }
        public DbSet<Racas> Racas { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }
    }
}