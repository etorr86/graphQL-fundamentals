﻿using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types
{
    public class CourseType:ObjectGraphType<Course>
    {
        public CourseType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the Course Object");
            Field(x => x.Name, type: typeof(StringGraphType)).Description("Name property from the Course Object");
            Field(x => x.Description, type: typeof(StringGraphType)).Description("Description property from the Course Object");
            Field(x => x.Review, type: typeof(IntGraphType)).Description("Review property from the Course Object");
            Field(x => x.DateAdded, type: typeof(DateTimeGraphType)).Description("DateAdded property from the Course Object");
            Field(x => x.DateUpdated, type: typeof(DateTimeGraphType)).Description("DateUpdated property from the Course Object");
        }
    }
}
