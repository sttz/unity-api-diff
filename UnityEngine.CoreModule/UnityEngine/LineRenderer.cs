using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class LineRenderer : Renderer
{
    public LineAlignment alignment { get; set; }
    public Gradient colorGradient { get; set; }
    public Color endColor { get; set; }
    public float endWidth { get; set; }
    public bool generateLightingData { get; set; }
    public bool loop { get; set; }
    public int numCapVertices { get; set; }
    public int numCornerVertices { get; set; }
    public int numPositions { get; set; }
    public int positionCount { get; set; }
    public float shadowBias { get; set; }
    public Color startColor { get; set; }
    public float startWidth { get; set; }
    public LineTextureMode textureMode { get; set; }
    public bool useWorldSpace { get; set; }
    public AnimationCurve widthCurve { get; set; }
    public float widthMultiplier { get; set; }

    public LineRenderer();

    public void BakeMesh(Mesh mesh, bool useTransform = false);
    public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false);
    public Vector3 GetPosition(int index);
    public int GetPositions(out Vector3[] positions);
    public void SetColors(Color start, Color end);
    public void SetPosition(int index, Vector3 position);
    public void SetPositions(Vector3[] positions);
    public void SetVertexCount(int count);
    public void SetWidth(float start, float end);
    public void Simplify(float tolerance);

}

}
