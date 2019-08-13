using GraphQL;
using GraphQL.Types;
using GraphQLDotNetCore.GraphQL.GraphQLQueries;


public class AppSchema : Schema
{
    public AppSchema(IDependencyResolver resolver)
        : base(resolver)
    {
        Query = resolver.Resolve<AppQuery>();
    }
}

