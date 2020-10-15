using System.Collections.Generic;
using Eventhut.Models;

namespace Eventhut.Data
{
    public interface IEventhutRepo
    {
        IEnumerable<Event> GetEvents();

        Event GetEventById(int id);
    }
}