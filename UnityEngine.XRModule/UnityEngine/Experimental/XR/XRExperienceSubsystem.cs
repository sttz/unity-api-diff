using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRExperienceSubsystem : IntegratedSubsystem<Experimental.XR.XRExperienceSubsystemDescriptor>
{
    public ExperienceType experienceType { get; }
    public TrackingOrigin trackingOrigin { get; }

    public event Action BoundaryChanged;
    public event Action ExperienceTypeChanged;

    public XRExperienceSubsystem();

    public void GetAllBoundaryPoints(List<Vector3> boundaryPointsOut);

    public enum ExperienceType
    {
        Local = 0,
        Bounded = 1,
        UnBounded = 2,
    }

    public enum TrackingOrigin
    {
        Device = 0,
        Floor = 1,
    }

}

}
