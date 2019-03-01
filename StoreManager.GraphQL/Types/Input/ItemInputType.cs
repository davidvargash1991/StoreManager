using GraphQL.Types;
using StoreManager.Data.Entities;

namespace StoreManager.GraphQL.Types.Input
{
    public class ItemInputType : InputObjectGraphType<Item>
    {
        public ItemInputType()
        {
            Name = "ItemInput";
            Field(x => x.Name);
            Field(x => x.Price);
            Field(x => x.Tax);
        }
    }
}
