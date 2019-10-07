using System;
using UnityEngine;

namespace UnityEngine
{

public class Input
{
    static public Vector3 acceleration { get; }
    static public int accelerationEventCount { get; }
    static public AccelerationEvent[] accelerationEvents { get; }
    static public bool anyKey { get; }
    static public bool anyKeyDown { get; }
    static public bool backButtonLeavesApp { get; set; }
    static public Compass compass { get; }
    static public bool compensateSensors { get; set; }
    static public Vector2 compositionCursorPos { get; set; }
    static public string compositionString { get; }
    static public DeviceOrientation deviceOrientation { get; }
    static public bool eatKeyPressOnTextFieldFocus { get; set; }
    static public Gyroscope gyro { get; }
    static public IMECompositionMode imeCompositionMode { get; set; }
    static public bool imeIsSelected { get; }
    static public string inputString { get; }
    static public bool isGyroAvailable { get; }
    static public LocationService location { get; }
    static public Vector3 mousePosition { get; }
    static public bool mousePresent { get; }
    static public Vector2 mouseScrollDelta { get; }
    static public bool multiTouchEnabled { get; set; }
    static public bool simulateMouseWithTouches { get; set; }
    static public bool stylusTouchSupported { get; }
    static public int touchCount { get; }
    static public Touch[] touches { get; }
    static public bool touchPressureSupported { get; }
    static public bool touchSupported { get; }

    static public AccelerationEvent GetAccelerationEvent(int index);
    static public float GetAxis(string axisName);
    static public float GetAxisRaw(string axisName);
    static public bool GetButton(string buttonName);
    static public bool GetButtonDown(string buttonName);
    static public bool GetButtonUp(string buttonName);
    static public string[] GetJoystickNames();
    static public bool GetKey(KeyCode key);
    static public bool GetKey(string name);
    static public bool GetKeyDown(KeyCode key);
    static public bool GetKeyDown(string name);
    static public bool GetKeyUp(KeyCode key);
    static public bool GetKeyUp(string name);
    static public bool GetMouseButton(int button);
    static public bool GetMouseButtonDown(int button);
    static public bool GetMouseButtonUp(int button);
    static public Touch GetTouch(int index);
    static public bool IsJoystickPreconfigured(string joystickName);
    static public void ResetInputAxes();

    public Input();

}

}
