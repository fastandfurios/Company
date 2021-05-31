using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Company.Models.ORM
{
    public class AppContext : DbContext
    {
	    public DbSet<Employee> Employees { get; set; }
	    public DbSet<Division> Divisions { get; set; }
	    public DbSet<Order> Orders { get; set; }

	    public AppContext()
	    {
		    Database.EnsureCreated();
	    }

	    protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>()
				.HasOne(e => e.Division)
				.WithOne(d => d.Director)
				.HasForeignKey<Division>(e => e.DivisionId);

			modelBuilder.Entity<Order>()
			    .HasOne(o => o.Author);
	    }

	    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	    {
			if(!optionsBuilder.IsConfigured)
				optionsBuilder.UseSqlServer(@"Server=HOME_M\SQLEXPRESS;Database=CompanyDb;Trusted_Connection=True;");
	    }
    }
}
