using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA
{

public class HolographicSettings
{
    static public bool IsContentProtectionEnabled { get; set; }
    static public bool IsDisplayOpaque { get; }
    static public bool IsLatentFramePresentation { get; }
    static public HolographicReprojectionMode ReprojectionMode { get; set; }

    static public void ActivateLatentFramePresentation(bool activated);
    static public void SetFocusPointForFrame(Vector3 position);
    static public void SetFocusPointForFrame(Vector3 position, Vector3 normal);
    static public void SetFocusPointForFrame(Vector3 position, Vector3 normal, Vector3 velocity);

    public HolographicSettings();

    public enum HolographicReprojectionMode
    {
        PositionAndOrientation = 0,
        OrientationOnly = 1,
        Disabled = 2,
    }

}

}
