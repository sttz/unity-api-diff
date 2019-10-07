using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class DetailPrototype
{
    public float bendFactor { get; set; }
    public Color dryColor { get; set; }
    public Color healthyColor { get; set; }
    public float maxHeight { get; set; }
    public float maxWidth { get; set; }
    public float minHeight { get; set; }
    public float minWidth { get; set; }
    public float noiseSpread { get; set; }
    public GameObject prototype { get; set; }
    public Texture2D prototypeTexture { get; set; }
    public DetailRenderMode renderMode { get; set; }
    public bool usePrototypeMesh { get; set; }

    public DetailPrototype();
    public DetailPrototype(DetailPrototype other);

    public bool Equals(object obj);
    public int GetHashCode();

}

}
