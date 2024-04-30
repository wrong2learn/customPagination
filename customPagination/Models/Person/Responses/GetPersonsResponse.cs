using customPagination.Utils;

namespace customPagination.Models.Person.Responses;

public class GetPersonsResponse
{
    public List<PagedList<PersonResponse>> PersonsList { get; set; }

    public GetPersonsResponse()
    {
        PersonsList = new List<PagedList<PersonResponse>>();
    }
}
