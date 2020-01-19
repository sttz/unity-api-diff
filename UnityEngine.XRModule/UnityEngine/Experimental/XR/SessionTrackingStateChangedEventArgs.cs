using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct SessionTrackingStateChangedEventArgs
{
    public Experimental.XR.TrackingState NewState { get; set; }
    public Experimental.XR.XRSessionSubsystem SessionSubsystem { get; }

}

}
