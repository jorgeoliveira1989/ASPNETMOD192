﻿using ASPNETMOD192.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMOD192.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client>Clients { get; set; } = default!;
        public DbSet<Staff> Staffs { get; set; } = default!;
    }
}
