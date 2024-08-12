using Entities;
using ServiceContracts.DTOs;

namespace ServiceContracts
{
    public interface IBeehiveService
    {
        BeehiveDto AddBeehive(Beehive beehive);
        BeehiveDto DeleteBeehive(Guid? id);
        List<BeehiveDto> GetAllBeehives();
        BeehiveDto? GetBeehiveByID(Beehive beehive);
        List<BeehiveDto> GetFilteredBeehive(string searchBy, string? searchString);
        BeehiveDto UpdateBeehive(BeehiveDto beehiveDto);

    }
}
