using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.AI
{

public struct NavMeshWorld
{
    static public Experimental.AI.NavMeshWorld GetDefaultWorld();

    public void AddDependency(Unity.Jobs.JobHandle job);
    public bool IsValid();

}

}
