namespace Lesson1;
public class Post
{
    public int userId { get; set; }
    public int id { get; set; }
    public string? title { get; set; }
    public string? body { get; set; }

    public override string ToString()
    {
        string result = "";
        result += userId.ToString();
        result += "\n";
        result += id.ToString();
        result += "\n";
        result += title;
        result += "\n";
        result += body;
        result += "\n";
        result += "\n";
        return result;
    }
}
