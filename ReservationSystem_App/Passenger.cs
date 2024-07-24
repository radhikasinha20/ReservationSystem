using System.ComponentModel.DataAnnotations;
namespace ReservationSystemApp.Models;



public class Passenger
{
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int Postal { get; set; }

}