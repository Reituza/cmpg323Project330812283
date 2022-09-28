using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using DeviceManagement_WebApp.Repositories;

namespace DeviceManagement_WebApp.Repositories
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Zone GetMostRecentZone()
        {
            return _context.Zone.OrderByDescending(Zone => Zone.ZoneName).FirstOrDefault();
        }

        public Zone GetMostRecentService()
        {
            throw new System.NotImplementedException();
        }
    }
}
