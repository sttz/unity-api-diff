using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRSessionSubsystem : Experimental.IntegratedSubsystem<Experimental.XR.XRSessionSubsystemDescriptor>
{
    public int LastUpdatedFrame { get; }
    public Experimental.XR.TrackingState TrackingState { get; }

    public event Action<Experimental.XR.SessionTrackingStateChangedEventArgs> TrackingStateChanged;

    public XRSessionSubsystem();

}

}
