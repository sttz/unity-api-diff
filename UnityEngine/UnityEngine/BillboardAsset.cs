using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class BillboardAsset : Object
{
    public float bottom { get; set; }
    public float height { get; set; }
    public int imageCount { get; }
    public int indexCount { get; }
    public Material material { get; set; }
    public int vertexCount { get; }
    public float width { get; set; }

    public BillboardAsset();

    public void GetImageTexCoords(System.Collections.Generic.List<Vector4> imageTexCoords);
    public Vector4[] GetImageTexCoords();
    public void GetIndices(System.Collections.Generic.List<ushort> indices);
    public ushort[] GetIndices();
    public void GetVertices(System.Collections.Generic.List<Vector2> vertices);
    public Vector2[] GetVertices();
    public void SetImageTexCoords(System.Collections.Generic.List<Vector4> imageTexCoords);
    public void SetImageTexCoords(Vector4[] imageTexCoords);
    public void SetIndices(System.Collections.Generic.List<ushort> indices);
    public void SetIndices(ushort[] indices);
    public void SetVertices(System.Collections.Generic.List<Vector2> vertices);
    public void SetVertices(Vector2[] vertices);

}

}
