using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.AI
{

public struct NavMeshHit
{
    public float distance { get; set; }
    public bool hit { get; set; }
    public int mask { get; set; }
    public Vector3 normal { get; set; }
    public Vector3 position { get; set; }

}

}
