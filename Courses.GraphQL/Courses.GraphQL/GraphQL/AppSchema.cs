using Courses.GraphQL.GraphQL.Queries;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL
{
    public class AppSchema: Schema
    {
        public AppSchema(CourseQuery query)
        {
            this.Query = query;
        }
    }
}
