using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IKeyboardEvent
{
    public bool actionKey { get; }
    public bool altKey { get; }
    public char character { get; }
    public bool commandKey { get; }
    public bool ctrlKey { get; }
    public KeyCode keyCode { get; }
    public EventModifiers modifiers { get; }
    public bool shiftKey { get; }

}

}
