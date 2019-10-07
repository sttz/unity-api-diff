using System;
using UnityEngine;

namespace UnityEngine
{

public struct BoundingSphere
{
    public Vector3 position;
    public float radius;

    public BoundingSphere(Vector3 pos, float rad);
    public BoundingSphere(Vector4 packedSphere);

}

}
