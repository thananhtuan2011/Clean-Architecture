using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;
namespace CleanArchitecture.Domain.Entities;

public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext (options)
{
    public DbSet<CustomerEntity> Customers { get; set; }
}
