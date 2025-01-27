using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetsJson Execute()
    {
        return new ResponseAllPetsJson
        {
            Pets = new List<ResponseShortPetJson>
            {
                new() {
                    Id = 1,
                    Name = "Dog",
                    PetType = PetType.Dog
                },
                new() {
                    Id = 2,
                    Name = "Cat",
                    PetType = PetType.Cat
                }
            }
        };
    }
}