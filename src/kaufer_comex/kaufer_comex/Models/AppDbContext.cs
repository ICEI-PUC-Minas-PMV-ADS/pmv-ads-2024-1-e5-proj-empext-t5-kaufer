﻿using Microsoft.EntityFrameworkCore;

namespace kaufer_comex.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}