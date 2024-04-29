using customPagination.Models.Person.Requests;
using customPagination.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace customPagination.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private IPersonRepository _personRepo;
    public PersonController(IPersonRepository personRepository)
    {
        _personRepo = personRepository;
    }

    [HttpGet]
    [Route("/person/getAll")]
    public async Task<IActionResult> Get()
    {
        var result = await _personRepo.GetAll();
        return Ok(result);
    }

    [HttpPost]
    [Route("/person/populate")]
    public async Task<IActionResult> PopulateDB()
    {
        var esito = await _personRepo.PopulateDb();
        return Ok(esito);
    }

    [HttpPost]
    [Route("/person/getPersons")]
    public async Task<IActionResult> GetPersons(GetPersonsRequest request)
    {
        var personsFound = await _personRepo.GetAllPersons(request);
        return Ok(personsFound);
    }

}
