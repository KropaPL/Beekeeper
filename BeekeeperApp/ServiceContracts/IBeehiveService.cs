using Entities;
using ServiceContracts.DTOs;

namespace ServiceContracts
{
    public interface IBeehiveService
    {
        Beehive AddBeehive(Beehive beehive);
        Beehive DeleteBeehive(Guid? id);
        List<Beehive> GetAllBeehives();
        Beehive? GetBeehiveByID(Beehive beehive);
        List<Beehive> GetFilteredBeehive(string searchBy, string? searchString);
        Beehive UpdateBeehive(BeehiveDto beehiveDto);

    }
}
