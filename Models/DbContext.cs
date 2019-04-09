using Microsoft.EntityFrameworkCore;

namespace Lab11.Models
{
	public class ProfessorDbContext : DbContext
	{
		public ProfessorDbContext (DbContextOptions<ProfessorDbContext> options)
			: base(options)
		{
		}
		public DbSet<Professor> Professor {get; set;}
	}
}