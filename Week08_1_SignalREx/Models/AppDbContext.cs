﻿using Microsoft.EntityFrameworkCore;

namespace Week08_1_SignalREx.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ChatMessage> ChatMessages { get; set; }

    }
}
