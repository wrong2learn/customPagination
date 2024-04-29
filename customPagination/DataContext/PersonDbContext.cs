using customPagination.Entities;
using Microsoft.EntityFrameworkCore;

namespace customPagination.DataContext;

public class PersonDbContext : DbContext
{
    public PersonDbContext(DbContextOptions<PersonDbContext> options)
        : base(options)
    { }

    public virtual DbSet<Person> Persons { get; set; }

}
