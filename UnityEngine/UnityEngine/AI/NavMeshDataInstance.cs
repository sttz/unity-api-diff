using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.AI
{

public struct NavMeshDataInstance
{
    public Object owner { get; set; }
    public bool valid { get; }

    public void Remove();

}

}
