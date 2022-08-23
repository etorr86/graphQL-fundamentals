using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Mutations
{
    internal class ReviewInputType : InputObjectGraphType
    {
        public ReviewInputType()
        {
            Name = "ReviewInputType";

            Field<IntGraphType>("Rate");
            Field<StringGraphType>("Comment");
        }
    }
}