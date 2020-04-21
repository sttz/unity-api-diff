using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Tilemaps
{

public struct TileData
{
    public ColliderType colliderType { get; set; }
    public Color color { get; set; }
    public Tilemaps.TileFlags flags { get; set; }
    public GameObject gameObject { get; set; }
    public Sprite sprite { get; set; }
    public Matrix4x4 transform { get; set; }

}

}
