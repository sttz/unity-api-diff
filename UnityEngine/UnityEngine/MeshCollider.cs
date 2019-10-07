using System;
using UnityEngine;

namespace UnityEngine
{

public class MeshCollider : Collider
{
    public bool convex { get; set; }
    public MeshColliderCookingOptions cookingOptions { get; set; }
    public bool inflateMesh { get; set; }
    public Mesh sharedMesh { get; set; }
    public float skinWidth { get; set; }
    public bool smoothSphereCollisions { get; set; }

    public MeshCollider();

}

}
