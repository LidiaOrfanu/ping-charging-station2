using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Api.Models;
public class Location
{
    [Key]
    public int LocationId {get; set;}
    public string Street {get; set;}
    public int Zip {get; set;}
    public string City {get; set;}
    public string State {get; set;}
}
