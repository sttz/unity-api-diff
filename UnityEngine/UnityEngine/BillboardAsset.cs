using System;
using System.Collections;
using System.Collections.Generic;
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

    public Vector4[] GetImageTexCoords();
    public void GetImageTexCoords(List<Vector4> imageTexCoords);
    public ushort[] GetIndices();
    public void GetIndices(List<ushort> indices);
    public Vector2[] GetVertices();
    public void GetVertices(List<Vector2> vertices);
    public void SetImageTexCoords(List<Vector4> imageTexCoords);
    public void SetImageTexCoords(Vector4[] imageTexCoords);
    public void SetIndices(List<ushort> indices);
    public void SetIndices(ushort[] indices);
    public void SetVertices(List<Vector2> vertices);
    public void SetVertices(Vector2[] vertices);

}

}
