using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct BoxcastCommand
{
    static public Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<BoxcastCommand> commands, Unity.Collections.NativeArray<RaycastHit> results, int minCommandsPerJob, Unity.Jobs.JobHandle dependsOn = null);

    public Vector3 center { get; set; }
    public Vector3 direction { get; set; }
    public float distance { get; set; }
    public Vector3 halfExtents { get; set; }
    public int layerMask { get; set; }
    public Quaternion orientation { get; set; }

    public BoxcastCommand(Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5);

}

}
