using System;
using UnityEngine;

namespace UnityEngine
{

public struct CapsulecastCommand
{
    static public Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<CapsulecastCommand> commands, Unity.Collections.NativeArray<RaycastHit> results, int minCommandsPerJob, Unity.Jobs.JobHandle dependsOn = null);

    public Vector3 direction { get; set; }
    public float distance { get; set; }
    public int layerMask { get; set; }
    public Vector3 point1 { get; set; }
    public Vector3 point2 { get; set; }
    public float radius { get; set; }

    public CapsulecastCommand(Vector3 p1, Vector3 p2, float radius, Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5);

}

}
