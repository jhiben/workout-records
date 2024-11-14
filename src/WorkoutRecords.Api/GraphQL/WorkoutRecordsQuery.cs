using GraphQL.Types;
using WorkoutRecords.Api.GraphQL.Types;
using WorkoutRecords.Domain.DDD;

namespace WorkoutRecords.Api.GraphQL
{
    public class WorkoutRecordsQuery : ObjectGraphType
    {
        public WorkoutRecordsQuery()
        {
            Field<ListGraphType<WorkoutRecordType>>(
                "workoutRecords",
                resolve: context => GetWorkoutRecords()
            );
        }

        private List<WorkoutRecord> GetWorkoutRecords()
        {
            // Placeholder for fetching workout records data
            return new List<WorkoutRecord>();
        }
    }
}
