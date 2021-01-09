using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Azure.Cosmos;

using todo.Models;

namespace todo.Services
{
    public class TestRepo : CosmosDbService<Item>
    {
        public TestRepo(CosmosClient context) : base(context, "SampleDBTest", "Test")
        {

        }
    }
}
