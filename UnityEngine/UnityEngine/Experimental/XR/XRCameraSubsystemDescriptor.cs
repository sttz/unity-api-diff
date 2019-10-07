using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRCameraSubsystemDescriptor : IntegratedSubsystemDescriptor<Experimental.XR.XRCameraSubsystem>
{
    public bool ProvidesAverageBrightness { get; }
    public bool ProvidesAverageColorTemperature { get; }
    public bool ProvidesDisplayMatrix { get; }
    public bool ProvidesProjectionMatrix { get; }
    public bool ProvidesTimestamp { get; }

    public XRCameraSubsystemDescriptor();

}

}
