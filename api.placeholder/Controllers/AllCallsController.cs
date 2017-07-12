using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace api.placeholder.Controllers {

  public class AllCallsController : Controller 
  {
    private IMemoryCache _memoryStore;
    public AllCallsController (IMemoryCache memoryStore) 
    {
      _memoryStore = memoryStore;
    }

    public async Task<IActionResult> Default () 
    {
      var request = new Request () {
      Headers = HttpContext.Request.Headers,
      Body = new StreamReader (HttpContext.Request.Body).ReadToEnd (),
      Method = HttpContext.Request.Method,
      Querystring = HttpContext.Request.QueryString,
      Path = HttpContext.Request.Path
      };
      var requestId = Guid.NewGuid ();
      await Task.Factory.StartNew (() => { _memoryStore.Set (requestId, request); });
      return Ok (requestId.ToString ());
    }

  }

  class Request 
  {
    public IHeaderDictionary Headers { get; set; }
    public string Method { get; set; }
    public PathString Path { get; set; }
    public QueryString Querystring { get; set; }
    public string Body { get; set; }
  }
}