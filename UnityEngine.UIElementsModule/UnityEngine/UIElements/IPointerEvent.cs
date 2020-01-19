using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IPointerEvent
{
    public bool actionKey { get; }
    public float altitudeAngle { get; }
    public bool altKey { get; }
    public float azimuthAngle { get; }
    public int button { get; }
    public int clickCount { get; }
    public bool commandKey { get; }
    public bool ctrlKey { get; }
    public Vector3 deltaPosition { get; }
    public float deltaTime { get; }
    public bool isPrimary { get; }
    public Vector3 localPosition { get; }
    public EventModifiers modifiers { get; }
    public int pointerId { get; }
    public string pointerType { get; }
    public Vector3 position { get; }
    public int pressedButtons { get; }
    public float pressure { get; }
    public Vector2 radius { get; }
    public Vector2 radiusVariance { get; }
    public bool shiftKey { get; }
    public float tangentialPressure { get; }
    public float twist { get; }

}

}
