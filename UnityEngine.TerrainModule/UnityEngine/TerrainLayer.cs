using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class TerrainLayer : Object
{
    public Vector4 diffuseRemapMax { get; set; }
    public Vector4 diffuseRemapMin { get; set; }
    public Texture2D diffuseTexture { get; set; }
    public Vector4 maskMapRemapMax { get; set; }
    public Vector4 maskMapRemapMin { get; set; }
    public Texture2D maskMapTexture { get; set; }
    public float metallic { get; set; }
    public Texture2D normalMapTexture { get; set; }
    public float normalScale { get; set; }
    public float smoothness { get; set; }
    public Color specular { get; set; }
    public Vector2 tileOffset { get; set; }
    public Vector2 tileSize { get; set; }

    public TerrainLayer();

}

}
