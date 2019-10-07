using System;
using UnityEngine;

namespace UnityEngine
{

public class iPhoneInput
{
    static public Vector3 acceleration { get; }
    static public int accelerationEventCount { get; }
    static public iPhoneAccelerationEvent[] accelerationEvents { get; }
    static public bool multiTouchEnabled { get; set; }
    static public iPhoneOrientation orientation { get; }
    static public int touchCount { get; }
    static public iPhoneTouch[] touches { get; }

    static public iPhoneAccelerationEvent GetAccelerationEvent(int index);
    static public iPhoneTouch GetTouch(int index);

    public iPhoneInput();

}

}
