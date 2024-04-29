using customPagination.Entities;
using customPagination.Models.Person.Requests;
using customPagination.Models.Person.Responses;
using customPagination.Utils;

namespace customPagination.Repositories;

public interface IPersonRepository
{
    Task<List<Person>> GetAll();
    Task<bool> PopulateDb();
    Task<PagedList<PersonResponse>> GetAllPersons(GetPersonsRequest request);
}
