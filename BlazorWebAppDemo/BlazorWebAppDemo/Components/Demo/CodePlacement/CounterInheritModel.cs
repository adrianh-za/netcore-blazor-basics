using Microsoft.AspNetCore.Components;

namespace BlazorWebAppDemo.Components.Demo.CodePlacement;

public class CounterInheritModel:ComponentBase
{
    protected int currentCount = 0;
    protected void IncrementCount()
    {
        currentCount++;
    }
}