using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct ScriptableCullingParameters : IEquatable<Rendering.ScriptableCullingParameters>
{
    static public int layerCount;
    static public int maximumCullingPlaneCount;

    static public int cullingJobsLowerLimit { get; }
    static public int cullingJobsUpperLimit { get; }

    public float accurateOcclusionThreshold { get; set; }
    public Rendering.CameraProperties cameraProperties { get; set; }
    public uint cullingMask { get; set; }
    public Matrix4x4 cullingMatrix { get; set; }
    public Rendering.CullingOptions cullingOptions { get; set; }
    public int cullingPlaneCount { get; set; }
    public bool isOrthographic { get; set; }
    public Rendering.LODParameters lodParameters { get; set; }
    public int maximumPortalCullingJobs { get; set; }
    public Vector3 origin { get; set; }
    public Rendering.ReflectionProbeSortingCriteria reflectionProbeSortingCriteria { get; set; }
    public float shadowDistance { get; set; }
    public Matrix4x4 stereoProjectionMatrix { get; set; }
    public float stereoSeparationDistance { get; set; }
    public Matrix4x4 stereoViewMatrix { get; set; }

    public bool Equals(object obj);
    public bool Equals(Rendering.ScriptableCullingParameters other);
    public Plane GetCullingPlane(int index);
    public int GetHashCode();
    public float GetLayerCullingDistance(int layerIndex);
    public void SetCullingPlane(int index, Plane plane);
    public void SetLayerCullingDistance(int layerIndex, float distance);

    public struct <m_CullingPlanes>e__FixedBuffer
    {
        public byte FixedElementField;

    }

    public struct <m_LayerFarCullDistances>e__FixedBuffer
    {
        public float FixedElementField;

    }

}

}
