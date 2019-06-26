using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace REST_API_Placeholder_2.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CallsController : ControllerBase
	{
		private IMemoryCache _memoryStore;
		public CallsController(IMemoryCache memoryStore)
		{
			_memoryStore = memoryStore;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get(Guid id)
		{
			object value;
			if (_memoryStore.TryGetValue(id, out value))
				return Ok(value);
			return NotFound($"Method call with id {id} could not be found");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			await Task.Factory.StartNew(() => { _memoryStore.Remove(id); });
			return Ok($"Deleted {id}");
		}
	}
}