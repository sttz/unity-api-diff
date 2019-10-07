using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class DropdownMenuEventInfo
{
    public Vector2 localMousePosition { get; }
    public EventModifiers modifiers { get; }
    public Vector2 mousePosition { get; }

    public DropdownMenuEventInfo(UIElements.EventBase e);

}

}
