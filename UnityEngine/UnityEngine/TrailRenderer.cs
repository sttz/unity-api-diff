using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class TrailRenderer : Renderer
{
    public LineAlignment alignment { get; set; }
    public bool autodestruct { get; set; }
    public Gradient colorGradient { get; set; }
    public bool emitting { get; set; }
    public Color endColor { get; set; }
    public float endWidth { get; set; }
    public bool generateLightingData { get; set; }
    public float minVertexDistance { get; set; }
    public int numCapVertices { get; set; }
    public int numCornerVertices { get; set; }
    public int numPositions { get; }
    public int positionCount { get; }
    public float shadowBias { get; set; }
    public Color startColor { get; set; }
    public float startWidth { get; set; }
    public LineTextureMode textureMode { get; set; }
    public float time { get; set; }
    public AnimationCurve widthCurve { get; set; }
    public float widthMultiplier { get; set; }

    public TrailRenderer();

    public void AddPosition(Vector3 position);
    public void AddPositions(Vector3[] positions);
    public void BakeMesh(Mesh mesh, bool useTransform = false);
    public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false);
    public void Clear();
    public Vector3 GetPosition(int index);
    public int GetPositions(out Vector3[] positions);
    public void SetPosition(int index, Vector3 position);
    public void SetPositions(Vector3[] positions);

}

}
