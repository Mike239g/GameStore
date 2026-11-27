namespace GameStore.Api.Models;

public class Game
{
    public int Id {get; set;}

    public required string Name {get; set;}

    // The ? makes it posible for this to be null
    public Genre? Genre {get; set;}

    //  This will be a foreign key from the data base
    public int GenreId {get; set;}

    public float Price {get; set;}

    public DateOnly ReleaseDate {get; set;}
}