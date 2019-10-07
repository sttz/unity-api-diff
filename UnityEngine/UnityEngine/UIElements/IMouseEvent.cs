using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IMouseEvent
{
    public bool actionKey { get; }
    public bool altKey { get; }
    public int button { get; }
    public int clickCount { get; }
    public bool commandKey { get; }
    public bool ctrlKey { get; }
    public Vector2 localMousePosition { get; }
    public EventModifiers modifiers { get; }
    public Vector2 mouseDelta { get; }
    public Vector2 mousePosition { get; }
    public int pressedButtons { get; }
    public bool shiftKey { get; }

}

}
