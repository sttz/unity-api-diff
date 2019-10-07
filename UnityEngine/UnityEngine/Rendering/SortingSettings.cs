using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct SortingSettings : IEquatable<Rendering.SortingSettings>
{
    public Vector3 cameraPosition { get; set; }
    public Rendering.SortingCriteria criteria { get; set; }
    public Vector3 customAxis { get; set; }
    public Rendering.DistanceMetric distanceMetric { get; set; }
    public Matrix4x4 worldToCameraMatrix { get; set; }

    public SortingSettings(Camera camera);

    public bool Equals(Rendering.SortingSettings other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}
