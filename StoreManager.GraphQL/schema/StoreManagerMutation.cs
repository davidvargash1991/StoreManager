using GraphQL.Types;
using StoreManager.Business.Facade;
using StoreManager.Data.Entities;
using StoreManager.GraphQL.Types;
using StoreManager.GraphQL.Types.Input;

namespace StoreManager.GraphQL.schema
{
    public class StoreManagerMutation : ObjectGraphType<object>
    {
        public StoreManagerMutation()
        {
            ItemsFacade itemsFacade = new ItemsFacade();

            Name = "Mutation";

            Field<ItemType>(
                name: "createItem",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ItemInputType>> { Name = "item" }
                ),
                resolve: context =>
                {
                    var item = context.GetArgument<Item>("item");
                    return itemsFacade.AddItem(item);
                }
            );
        }
    }
}
