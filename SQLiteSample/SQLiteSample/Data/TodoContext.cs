﻿using Microsoft.EntityFrameworkCore;
using SQLiteSample.Domain;

namespace SQLiteSample.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Todo>().HasKey(a => a.Id);
        }
    }
}
