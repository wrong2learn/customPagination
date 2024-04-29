namespace customPagination.Models.Person.Responses;

public class PersonResponse
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public int Rating { get; set; }

    public PersonResponse()
    {

    }

    public PersonResponse(
                int id,
                string firstName,
                string lastName,
                string email,
                string phone,
                string streetAddress,
                string city,
                string state,
                string zipCode,
                int rating)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.Phone = phone;
        this.StreetAddress = streetAddress;
        this.City = city;
        this.State = state;
        this.ZipCode = zipCode;
        this.Rating = rating;
    }

}