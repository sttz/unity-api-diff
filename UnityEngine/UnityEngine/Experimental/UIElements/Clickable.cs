using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class Clickable : Experimental.UIElements.MouseManipulator
{
    protected bool m_Active;

    public Vector2 lastMousePosition { get; private set; }

    public event Action clicked;
    public event Action<Experimental.UIElements.EventBase> clickedWithEventInfo;

    public Clickable(Action handler, long delay, long interval);
    public Clickable(Action<Experimental.UIElements.EventBase> handler);
    public Clickable(Action handler);

    protected void OnMouseDown(Experimental.UIElements.MouseDownEvent evt);
    protected void OnMouseMove(Experimental.UIElements.MouseMoveEvent evt);
    protected void OnMouseUp(Experimental.UIElements.MouseUpEvent evt);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
