using GraphQL.Types;
using StoreManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManager.GraphQL.Types
{
    public class PackingType : ObjectGraphType<Packing>
    {
        public PackingType()
        {
            Name = "Packing";
            Field(h => h.Id).Description("The id of the packing.");
            Field(h => h.Label).Description("The label of the packing.");
            Field(h => h.Factor).Description("The factor of the packing.");
        }
    }
}
