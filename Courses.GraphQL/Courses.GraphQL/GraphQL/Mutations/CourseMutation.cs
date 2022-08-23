using Courses.GraphQL.Data.Models;
using Courses.GraphQL.Data.Repositories;
using Courses.GraphQL.GraphQL.Types;
using GraphQL;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Mutations
{
    public class CourseMutation: ObjectGraphType
    {
        public CourseMutation(CoursesRepository courseRepository)
        {
            Field<CourseType>(
                name: "AddCourse", 
                description: "Is used to add a new course to the database", 
                arguments: new QueryArguments( 
                    new QueryArgument<NonNullGraphType<CourseInputType>>() { Name = "Course", Description = "Course input parameter"}), 
                resolve: context =>
                    {
                        var course = context.GetArgument<Course>("course");
                        return courseRepository.AddCourse(course);
                    });

            Field<CourseType>(
                name: "UpdateCourse",
                description: "Is used to update a course by Id",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>>() { Name = "Id", Description = "Course Id parameter" },
                    new QueryArgument<NonNullGraphType<CourseInputType>>() { Name = "Course", Description = "Course input parameter" }),
                resolve: context =>
                {
                    var course = context.GetArgument<Course>("course");
                    var id = context.GetArgument<int>("Id");
                    return courseRepository.UpdateCourse(id, course);
                });

            Field<CourseType>(
                name: "DeleteCourse",
                description: "Is used to delete a course by Id",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>>() { Name = "Id", Description = "Course Id parameter" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("Id");
                    courseRepository.DeleteCourse(id);
                    return true;
                });
        }
    }
}
