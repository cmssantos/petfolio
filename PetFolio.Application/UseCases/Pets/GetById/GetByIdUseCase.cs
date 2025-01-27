using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Dog",
            DateOfBirth = new DateOnly(year: 2021, month: 1, day: 1),
            PetType = PetType.Dog
        };
    }
}