using System;
using Microsoft.EntityFrameworkCore;

namespace SS6POS.Models
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):
			base(options)
		{
		}
		public DbSet<Customer> Customer { get; set; }
		public DbSet<Category> Category { get; set; }
	}
}

