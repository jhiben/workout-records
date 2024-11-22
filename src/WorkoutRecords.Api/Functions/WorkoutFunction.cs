using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WorkoutRecords.Api.Functions
{
    public static class WorkoutFunction
    {
        [FunctionName("GetWorkout")]
        public static async Task<IActionResult> GetWorkout(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "workout/{id}")] HttpRequest req,
            ILogger log, string id)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            // Simulate fetching workout data
            var workout = new
            {
                Id = id,
                Name = "Sample Workout",
                Movements = new[]
                {
                    new { Name = "Push-Up", Reps = 20 },
                    new { Name = "Pull-Up", Reps = 10 }
                }
            };

            return new OkObjectResult(workout);
        }

        [FunctionName("CreateWorkout")]
        public static async Task<IActionResult> CreateWorkout(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "workout")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            // Simulate creating a workout
            var workout = new
            {
                Id = Guid.NewGuid().ToString(),
                Name = data?.Name,
                Movements = data?.Movements
            };

            return new OkObjectResult(workout);
        }
    }
}
