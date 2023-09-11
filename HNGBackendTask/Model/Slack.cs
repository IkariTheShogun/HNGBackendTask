using System;
using System.Text.Json.Serialization;

namespace HNGBackendTask.Model
{
	public class Slack
	{
		

		//private readonly string  utctime = DateTime.Now.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'");


		[JsonPropertyName("slack_name")]
		public string? SlackName { get; set; }

		[JsonPropertyName("current_day")]
		public string CurrentDay { get; set; }

		[JsonPropertyName("utc_time")]
		public object UtcTime { get; set; }

		//var currentDateTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");

		//public dynamic UtcTime
		//{
		//	get { return utctime;  }
		//	init {   utctime = value;  }

		//}

		[JsonPropertyName("track")]
		public string Track { get; set; }

		[JsonPropertyName("github_file_url")]
		public string GithubFileUrl { get; set; }

		[JsonPropertyName("github_repo_url")]
		public string GithubRepoUrl { get; set; }

		[JsonPropertyName("status_code")]
		public int StatusCode { get; set; }

		//DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'")
	}
}
