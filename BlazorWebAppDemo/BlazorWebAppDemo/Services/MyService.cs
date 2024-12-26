namespace BlazorWebAppDemo.Services;

public class MyService: IMyService
{
    public MyService()
    {
        Names.Add("Alice");
        Names.Add("Bob");
        Names.Add("Charlie");
    }

    public List<string> Names { get; set; } = [];

    public void AddName(string name)
    {
        Names.Add(name);
    }
}