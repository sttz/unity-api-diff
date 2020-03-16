using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class MouseEventBase<T> : UIElements.EventBase<T>, UIElements.IMouseEvent, UIElements.IMouseEventInternal
{
    static protected T GetPooled(UIElements.IPointerEvent pointerEvent);
    static public T GetPooled(Event systemEvent);
    static public T GetPooled(UIElements.IMouseEvent triggerEvent);
    static public T GetPooled(Vector2 position, int button, int clickCount, Vector2 delta, EventModifiers modifiers = 0);

    public bool actionKey { get; }
    public bool altKey { get; }
    public int button { get; protected set; }
    public int clickCount { get; protected set; }
    public bool commandKey { get; }
    public bool ctrlKey { get; }
    public UIElements.IEventHandler currentTarget { get; internal set; }
    public Vector2 localMousePosition { get; internal set; }
    public EventModifiers modifiers { get; protected set; }
    public Vector2 mouseDelta { get; protected set; }
    public Vector2 mousePosition { get; protected set; }
    public int pressedButtons { get; protected set; }
    public bool shiftKey { get; }

    protected MouseEventBase();

    protected void Init();

}

}