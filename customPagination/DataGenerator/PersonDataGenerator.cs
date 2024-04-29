using Bogus;
using customPagination.Enums;
using customPagination.Models.Person.Responses;

namespace customPagination.DataGenerator;

public class PersonDataGenerator
{

    Faker<PersonResponse> _personModelFake;
    public PersonDataGenerator()
    {
        Randomizer.Seed = new Random(123);
        _personModelFake = new Faker<PersonResponse>()
            .RuleFor(u => u.Id, f => f.Random.Int(1, 10000))
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
            .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber())
            .RuleFor(u => u.StreetAddress, f => f.Address.StreetAddress())
            .RuleFor(u => u.City, f => f.Address.City())
            .RuleFor(u => u.State, f => f.Address.StateAbbr())
            .RuleFor(u => u.ZipCode, f => f.Address.ZipCode())
            .RuleFor(u => u.Rating, f => (int)f.PickRandom<CreditRating>());
    }

    public IEnumerable<PersonResponse> GeneratePersons()
    {
        //return _personModelFake.Generate();
        return _personModelFake.GenerateForever().Take(100);
    }
}
