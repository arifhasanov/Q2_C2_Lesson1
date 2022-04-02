string? summaryTextToWriteToFile = "";

for (int i = 4; i <= 13; i++)
{
    Task<Post> task = GetPosts(i);
    summaryTextToWriteToFile += task.Result.ToString();
}

static async Task<Post> GetPosts(int postId)
{
    HttpClient client = new HttpClient();
    string responseBody = await client.GetStringAsync($"https://jsonplaceholder.typicode.com/posts/{postId}");
    Post? post = JsonSerializer.Deserialize<Post>(responseBody);
    return post!;
}

string fileName = "result.txt";
File.WriteAllText(fileName, summaryTextToWriteToFile);