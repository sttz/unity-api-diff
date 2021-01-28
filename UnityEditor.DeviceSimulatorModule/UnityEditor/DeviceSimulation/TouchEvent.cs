using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.DeviceSimulation
{

public struct TouchEvent
{
    public UnityEditor.DeviceSimulation.TouchPhase phase { get; }
    public Vector2 position { get; }
    public int touchId { get; }

}

}
