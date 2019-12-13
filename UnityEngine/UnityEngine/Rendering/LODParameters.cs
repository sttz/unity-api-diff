using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct LODParameters : IEquatable<Rendering.LODParameters>
{
    public int cameraPixelHeight { get; set; }
    public Vector3 cameraPosition { get; set; }
    public float fieldOfView { get; set; }
    public bool isOrthographic { get; set; }
    public float orthoSize { get; set; }

    public bool Equals(Rendering.LODParameters other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}