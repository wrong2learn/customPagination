using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace customPagination.Entities;

[Table(name: "PERSONS")]
public class Person
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(name: "ID")]
    public int Id { get; set; }

    [Column(name: "FIRST_NAME")]
    public string FirstName { get; set; }

    [Column(name: "LAST_NAME")]
    public string LastName { get; set; }

    [Column(name: "EMAIL")]
    public string Email { get; set; }

    [Column(name: "PHONE")]
    public string Phone { get; set; }

    [Column(name: "STREET_ADDRESS")]
    public string StreetAddress { get; set; }

    [Column(name: "CITY")]
    public string City { get; set; }

    [Column(name: "STATE")]
    public string State { get; set; }

    [Column(name: "ZIP_CODE")]
    public string ZipCode { get; set; }

    [Column(name: "RATING")]
    public int Rating { get; set; }
}
