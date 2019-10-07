using System;
using UnityEngine;

namespace UnityEngine
{

public struct RaycastCommand
{
    static public Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<RaycastCommand> commands, Unity.Collections.NativeArray<RaycastHit> results, int minCommandsPerJob, Unity.Jobs.JobHandle dependsOn = null);

    public Vector3 direction { get; set; }
    public float distance { get; set; }
    public Vector3 from { get; set; }
    public int layerMask { get; set; }
    public int maxHits { get; set; }

    public RaycastCommand(Vector3 from, Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5, int maxHits = 1);

}

}
