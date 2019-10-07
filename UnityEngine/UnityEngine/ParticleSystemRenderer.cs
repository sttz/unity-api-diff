using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class ParticleSystemRenderer : Renderer
{
    public int activeVertexStreamsCount { get; }
    public ParticleSystemRenderSpace alignment { get; set; }
    public bool allowRoll { get; set; }
    public float cameraVelocityScale { get; set; }
    public bool enableGPUInstancing { get; set; }
    public Vector3 flip { get; set; }
    public bool freeformStretching { get; set; }
    public float lengthScale { get; set; }
    public SpriteMaskInteraction maskInteraction { get; set; }
    public float maxParticleSize { get; set; }
    public Mesh mesh { get; set; }
    public int meshCount { get; }
    public float minParticleSize { get; set; }
    public float normalDirection { get; set; }
    public Vector3 pivot { get; set; }
    public ParticleSystemRenderMode renderMode { get; set; }
    public bool rotateWithStretchDirection { get; set; }
    public float shadowBias { get; set; }
    public float sortingFudge { get; set; }
    public ParticleSystemSortMode sortMode { get; set; }
    public Material trailMaterial { get; set; }
    public float velocityScale { get; set; }

    public ParticleSystemRenderer();

    public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams);
    public void BakeMesh(Mesh mesh, bool useTransform = false);
    public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false);
    public void BakeTrailsMesh(Mesh mesh, bool useTransform = false);
    public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = false);
    public void DisableVertexStreams(ParticleSystemVertexStreams streams);
    public void EnableVertexStreams(ParticleSystemVertexStreams streams);
    public void GetActiveVertexStreams(System.Collections.Generic.List<ParticleSystemVertexStream> streams);
    public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams);
    public int GetMeshes(out Mesh[] meshes);
    public void SetActiveVertexStreams(System.Collections.Generic.List<ParticleSystemVertexStream> streams);
    public void SetMeshes(Mesh[] meshes, int size);
    public void SetMeshes(Mesh[] meshes);

}

}
