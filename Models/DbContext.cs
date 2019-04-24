using Microsoft.EntityFrameworkCore;

namespace Lab11.Models
{
	public class ProfessorDbContext : DbContext
	{
		public ProfessorDbContext (DbContextOptions<ProfessorDbContext> options)
			: base(options)
		{
		}
		public DbSet<Lab11.Models.Professor> Professor {get; set;}
		public DbSet<Lab11.Models.Course> Course {get;set;}
	}
}