using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class EventBase : IDisposable
{
    static protected long RegisterEventType();

    protected Experimental.UIElements.IEventHandler m_CurrentTarget;

    public bool bubbles { get; }
    public bool capturable { get; }
    public Experimental.UIElements.IEventHandler currentTarget { get; internal set; }
    public bool dispatch { get; internal set; }
    protected EventFlags flags { get; set; }
    public Event imguiEvent { get; protected set; }
    public bool isDefaultPrevented { get; private set; }
    public bool isImmediatePropagationStopped { get; private set; }
    public bool isPropagationStopped { get; private set; }
    public Vector2 originalMousePosition { get; private set; }
    protected bool pooled { get; set; }
    public Experimental.UIElements.PropagationPhase propagationPhase { get; internal set; }
    public Experimental.UIElements.IEventHandler target { get; set; }
    public long timestamp { get; private set; }
    public bool tricklesDown { get; }

    protected EventBase();

    public void Dispose();
    public long GetEventTypeId();
    protected void Init();
    public void PreventDefault();
    public void StopImmediatePropagation();
    public void StopPropagation();

}

}
