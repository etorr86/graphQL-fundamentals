using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Mutations
{
    internal class CourseInputType : InputObjectGraphType
    {
        public CourseInputType()
        {
            Name = "CourseInputType";

            Field<IdGraphType>("Id");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("Description");
            Field<IntGraphType>("Review");
            Field<DateTimeGraphType>("DateAdded");
            Field<DateTimeGraphType>("DateUpdated");
        }
    }
}