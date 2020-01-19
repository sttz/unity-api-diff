using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class Clickable : UIElements.MouseManipulator
{
    protected bool active { get; set; }
    public Vector2 lastMousePosition { get; private set; }

    public event Action clicked;
    public event Action<UIElements.EventBase> clickedWithEventInfo;

    public Clickable(Action handler);
    public Clickable(Action<UIElements.EventBase> handler);
    public Clickable(Action handler, long delay, long interval);

    protected void OnMouseDown(UIElements.MouseDownEvent evt);
    protected void OnMouseMove(UIElements.MouseMoveEvent evt);
    protected void OnMouseUp(UIElements.MouseUpEvent evt);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
