namespace HNGBackendTask.Model
{
    public class SlackTestingRepository
    {
        public static List<Slack> Slacks { get; set; } = new List<Slack>()
        {
            new Slack()
            {
                SlackName="IkariTheShogun",
                CurrentDay = DateTime.Now.Date.DayOfWeek.ToString(),
                UtcTime=DateTime.UtcNow,
                Track="backend",
                GithubFileUrl="https://github.com/IkariTheShogun/HNGBackendTask/blob/master/HNGBackendTask/Program.cs",
                GithubRepoUrl="https://github.com/IkariTheShogun/HNGBackendTask",
                StatusCode=200


            }

        };
    }
}
