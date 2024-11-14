using GraphQL.Types;
using WorkoutRecords.Domain.DDD;

namespace WorkoutRecords.Api.GraphQL.Types
{
    public class WorkoutMovementType : ObjectGraphType<WorkoutMovement>
    {
        public WorkoutMovementType()
        {
            Field(x => x.Id).Description("The ID of the Workout Movement.");
            Field(x => x.Movement).Description("The movement of the Workout Movement.");
            Field(x => x.Reps, nullable: true).Description("The reps of the Workout Movement.");
            Field(x => x.Weight, nullable: true).Description("The weight of the Workout Movement.");
            Field(x => x.Distance, nullable: true).Description("The distance of the Workout Movement.");
        }
    }
}
