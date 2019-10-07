using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRDisplaySubsystem : IntegratedSubsystem<Experimental.XR.XRDisplaySubsystemDescriptor>
{
    static public event Action<bool> displayFocusChanged;

    public bool contentProtectionEnabled { get; set; }
    public bool displayOpaque { get; }
    public ReprojectionMode reprojectionMode { get; set; }
    public bool singlePassRenderingDisabled { get; set; }

    public XRDisplaySubsystem();

    public void SetFocusPlane(Vector3 point, Vector3 normal, Vector3 velocity);

    public enum ReprojectionMode
    {
        Unspecified = 0,
        PositionAndOrientation = 1,
        OrientationOnly = 2,
        None = 3,
    }

}

}
