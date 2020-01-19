using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRCameraSubsystemDescriptor : Experimental.IntegratedSubsystemDescriptor<Experimental.XR.XRCameraSubsystem>
{
    public bool ProvidesAverageBrightness { get; }
    public bool ProvidesAverageColorTemperature { get; }
    public bool ProvidesDisplayMatrix { get; }
    public bool ProvidesProjectionMatrix { get; }
    public bool ProvidesTimestamp { get; }

    public XRCameraSubsystemDescriptor();

}

}
