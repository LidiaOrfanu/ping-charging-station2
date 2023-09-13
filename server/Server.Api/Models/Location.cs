
using System.ComponentModel.DataAnnotations;


namespace Server.Api.Models;
public class Location
{
    [Key]
    public int LocationId {get; set;}
    public string? Street {get; set;}
    public int Zip {get; set;}
    public string? City {get; set;}
    public string? Country {get; set;}
}

