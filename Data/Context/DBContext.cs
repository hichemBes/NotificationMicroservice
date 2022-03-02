
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public  class DBContext : DbContext

    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Domain.Model.Notification> Notification { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Model.Notification>().HasKey(c => c.Id);
        }
    }
}
