using System;
using UnityEngine;

namespace UnityEngine.Experimental.U2D
{

public struct SpriteBone
{
    public float length { get; set; }
    public string name { get; set; }
    public int parentId { get; set; }
    public Vector3 position { get; set; }
    public Quaternion rotation { get; set; }

}

}
