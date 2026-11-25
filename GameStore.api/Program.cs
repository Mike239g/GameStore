using GameStore.Api.Dtos;

const string GetGameEndpointName = "GetGame";

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
    new (
        1, 
        "Street Fighter II", 
        "Fighting", 
        19.99f,
        new DateOnly(1992, 7, 15)),
    new (
        2, 
        "Final Fantasy VII Rebirth", 
        "RPG", 
        69.99f,
        new DateOnly(2024, 2, 29)),
    new (
        2, 
        "Astro Bot", 
        "Platformer", 
        59.99f,
        new DateOnly(2024, 9, 6))
];

// GET /games
app.MapGet("/games", () => games);


// Get a specific game
app.MapGet("/games/{id}", (int id) => games.Find(game => game.Id == id))
.WithName(GetGameEndpointName);

// Post /games
app.MapPost("/games", (CreateGameDto newGame) =>
{
    GameDto game = new(
        games.Count + 1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.Date
    );

    games.Add(game);

    return Results.CreatedAtRoute(GetGameEndpointName, new {id = game.Id}, game);
});

app.Run();
