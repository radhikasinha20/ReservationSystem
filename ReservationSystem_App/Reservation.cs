using System.ComponentModel.DataAnnotations;
namespace ReservationSystemApp.Models;

public class Reservation
{
    public int Id { get; set; }

    [Required]
    public int ReservationNumber { get; set; }
    public DateTime PickupDate { get; set; }
    public string PickupTime { get; set; }
    public DateTime DropoffDate { get; set; }
    public string DropoffTime { get; set; }

    public string PickupLoc { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Postal { get; set; }
    public string DropoffLoc { get; set; }
    public string City_ { get; set; }
    public string State_ { get; set; }
    public string Postal_ { get; set; }
}