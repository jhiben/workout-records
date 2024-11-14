using GraphQL.Types;
using WorkoutRecords.Api.GraphQL.Types;
using WorkoutRecords.Domain.DDD;

namespace WorkoutRecords.Api.GraphQL
{
    public class WorkoutRecordsMutation : ObjectGraphType
    {
        public WorkoutRecordsMutation()
        {
            Field<WorkoutRecordType>(
                "createWorkoutRecord",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<WorkoutRecordInputType>> { Name = "workoutRecord" }
                ),
                resolve: context =>
                {
                    var workoutRecord = context.GetArgument<WorkoutRecord>("workoutRecord");
                    return CreateWorkoutRecord(workoutRecord);
                }
            );
        }

        private WorkoutRecord CreateWorkoutRecord(WorkoutRecord workoutRecord)
        {
            // Placeholder for creating a new workout record
            return workoutRecord;
        }
    }
}
