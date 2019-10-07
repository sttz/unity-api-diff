using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class PointerEventBase<T> : UIElements.EventBase<T>, UIElements.IPointerEvent, UIElements.IPointerEventInternal
{
    static public T GetPooled(Event systemEvent);
    static public T GetPooled(Touch touch, EventModifiers modifiers = 0);
    static public T GetPooled(UIElements.IPointerEvent triggerEvent);

    public bool actionKey { get; }
    public float altitudeAngle { get; protected set; }
    public bool altKey { get; }
    public float azimuthAngle { get; protected set; }
    public int button { get; protected set; }
    public int clickCount { get; protected set; }
    public bool commandKey { get; }
    public bool ctrlKey { get; }
    public UIElements.IEventHandler currentTarget { get; internal set; }
    public Vector3 deltaPosition { get; protected set; }
    public float deltaTime { get; protected set; }
    public bool isPrimary { get; protected set; }
    public Vector3 localPosition { get; protected set; }
    public EventModifiers modifiers { get; protected set; }
    public int pointerId { get; protected set; }
    public string pointerType { get; protected set; }
    public Vector3 position { get; protected set; }
    public int pressedButtons { get; protected set; }
    public float pressure { get; protected set; }
    public Vector2 radius { get; protected set; }
    public Vector2 radiusVariance { get; protected set; }
    public bool shiftKey { get; }
    public float tangentialPressure { get; protected set; }
    public float twist { get; protected set; }

    protected PointerEventBase();

    protected void Init();

}

}
