using customPagination.Models.Person.Responses;

namespace customPagination.Mappers;

public static class PersonMapper
{
    public static Entities.Person? GetEntity(PersonResponse model)
    {
        if (model != null)
        {
            return new Entities.Person
            {
                //Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Phone = model.Phone,
                StreetAddress = model.StreetAddress,
                City = model.City,
                State = model.State,
                ZipCode = model.ZipCode,
                Rating = (int)model.Rating
            };
        }
        return null;

    }
}
