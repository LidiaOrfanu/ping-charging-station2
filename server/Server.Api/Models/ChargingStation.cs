using System.ComponentModel.DataAnnotations;

namespace Server.Api.Models;
public class ChargingStation
{
    [Key]
    public int StationId { get; set; }
    public string Name { get; set; }
    public int? LocationId {get; set;}
    public bool isAvailable  { get; set; }
}
