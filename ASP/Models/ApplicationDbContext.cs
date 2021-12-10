﻿using Microsoft.EntityFrameworkCore;

namespace EPaczucha.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}