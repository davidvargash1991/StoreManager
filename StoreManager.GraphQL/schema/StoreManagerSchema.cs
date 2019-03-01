using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManager.GraphQL.schema
{
    public class StoreManagerSchema : global::GraphQL.Types.Schema
    {
        public StoreManagerSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<StoreManagerQuery>();
            Mutation = resolver.Resolve<StoreManagerMutation>();
        }
    }
}