using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct RaycastHit
{
    public ArticulationBody articulationBody { get; }
    public Vector3 barycentricCoordinate { get; set; }
    public Collider collider { get; }
    public float distance { get; set; }
    public Vector2 lightmapCoord { get; }
    public Vector3 normal { get; set; }
    public Vector3 point { get; set; }
    public Rigidbody rigidbody { get; }
    public Vector2 textureCoord { get; }
    public Vector2 textureCoord1 { get; }
    public Vector2 textureCoord2 { get; }
    public Transform transform { get; }
    public int triangleIndex { get; }

}

}
