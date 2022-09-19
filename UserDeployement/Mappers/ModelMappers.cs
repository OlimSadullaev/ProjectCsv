using Microsoft.EntityFrameworkCore.Infrastructure;

namespace UserDeployement.Mappers
{
    public static class ModelMappers
    {
        public static Entities.User ToEntity(this Entities.User user) => new Entities.User()
        {
            Id = Guid.NewGuid(),
            PersonName = user.PersonName,
            Age = user.Age,
            Pet_1 = user.Pet_1,
            Pet_1_Type = user.Pet_1_Type,
            Pet_2 = user.Pet_2,
            Pet_2_Type = user.Pet_2_Type,
            Pet_3 = user.Pet_3,
            Pet_3_Type = user.Pet_3_Type,
        };
    }
}
