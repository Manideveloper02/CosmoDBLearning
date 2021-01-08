namespace todo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.Azure.Cosmos;

    public class CosmosDbService<T> : ICosmosDbService<T> where T:class
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }
        
        public async Task AddItemAsync(T item)
        {
            Type t = item.GetType();
            var pkey = t.GetProperty("Id").GetValue(item).ToString();
            await this._container.CreateItemAsync(item, new PartitionKey(pkey));
        }

        public async Task DeleteItemAsync(string id)
        {
            await this._container.DeleteItemAsync<T>(id, new PartitionKey(id));
        }

        public async Task<T> GetItemAsync(string id)
        {
            try
            {
                ItemResponse<T> response = await this._container.ReadItemAsync<T>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch(CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            { 
                return null;
            }

        }

        public async Task<IEnumerable<T>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<T>(new QueryDefinition(queryString));
            List<T> results = new List<T>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                
                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateItemAsync(string id, T item)
        {
            await this._container.UpsertItemAsync<T>(item, new PartitionKey(id));
        }
    }
}
