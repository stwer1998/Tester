using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesterCore.Models;

namespace TesterDb
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TestWhithCloseAns> TestWhithCloseAns { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
