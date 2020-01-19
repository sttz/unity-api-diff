using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct ReferencePointUpdatedEventArgs
{
    public Pose PreviousPose { get; internal set; }
    public Experimental.XR.TrackingState PreviousTrackingState { get; internal set; }
    public Experimental.XR.ReferencePoint ReferencePoint { get; internal set; }

}

}
