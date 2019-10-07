using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct SphericalHarmonicsL2 : IEquatable<Rendering.SphericalHarmonicsL2>
{
    public float this[int rgb, int coefficient] { get; set; }

    public void AddAmbientLight(Color color);
    public void AddDirectionalLight(Vector3 direction, Color color, float intensity);
    public void Clear();
    public bool Equals(object other);
    public bool Equals(Rendering.SphericalHarmonicsL2 other);
    public void Evaluate(Vector3[] directions, Color[] results);
    public int GetHashCode();

}

}
