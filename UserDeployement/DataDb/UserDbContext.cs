﻿using Microsoft.EntityFrameworkCore;
using UserDeployement.Entities;

namespace UserDeployement.DataDb
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
