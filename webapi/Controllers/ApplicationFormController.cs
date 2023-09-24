using System;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mv
using Microsoft.Azure.Cosmos;
using webapi.DataTransferObjects;
using webapi.Models;
namespace webapi.Controllers
{
    [Route("api/application-form")]
    [ApiController]
    public class ApplicationFormController : ControllerBase
    {
        private readonly string CosmosDBAccountUri = "https://localhost:8081/";
        private readonly string CosmosDBAccountPrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
        private readonly string CosmosDbName = "Assignment";
        private readonly string CosmosDbContainerName = "Application Form";
        private Container ContainerClient()
        {

            CosmosClient cosmosDbClient = new CosmosClient(CosmosDBAccountUri, CosmosDBAccountPrimaryKey);
            Container containerClient = cosmosDbClient.GetContainer(CosmosDbName, CosmosDbContainerName);
            return containerClient;
        }
        [HttpPost]
        public async Task<IActionResult> ApplicationForm([FromBody] ApplicationFormDTO product)
        {
            try
            {
                if (product is null)
                {
                    Console.WriteLine("the body is null");
                    return BadRequest("The Body is Null Currently!!");
                }
                if (!ModelState.IsValid)
                {
                    Console.WriteLine("Invalid owner object sent from client.");
                    return BadRequest("The Object is Invalid");
                }
                var container = ContainerClient();
                var response = await container.CreateItemAsync(product);
                Console.WriteLine("Success");
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!!" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
