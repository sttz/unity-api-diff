using System;
using UnityEngine;

namespace UnityEngine
{

public class Compass
{
    public bool enabled { get; set; }
    public float headingAccuracy { get; }
    public float magneticHeading { get; }
    public Vector3 rawVector { get; }
    public double timestamp { get; }
    public float trueHeading { get; }

    public Compass();

}

}
