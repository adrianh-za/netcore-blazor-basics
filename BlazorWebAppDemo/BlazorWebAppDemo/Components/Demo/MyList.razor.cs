using Microsoft.AspNetCore.Components;

namespace BlazorWebAppDemo.Demo;

public partial class MyList : ComponentBase
{
    private List<string> items = new List<string> { "Item 1", "Item 2", "Item 3" };

    private void AddItem()
    {
        items.Add($"Item {items.Count + 1}");
    }

    private void RemoveItem()
    {
        items.RemoveAt(items.Count - 1);
    }
}