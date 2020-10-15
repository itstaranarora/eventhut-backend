using System.Collections.Generic;
using Eventhut.Data;
using Eventhut.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eventhut.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventhutRepo _repository;

        public EventsController(IEventhutRepo repository)
        {
            _repository = repository;
        }
        // private readonly MockEventhutRepo _repository = new MockEventhutRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Event>> GetAllEvents()
        {   
            var eventItems = _repository.GetEvents();

            return Ok(eventItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Event> GetEventById(int id)
        {
            var eventItem = _repository.GetEventById(id);
            return Ok(eventItem);
        }
    }
}