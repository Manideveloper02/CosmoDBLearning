using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace todo.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class CoreController<TEntity> : ControllerBase
        where TEntity : class

    {
        private readonly ICosmosDbService<TEntity> _cosmosDbService;
        public CoreController(ICosmosDbService<TEntity> cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }
        // GET: api/[controller]
        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get()
        {
            //return await repository.GetAll();
            var value = await _cosmosDbService.GetItemsAsync("SELECT * FROM c");
            return value;
        }


    }

}
