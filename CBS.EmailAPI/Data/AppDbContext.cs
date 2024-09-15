﻿using CBS.EmailAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CBS.EmailAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<EmailLogger> EmailLoggers { get; set; }


    }
}
