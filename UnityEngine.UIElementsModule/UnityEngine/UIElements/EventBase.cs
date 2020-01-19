using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class EventBase : IDisposable
{
    static protected long RegisterEventType();

    public bool bubbles { get; }
    public UIElements.IEventHandler currentTarget { get; internal set; }
    public bool dispatch { get; internal set; }
    public long eventTypeId { get; }
    public Event imguiEvent { get; protected set; }
    public bool isDefaultPrevented { get; private set; }
    public bool isImmediatePropagationStopped { get; private set; }
    public bool isPropagationStopped { get; private set; }
    public Vector2 originalMousePosition { get; private set; }
    protected bool pooled { get; set; }
    public UIElements.PropagationPhase propagationPhase { get; internal set; }
    public UIElements.IEventHandler target { get; set; }
    public long timestamp { get; private set; }
    public bool tricklesDown { get; }

    protected EventBase();

    public void Dispose();
    protected void Init();
    public void PreventDefault();
    public void StopImmediatePropagation();
    public void StopPropagation();

}

}
