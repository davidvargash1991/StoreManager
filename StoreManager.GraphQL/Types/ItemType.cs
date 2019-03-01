using GraphQL.Types;
using StoreManager.Business.Facade;
using StoreManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManager.GraphQL.Types
{
    public class ItemType : ObjectGraphType<Item>
    {
        public ItemType()
        {
            ItemsFacade facade = new ItemsFacade();
            Name = "Item";
            Field(h => h.Id).Description("The id of the item.");
            Field(h => h.Name).Description("The name of the item.");
            Field(h => h.Price).Description("The Price of the item.");
            Field(h => h.Tax).Description("The Tax percentage of the item.");
            Field<ListGraphType<PackingType>>(
                "packings",
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return facade.GetPackingsById(id);
                }
            );
        }
    }
}
