using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class KeyboardEventBase<T> : Experimental.UIElements.EventBase<T>, Experimental.UIElements.IKeyboardEvent
{
    static public T GetPooled(Event systemEvent);
    static public T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers);

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
