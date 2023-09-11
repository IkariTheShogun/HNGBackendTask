using System;
using System.Text.Json.Serialization;

namespace HNGBackendTask.Model
{
	public class Slack
	{ 
		[JsonPropertyName("slack_name")]
		public string? SlackName { get; set; }

		[JsonPropertyName("current_day")]
		public string CurrentDay { get; set; }

		[JsonPropertyName("utc_time")]
		public object UtcTime { get; set; }

		[JsonPropertyName("track")]
		public string Track { get; set; }

		[JsonPropertyName("github_file_url")]
		public string GithubFileUrl { get; set; }

		[JsonPropertyName("github_repo_url")]
		public string GithubRepoUrl { get; set; }

		[JsonPropertyName("status_code")]
		public int StatusCode { get; set; }

	}
}
