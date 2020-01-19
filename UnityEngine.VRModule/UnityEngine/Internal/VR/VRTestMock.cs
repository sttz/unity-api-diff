using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Internal.VR
{

public static class VRTestMock
{
    static public void AddController(string controllerName);
    static public void AddTrackedDevice(XR.XRNode nodeType);
    static public void Reset();
    static public void UpdateCenterEye(Vector3 position, Quaternion rotation);
    static public void UpdateControllerAxis(string controllerName, int axis, float value);
    static public void UpdateControllerButton(string controllerName, int button, bool pressed);
    static public void UpdateHead(Vector3 position, Quaternion rotation);
    static public void UpdateLeftEye(Vector3 position, Quaternion rotation);
    static public void UpdateLeftHand(Vector3 position, Quaternion rotation);
    static public void UpdateRightEye(Vector3 position, Quaternion rotation);
    static public void UpdateRightHand(Vector3 position, Quaternion rotation);
    static public void UpdateTrackedDevice(XR.XRNode nodeType, Vector3 position, Quaternion rotation);

}

}
