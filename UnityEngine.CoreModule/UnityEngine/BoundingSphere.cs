using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct BoundingSphere
{
    public Vector3 position;
    public float radius;

    public BoundingSphere(Vector4 packedSphere);
    public BoundingSphere(Vector3 pos, float rad);

}

}
