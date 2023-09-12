using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Api.Models;
public class ChargingStation
{
    [Key]
    public int StationId { get; set; }
    public string Name { get; set; }
    public int? LocationId {get; set;}
    public bool isAvailable  { get; set; }
}
