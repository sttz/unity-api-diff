using System;
using UnityEngine;

namespace UnityEngine
{

public struct LocationInfo
{
    public float altitude { get; }
    public float horizontalAccuracy { get; }
    public float latitude { get; }
    public float longitude { get; }
    public double timestamp { get; }
    public float verticalAccuracy { get; }

}

}
