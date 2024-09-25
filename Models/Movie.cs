using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppMoviesDemo.Models;

public class Movie
{
    public int Id {get; set;}
    public string? Title {get; set;}
    public DateOnly ReleaseDate {get; set;}
    public string? Genere {get; set;}

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price {get;set;}
}