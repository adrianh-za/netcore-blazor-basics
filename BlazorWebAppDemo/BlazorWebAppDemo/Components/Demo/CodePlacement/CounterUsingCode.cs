﻿using Microsoft.AspNetCore.Components;

namespace BlazorWebAppDemo.Components.Demo.CodePlacement;

[Route("/counterusingcode")]
public partial class CounterUsingCode : global::Microsoft.AspNetCore.Components.ComponentBase
{
    protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
    {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
        __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) =>
        {
            __builder2.AddContent(2, "Counter");
        }
        ));
        __builder.CloseComponent();
        __builder.AddMarkupContent(3, "\r\n");
        __builder.AddMarkupContent(4, "<h1>Counter</h1>\r\n");
        __builder.OpenElement(5, "p");
        __builder.AddAttribute(6, "role", "status");
        __builder.AddContent(7, "Current count: ");
        __builder.AddContent(8, currentCount);
        __builder.CloseElement();
        __builder.AddMarkupContent(9, "\r\n");
        __builder.OpenElement(10, "button");
        __builder.AddAttribute(11, "class", "btn btn-primary");
        __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, IncrementCount));
        __builder.AddContent(13, "Click me");
        __builder.CloseElement();
    }


    private int currentCount = 0;
    private void IncrementCount()
    {
        currentCount++;
    }

}