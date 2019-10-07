using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class MouseEventBase<T> : Experimental.UIElements.EventBase<T>, Experimental.UIElements.IMouseEvent, Experimental.UIElements.IMouseEventInternal
{
    static public T GetPooled(Event systemEvent);
    static public T GetPooled(Vector2 mousePosition);
    static public T GetPooled(Experimental.UIElements.IMouseEvent triggerEvent);

    public bool actionKey { get; }
    public bool altKey { get; }
    public int button { get; protected set; }
    public int clickCount { get; protected set; }
    public bool commandKey { get; }
    public bool ctrlKey { get; }
    public Experimental.UIElements.IEventHandler currentTarget { get; internal set; }
    public Vector2 localMousePosition { get; internal set; }
    public EventModifiers modifiers { get; protected set; }
    public Vector2 mouseDelta { get; protected set; }
    public Vector2 mousePosition { get; protected set; }
    public bool shiftKey { get; }

    protected MouseEventBase();

    protected void Init();

}

}
