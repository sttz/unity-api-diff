using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class CanvasRenderer : Component
{
    static public event OnRequestRebuild onRequestRebuild;

    static public void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents);
    static public void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents);
    static public void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices);
    static public void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices);
    static public void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices);
    static public void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices);

    public int absoluteDepth { get; }
    public Vector2 clippingSoftness { get; set; }
    public bool cull { get; set; }
    public bool cullTransparentMesh { get; set; }
    public bool hasMoved { get; }
    public bool hasPopInstruction { get; set; }
    public bool hasRectClipping { get; }
    public bool isMask { get; set; }
    public int materialCount { get; set; }
    public int popMaterialCount { get; set; }
    public int relativeDepth { get; }

    public CanvasRenderer();

    public void Clear();
    public void DisableRectClipping();
    public void EnableRectClipping(Rect rect);
    public float GetAlpha();
    public Color GetColor();
    public float GetInheritedAlpha();
    public Material GetMaterial();
    public Material GetMaterial(int index);
    public Material GetPopMaterial(int index);
    public void SetAlpha(float alpha);
    public void SetAlphaTexture(Texture texture);
    public void SetColor(Color color);
    public void SetMaterial(Material material, int index);
    public void SetMaterial(Material material, Texture texture);
    public void SetMesh(Mesh mesh);
    public void SetPopMaterial(Material material, int index);
    public void SetTexture(Texture texture);
    public void SetVertices(List<UIVertex> vertices);
    public void SetVertices(UIVertex[] vertices, int size);

    public delegate void OnRequestRebuild();

}

}
