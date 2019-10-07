using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface ITransform
{
    public Matrix4x4 matrix { get; }
    public Vector3 position { get; set; }
    public Quaternion rotation { get; set; }
    public Vector3 scale { get; set; }

}

}
