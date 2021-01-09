using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

namespace todo.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class CoreController<TEntity> : ControllerBase
        where TEntity : class

    {
        private readonly ICosmosDbService<TEntity> _cosmosDbService;
        public const string _databaseName = "SampleDBTest";
        public CoreController(CosmosClient cosmosClient, string containerName)
        {
            _cosmosDbService = new CosmosDbService<TEntity>(cosmosClient, _databaseName, containerName);
        }
       

        // GET: api/[controller]
        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get()
        {
            var value = await _cosmosDbService.GetItemsAsync("SELECT * FROM c");
            return value;
        }

    }

}
