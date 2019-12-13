using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class CanvasRenderer : Component
{
    static public event OnRequestRebuild onRequestRebuild;

    static public void AddUIVertexStream(System.Collections.Generic.List<UIVertex> verts, System.Collections.Generic.List<Vector3> positions, System.Collections.Generic.List<Color32> colors, System.Collections.Generic.List<Vector2> uv0S, System.Collections.Generic.List<Vector2> uv1S, System.Collections.Generic.List<Vector3> normals, System.Collections.Generic.List<Vector4> tangents);
    static public void AddUIVertexStream(System.Collections.Generic.List<UIVertex> verts, System.Collections.Generic.List<Vector3> positions, System.Collections.Generic.List<Color32> colors, System.Collections.Generic.List<Vector2> uv0S, System.Collections.Generic.List<Vector2> uv1S, System.Collections.Generic.List<Vector2> uv2S, System.Collections.Generic.List<Vector2> uv3S, System.Collections.Generic.List<Vector3> normals, System.Collections.Generic.List<Vector4> tangents);
    static public void CreateUIVertexStream(System.Collections.Generic.List<UIVertex> verts, System.Collections.Generic.List<Vector3> positions, System.Collections.Generic.List<Color32> colors, System.Collections.Generic.List<Vector2> uv0S, System.Collections.Generic.List<Vector2> uv1S, System.Collections.Generic.List<Vector3> normals, System.Collections.Generic.List<Vector4> tangents, System.Collections.Generic.List<int> indices);
    static public void CreateUIVertexStream(System.Collections.Generic.List<UIVertex> verts, System.Collections.Generic.List<Vector3> positions, System.Collections.Generic.List<Color32> colors, System.Collections.Generic.List<Vector2> uv0S, System.Collections.Generic.List<Vector2> uv1S, System.Collections.Generic.List<Vector2> uv2S, System.Collections.Generic.List<Vector2> uv3S, System.Collections.Generic.List<Vector3> normals, System.Collections.Generic.List<Vector4> tangents, System.Collections.Generic.List<int> indices);
    static public void SplitUIVertexStreams(System.Collections.Generic.List<UIVertex> verts, System.Collections.Generic.List<Vector3> positions, System.Collections.Generic.List<Color32> colors, System.Collections.Generic.List<Vector2> uv0S, System.Collections.Generic.List<Vector2> uv1S, System.Collections.Generic.List<Vector3> normals, System.Collections.Generic.List<Vector4> tangents, System.Collections.Generic.List<int> indices);
    static public void SplitUIVertexStreams(System.Collections.Generic.List<UIVertex> verts, System.Collections.Generic.List<Vector3> positions, System.Collections.Generic.List<Color32> colors, System.Collections.Generic.List<Vector2> uv0S, System.Collections.Generic.List<Vector2> uv1S, System.Collections.Generic.List<Vector2> uv2S, System.Collections.Generic.List<Vector2> uv3S, System.Collections.Generic.List<Vector3> normals, System.Collections.Generic.List<Vector4> tangents, System.Collections.Generic.List<int> indices);

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
    public Material GetMaterial(int index);
    public Material GetMaterial();
    public Material GetPopMaterial(int index);
    public void SetAlpha(float alpha);
    public void SetAlphaTexture(Texture texture);
    public void SetColor(Color color);
    public void SetMaterial(Material material, int index);
    public void SetMaterial(Material material, Texture texture);
    public void SetMesh(Mesh mesh);
    public void SetPopMaterial(Material material, int index);
    public void SetTexture(Texture texture);
    public void SetVertices(System.Collections.Generic.List<UIVertex> vertices);
    public void SetVertices(UIVertex[] vertices, int size);

    public delegate void OnRequestRebuild();

}

}
