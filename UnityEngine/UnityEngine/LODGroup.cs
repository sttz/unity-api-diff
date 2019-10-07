using System;
using UnityEngine;

namespace UnityEngine
{

public class LODGroup : Component
{
    static public float crossFadeAnimationDuration { get; set; }

    public bool animateCrossFading { get; set; }
    public bool enabled { get; set; }
    public LODFadeMode fadeMode { get; set; }
    public Vector3 localReferencePoint { get; set; }
    public int lodCount { get; }
    public float size { get; set; }

    public LODGroup();

    public void ForceLOD(int index);
    public LOD[] GetLODs();
    public void RecalculateBounds();
    public void SetLODs(LOD[] lods);
    public void SetLODS(LOD[] lods);

}

}
