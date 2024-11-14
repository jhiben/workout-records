using GraphQL.Types;
using WorkoutRecords.Domain.DDD;

namespace WorkoutRecords.Api.GraphQL.Types
{
    public class MovementType : ObjectGraphType<Movement>
    {
        public MovementType()
        {
            Field(x => x.Id).Description("The ID of the Movement.");
            Field(x => x.Name).Description("The name of the Movement.");
            Field(x => x.Description, nullable: true).Description("The description of the Movement.");
        }
    }
}
