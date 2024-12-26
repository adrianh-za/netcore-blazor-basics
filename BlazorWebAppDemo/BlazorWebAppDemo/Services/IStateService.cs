namespace BlazorWebAppDemo.Services;

public interface IStateService
{
    IEnumerable<string> GetMessages();

    event Action? OnChange;
    Task AddMessage(string message);
}