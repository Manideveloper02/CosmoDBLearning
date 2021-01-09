using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

using todo.Models;

namespace todo.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : CoreController<Item>
    {
        private const string ContainerName = "Test";
        public TestController(CosmosClient cosmosClient) : base(cosmosClient, ContainerName)
        {
        }
    }
}
