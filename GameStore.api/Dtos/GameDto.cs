namespace GameStore.Api.Dtos;

// A DTO is a contract between the client and server since it represents
// a shared agreement about how data will be transfered and used
public record GameDto(
    int Id,
    string Name,
    string Genre,
    float Price,
    DateOnly ReleaseDate
);