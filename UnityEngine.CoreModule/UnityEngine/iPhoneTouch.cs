using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct iPhoneTouch
{
    public Vector2 deltaPosition { get; }
    public float deltaTime { get; }
    public int fingerId { get; }
    public iPhoneTouchPhase phase { get; }
    public Vector2 position { get; }
    public Vector2 positionDelta { get; }
    public int tapCount { get; }
    public float timeDelta { get; }

}

}
