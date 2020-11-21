using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct SpherecastCommand
{
    static public Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<SpherecastCommand> commands, Unity.Collections.NativeArray<RaycastHit> results, int minCommandsPerJob, Unity.Jobs.JobHandle dependsOn = null);

    public Vector3 direction { get; set; }
    public float distance { get; set; }
    public int layerMask { get; set; }
    public Vector3 origin { get; set; }
    public float radius { get; set; }

    public SpherecastCommand(Vector3 origin, float radius, Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5);

}

}
