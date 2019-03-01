using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using StoreManager.GraphQL.schema;

namespace StoreManager.Backend.Controllers.GraphQL
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class GraphQLController : ControllerBase
    {
        public GraphQLController()
        {

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var schema = new Schema { Query = new StoreManagerQuery(), Mutation = new StoreManagerMutation() };
            var result = await new DocumentExecuter().ExecuteAsync(x =>
            {
                x.Schema = schema;
                x.Query = query.Query;
                x.OperationName = query.OperationName;
                x.Inputs = query.Variables;
            });
            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}