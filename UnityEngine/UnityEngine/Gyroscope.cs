using System;
using UnityEngine;

namespace UnityEngine
{

public class Gyroscope
{
    public Quaternion attitude { get; }
    public bool enabled { get; set; }
    public Vector3 gravity { get; }
    public Vector3 rotationRate { get; }
    public Vector3 rotationRateUnbiased { get; }
    public float updateInterval { get; set; }
    public Vector3 userAcceleration { get; }

}

}
