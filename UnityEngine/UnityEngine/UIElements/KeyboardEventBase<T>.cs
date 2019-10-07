using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class KeyboardEventBase<T> : UIElements.EventBase<T>, UIElements.IKeyboardEvent
{
    static public T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers);
    static public T GetPooled(Event systemEvent);

    public bool actionKey { get; }
    public bool altKey { get; }
    public char character { get; protected set; }
    public bool commandKey { get; }
    public bool ctrlKey { get; }
    public KeyCode keyCode { get; protected set; }
    public EventModifiers modifiers { get; protected set; }
    public bool shiftKey { get; }

    protected KeyboardEventBase();

    protected void Init();

}

}
