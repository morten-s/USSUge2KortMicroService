namespace SpilleKort
{

  using System.Linq;
  using Microsoft.AspNetCore.Mvc;

  [Route("/kort")]
  public class SpilleKortController
  {
    private readonly IEventStore eventStore;

    public SpilleKortController(IEventStore eventStore) => this.eventStore = eventStore;
    
    [HttpGet("")]
    public Event[] Get([FromQuery] long start, [FromQuery] long end = long.MaxValue) => 
      this.eventStore.GetEvents(start, end).ToArray();
  }
}
}