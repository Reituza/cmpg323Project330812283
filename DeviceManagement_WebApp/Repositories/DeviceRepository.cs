using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using DeviceManagement_WebApp.Repositories;

namespace DeviceManagement_WebApp.Repositories
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Device GetMostRecentCategory()
        {
            return _context.Device.OrderByDescending(Device => Device.DeviceName).FirstOrDefault();
        }

        public Device GetMostRecentService()
        {
            throw new System.NotImplementedException();
        }
    }
}
