using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct ScriptableCullingParameters
{
    public Matrix4x4 cullStereoProj;
    public float cullStereoSeparation;
    public Matrix4x4 cullStereoView;

    public float accurateOcclusionThreshold { get; set; }
    public Experimental.Rendering.CameraProperties cameraProperties { get; set; }
    public Experimental.Rendering.CullFlag cullingFlags { get; set; }
    public int cullingMask { get; set; }
    public Matrix4x4 cullingMatrix { get; set; }
    public int cullingPlaneCount { get; set; }
    public bool isOrthographic { get; set; }
    public int layerCull { get; set; }
    public Experimental.Rendering.LODParameters lodParameters { get; set; }
    public Vector3 position { get; set; }
    public Experimental.Rendering.ReflectionProbeSortOptions reflectionProbeSortOptions { get; set; }
    public long sceneMask { get; set; }
    public float shadowDistance { get; set; }

    public Plane GetCullingPlane(int index);
    public float GetLayerCullDistance(int layerIndex);
    public void SetCullingPlane(int index, Plane plane);
    public void SetLayerCullDistance(int layerIndex, float distance);

    public struct <m_CullingPlanes>__FixedBuffer4
    {
        public float FixedElementField;

    }

    public struct <m_LayerFarCullDistances>__FixedBuffer5
    {
        public float FixedElementField;

    }

}

}
