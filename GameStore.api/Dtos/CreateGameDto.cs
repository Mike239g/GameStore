using System.ComponentModel.DataAnnotations;
namespace GameStore.Api.Dtos;

// A DTO is a contract between the client and server since it represents
// a shared agreement about how data will be transfered and used
public record CreateGameDto(
    [Required][StringLength(50)] string Name,
    [Required][StringLength(20)] string Genre,
    [Required][Range(1, 100)] float Price,
    [Required] DateOnly Date
);