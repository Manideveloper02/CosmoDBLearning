namespace todo
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    using todo.Models;
    using Microsoft.Azure.Cosmos;
    using todo.Services;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // <ConfigureServices> 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSingleton(InitializeCosmosClientInstance(Configuration.GetSection("CosmosDb")));
            services.AddScoped<TestRepo>();
        }
        // </ConfigureServices> 

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Item}/{action=Index}/{id?}");
            });
        }

        private static CosmosClient InitializeCosmosClientInstance(IConfigurationSection configurationSection)
        {
            string account = configurationSection.GetSection("Account").Value;
            string key = configurationSection.GetSection("Key").Value;
            CosmosClientOptions clientOptions = new CosmosClientOptions() { SerializerOptions = new CosmosSerializationOptions() { IgnoreNullValues = true } };
            CosmosClient client = new CosmosClient(account, key, clientOptions);
            return client;
        }

        public static async Task InitializeDatabase(CosmosClient cosmosClient, string databaseName)
        {
            DatabaseResponse database = await cosmosClient.CreateDatabaseIfNotExistsAsync(databaseName);
        }

        public static async Task InitializeContainer(DatabaseResponse database, string containerName, string partitionKeyPath)
        {
            await database.Database.CreateContainerIfNotExistsAsync(containerName, partitionKeyPath);
        }

    }
}
