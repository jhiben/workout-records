using GraphQL.Types;
using WorkoutRecords.Domain.DDD;

namespace WorkoutRecords.Api.GraphQL.Types
{
    public class WorkoutRecordType : ObjectGraphType<WorkoutRecord>
    {
        public WorkoutRecordType()
        {
            Field(x => x.Id).Description("The ID of the WorkoutRecord.");
            Field(x => x.Workout).Description("The workout associated with the record.");
            Field(x => x.Time).Description("The time taken to complete the workout.");
            Field(x => x.RepsCount).Description("The number of reps completed in the workout.");
        }
    }
}
