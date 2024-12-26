namespace BlazorWebAppDemo.Services;

public class StateService: IStateService
{
    private List<string> _messages = [];

    public event Action? OnChange;

    public IEnumerable<string> GetMessages() => _messages;

    public async Task AddMessage(string message)
    {
        _messages.Add(message);
        await Task.Delay(1);

        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}