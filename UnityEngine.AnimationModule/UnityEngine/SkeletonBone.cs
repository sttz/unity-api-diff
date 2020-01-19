using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct SkeletonBone
{
    public string name;
    public Vector3 position;
    public Quaternion rotation;
    public Vector3 scale;

    public int transformModified { get; set; }

}

}
