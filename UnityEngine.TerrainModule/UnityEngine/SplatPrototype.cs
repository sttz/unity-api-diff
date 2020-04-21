using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class SplatPrototype
{
    public float metallic { get; set; }
    public Texture2D normalMap { get; set; }
    public float smoothness { get; set; }
    public Color specular { get; set; }
    public Texture2D texture { get; set; }
    public Vector2 tileOffset { get; set; }
    public Vector2 tileSize { get; set; }

    public SplatPrototype();

}

}
