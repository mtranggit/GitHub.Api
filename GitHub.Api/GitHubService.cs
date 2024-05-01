namespace GitHub.Api;

public sealed class GitHubService(HttpClient httpClient)
{
    public async Task<GitHubUser?> GetByUserNameAsync(string userName)
    {
        var user = await httpClient.GetFromJsonAsync<GitHubUser>($"users/{userName}");
        return user;
    }
}
