using GraphQL.Types;
using WorkoutRecords.Api.GraphQL.Types;

namespace WorkoutRecords.Api.GraphQL
{
    public class WorkoutRecordsSchema : Schema
    {
        public WorkoutRecordsSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<WorkoutRecordsQuery>();
            Mutation = provider.GetRequiredService<WorkoutRecordsMutation>();
        }
    }
}
