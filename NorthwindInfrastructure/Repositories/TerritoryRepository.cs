using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindInfrastructure.Repositories
{
    public class TerritoryRepository : ITerritoryRepository
    {
        private readonly Northwind _dbcontext;
        public TerritoryRepository(Northwind dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Territory> GetTerritories()
        {
            return _dbcontext.Territories.ToList();
        }

        public Territory GetTerritory(string id)
        {
            return _dbcontext.Territories.SingleOrDefault(t => t.TerritoryId == id);
        }
        public Territory CreateTerritory(Territory territory)
        {
            _dbcontext.Add(territory);
            _dbcontext.SaveChanges();
            return territory;
        }

        public void DeleteTerritory(string id)
        {
            var territory = _dbcontext.Territories.SingleOrDefault(t => t.TerritoryId == id);
            _dbcontext.Remove(territory);
            _dbcontext.SaveChanges();
        }

    }
}