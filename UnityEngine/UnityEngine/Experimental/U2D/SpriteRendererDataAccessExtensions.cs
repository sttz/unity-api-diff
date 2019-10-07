using System;
using UnityEngine;

namespace UnityEngine.Experimental.U2D
{

public static class SpriteRendererDataAccessExtensions
{
    static public void DeactivateDeformableBuffer(SpriteRenderer renderer);
    static public Unity.Collections.NativeArray<Vector3> GetDeformableVertices(SpriteRenderer spriteRenderer);
    static public void UpdateDeformableBuffer(SpriteRenderer spriteRenderer, Unity.Jobs.JobHandle fence);

}

}
