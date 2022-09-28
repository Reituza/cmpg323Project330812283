using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repositories;
using DeviceManagement_WebApp.Controllers;

namespace DeviceManagement_WebApp.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetMostRecentService();
    }

}
