using Microsoft.AspNetCore.Mvc;

using todo.Models;

namespace todo.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : CoreController<Item>
    {
        public TestController(ICosmosDbService<Item> repository) : base(repository)
        {
        }
    }
}
