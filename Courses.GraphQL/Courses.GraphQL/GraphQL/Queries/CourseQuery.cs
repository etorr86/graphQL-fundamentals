using Courses.GraphQL.Data.Repositories;
using Courses.GraphQL.GraphQL.Types;
using GraphQL;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Queries
{
    public class CourseQuery : ObjectGraphType
    {
        public CourseQuery(CoursesRepository coursesRepository)
        {
            Field<ListGraphType<CourseType>>(
                name: "courses", 
                description: "Return list of courses", 
                resolve: context => coursesRepository.GetAllCourses());
            
            Field<CourseType>(
                name: "course", 
                description: "Return a single course by id", 
                new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Course Id" }), 
                resolve: context => coursesRepository.GetCourseById(context.GetArgument("id", int.MinValue)));
        }
    }
}
