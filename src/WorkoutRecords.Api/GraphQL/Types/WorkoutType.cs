using GraphQL.Types;
using WorkoutRecords.Domain.DDD;

namespace WorkoutRecords.Api.GraphQL.Types
{
    public class WorkoutType : ObjectGraphType<Workout>
    {
        public WorkoutType()
        {
            Field(x => x.Id).Description("The ID of the Workout.");
            Field(x => x.Name).Description("The name of the Workout.");
            Field(x => x.Description, nullable: true).Description("The description of the Workout.");
            Field<ListGraphType<WorkoutMovementType>>(
                "movements",
                resolve: context => context.Source.Movements
            );
            Field(x => x.TimeCap).Description("The time cap of the Workout.");
            Field(x => x.RoundsCount).Description("The number of rounds in the Workout.");
        }
    }
}
