using System;
using UnityEngine;

namespace UnityEngine.Jobs
{

public struct TransformAccess
{
    public Vector3 localPosition { get; set; }
    public Quaternion localRotation { get; set; }
    public Vector3 localScale { get; set; }
    public Matrix4x4 localToWorldMatrix { get; }
    public Vector3 position { get; set; }
    public Quaternion rotation { get; set; }
    public Matrix4x4 worldToLocalMatrix { get; }

}

}
