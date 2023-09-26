using HNGBackendTask.Model;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/api", (string? slack_name, string? track) =>
{

	Slack mySlack = new Slack()
	{
		SlackName = slack_name,
		CurrentDay = DateTime.Now.Date.DayOfWeek.ToString(),
		UtcTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
		Track = track,
		GithubFileUrl = "https://github.com/IkariTheShogun/HNGBackendTask/blob/master/HNGBackendTask/Program.cs",
		GithubRepoUrl = "https://github.com/IkariTheShogun/HNGBackendTask",
		StatusCode = 200


	};

	var options = new JsonSerializerOptions()
	{
		WriteIndented = true,
		DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
		AllowTrailingCommas = true,
	};



	return Results.Json(mySlack, options);

});
app.Run();
