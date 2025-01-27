using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;

public class ResponsePetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public PetType PetType { get; set; }
}
