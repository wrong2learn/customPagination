using customPagination.Utils;

namespace customPagination.Models.Person.Responses;

public class GetPersonsResponses
{
    public List<PagedList<PersonResponse>> PersonsList { get; set; }

    public GetPersonsResponses()
    {
        PersonsList = new List<PagedList<PersonResponse>>();
    }
}
