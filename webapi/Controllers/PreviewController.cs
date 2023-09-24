using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Azure.Cosmos;
using webapi.DataTransferObjects;
using webapi.Models;
namespace webapi.Controllers
{
    [Route("api/preview")]
    [ApiController]
    public class PreviewController : ControllerBase
    {
        private readonly string CosmosDBAccountUri = "https://localhost:8081/";
        private readonly string CosmosDBAccountPrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
        private readonly string CosmosDbName = "Assignment";
        private string CosmosDbContainerName = null;
        /*private Container ContainerClient()
        {

            CosmosClient cosmosDbClient = new CosmosClient(CosmosDBAccountUri, CosmosDBAccountPrimaryKey);
            Container containerClient = cosmosDbClient.GetContainer(CosmosDbName, CosmosDbContainerName);
            return containerClient;
        }*/

        [HttpGet("/application-form")]
        public async Task<IActionResult> ApplicationForm()
        {
            try
            {
                CosmosDbContainerName = "Application Form";
                CosmosClient cosmosDbClient = new CosmosClient(CosmosDBAccountUri, CosmosDBAccountPrimaryKey);
                Container containerClient = cosmosDbClient.GetContainer(CosmosDbName, CosmosDbContainerName);
                var container = containerClient; 
                var sqlQuery = "SELECT * FROM c";
                QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
                FeedIterator<ApplicationFormModel> queryResultSetIterator = container.GetItemQueryIterator<ApplicationFormModel>(queryDefinition);


                List<ApplicationFormModel> employees = new List<ApplicationFormModel>();

                while (queryResultSetIterator.HasMoreResults)
                {
                    FeedResponse<ApplicationFormModel> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    foreach (ApplicationFormModel employee in currentResultSet)
                    {
                        employees.Add(employee);
                    }
                }

                return Ok(employees);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!!" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("/program-details")]
        public async Task<IActionResult> ProgramDetails()
        {
            try
            {
                CosmosDbContainerName = "Program Details";
                CosmosClient cosmosDbClient = new CosmosClient(CosmosDBAccountUri, CosmosDBAccountPrimaryKey);
                Container containerClient = cosmosDbClient.GetContainer(CosmosDbName, CosmosDbContainerName);
                var container = containerClient;
                var sqlQuery = "SELECT * FROM c";
                QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
                FeedIterator<ProgramDetailsModel> queryResultSetIterator = container.GetItemQueryIterator<ProgramDetailsModel>(queryDefinition);


                List<ProgramDetailsModel> employees = new List<ProgramDetailsModel>();

                while (queryResultSetIterator.HasMoreResults)
                {
                    FeedResponse<ProgramDetailsModel> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    foreach (ProgramDetailsModel employee in currentResultSet)
                    {
                        employees.Add(employee);
                    }
                }

                return Ok(employees);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!!" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("/workflow")]
        public async Task<IActionResult> Workflow()
        {
            try
            {

                CosmosDbContainerName = "Workflow";
                CosmosClient cosmosDbClient = new CosmosClient(CosmosDBAccountUri, CosmosDBAccountPrimaryKey);
                Container containerClient = cosmosDbClient.GetContainer(CosmosDbName, CosmosDbContainerName);
                var container = containerClient;
                var sqlQuery = "SELECT * FROM c";
                QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
                FeedIterator<WorkflowModel> queryResultSetIterator = container.GetItemQueryIterator<WorkflowModel>(queryDefinition);


                List<WorkflowModel> employees = new List<WorkflowModel>();

                while (queryResultSetIterator.HasMoreResults)
                {
                    FeedResponse<WorkflowModel> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    foreach (WorkflowModel employee in currentResultSet)
                    {
                        employees.Add(employee);
                    }
                }

                return Ok(employees);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!!" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
