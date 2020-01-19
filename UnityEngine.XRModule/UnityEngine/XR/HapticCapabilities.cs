using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public struct HapticCapabilities : IEquatable<XR.HapticCapabilities>
{
    public uint bufferFrequencyHz { get; internal set; }
    public uint bufferMaxSize { get; internal set; }
    public uint bufferOptimalSize { get; internal set; }
    public uint numChannels { get; internal set; }
    public bool supportsBuffer { get; internal set; }
    public bool supportsImpulse { get; internal set; }

    public bool Equals(object obj);
    public bool Equals(XR.HapticCapabilities other);
    public int GetHashCode();

}

}
