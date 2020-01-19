using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Jobs
{

public struct TransformAccess
{
    public Vector3 localPosition { get; set; }
    public Quaternion localRotation { get; set; }
    public Vector3 localScale { get; set; }
    public Vector3 position { get; set; }
    public Quaternion rotation { get; set; }

}

}
