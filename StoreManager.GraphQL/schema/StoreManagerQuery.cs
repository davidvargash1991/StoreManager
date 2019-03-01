using GraphQL.Types;
using StoreManager.Business.Facade;
using StoreManager.GraphQL.Types;

namespace StoreManager.GraphQL.schema
{
    public class StoreManagerQuery : ObjectGraphType<object>
    {
        public StoreManagerQuery()
        {
            ItemsFacade itemsFacade = new ItemsFacade();

            Name = "Query";

            Field<ItemType>(
                name: "item",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return itemsFacade.GetItemById(id);
                }
            );

            Field<ListGraphType<ItemType>>(
                name: "items",
                resolve: context =>
                {
                    return itemsFacade.GetItems();
                }
            );
        }
    }
}