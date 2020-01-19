using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Touch
{
    public float altitudeAngle { get; set; }
    public float azimuthAngle { get; set; }
    public Vector2 deltaPosition { get; set; }
    public float deltaTime { get; set; }
    public int fingerId { get; set; }
    public float maximumPossiblePressure { get; set; }
    public TouchPhase phase { get; set; }
    public Vector2 position { get; set; }
    public float pressure { get; set; }
    public float radius { get; set; }
    public float radiusVariance { get; set; }
    public Vector2 rawPosition { get; set; }
    public int tapCount { get; set; }
    public TouchType type { get; set; }

}

}
