using customPagination.DataContext;
using customPagination.DataGenerator;
using customPagination.Entities;
using customPagination.Mappers;
using customPagination.Models.Person.Requests;
using customPagination.Models.Person.Responses;
using customPagination.Utils;
using Microsoft.EntityFrameworkCore;

namespace customPagination.Repositories;

public class PersonRepository : IPersonRepository
{
    private PersonDataGenerator _personDataGenerator;
    private PersonDbContext _context;

    public PersonRepository(PersonDbContext context)
    {
        _context = context;
    }

    public async Task<List<Person>> GetAll()
    {
        return await _context.Persons.ToListAsync();
    }

    public async Task<PagedList<PersonResponse>> GetAllPersons(GetPersonsRequest request)
    {
        IQueryable<Entities.Person> personsQuery = _context.Persons;

        var personsResponseQuery = personsQuery
            .Select(p => new PersonResponse(
                p.Id,
                p.FirstName,
                p.LastName,
                p.Email,
                p.Phone,
                p.StreetAddress,
                p.City,
                p.State,
                p.ZipCode,
                p.Rating));

        var persons = await PagedList<PersonResponse>.CreateAsync(
            personsResponseQuery,
            request.Page,
            request.PageSize);

        return persons;
    }

    public async Task<bool> PopulateDb()
    {
        _personDataGenerator = new PersonDataGenerator();
        var randomDatas = _personDataGenerator.GeneratePersons();

        if (randomDatas == null || !randomDatas.Any())
            return false;

        var randomDatasEntities = randomDatas.Select(x => 
        PersonMapper.GetEntity(x)).ToList();

        await _context.AddRangeAsync(randomDatasEntities);
        int esito = await _context.SaveChangesAsync();
        if (esito > 0)
            return true;

        return false;
    }
}