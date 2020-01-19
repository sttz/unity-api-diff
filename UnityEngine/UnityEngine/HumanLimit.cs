using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct HumanLimit
{
    public float axisLength { get; set; }
    public Vector3 center { get; set; }
    public Vector3 max { get; set; }
    public Vector3 min { get; set; }
    public bool useDefaultValues { get; set; }

}

}
