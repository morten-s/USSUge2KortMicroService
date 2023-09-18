namespace SpilleKort
{

  using System.Linq;
  using Microsoft.AspNetCore.Mvc;
  [Route("/")]
  public class SpilleKortController : Controller
  {
    private SpilleKort kortobj = new();
    
    [HttpGet("")]
    public Kort Get() => kortobj.HentKort();
  }
}