using HNGBackendTask.Model;
using System.Text.Json;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/api", (string? slack_name, string? track) =>
{

    var slackItem = SlackTestingRepository.Slacks
                    .Where(slack => slack.SlackName == slack_name && slack.Track == track)
                    .FirstOrDefault();
    var options = new JsonSerializerOptions()
    {
        WriteIndented = true,
        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
        AllowTrailingCommas = true,
    };
  


    return Results.Json(slackItem, options);

});
app.Run();
