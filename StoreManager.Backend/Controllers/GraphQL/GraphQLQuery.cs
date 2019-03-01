using GraphQL;

namespace StoreManager.Backend.Controllers.GraphQL
{
    public class GraphQLQuery
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public Inputs Variables { get; set; }
    }
}
