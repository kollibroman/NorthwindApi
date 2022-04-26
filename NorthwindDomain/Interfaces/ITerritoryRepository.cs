using NorthwindDomain.AutoGen;

namespace NorthwindDomain.Interfaces
{
    public interface ITerritoryRepository
    {
        IEnumerable<Territory> GetTerritories();
        Territory GetTerritory(string id);
        Territory CreateTerritory(Territory territory);
        void DeleteTerritory(string id);
    }
}