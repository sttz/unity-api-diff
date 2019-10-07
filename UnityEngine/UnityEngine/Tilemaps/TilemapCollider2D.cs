using System;
using UnityEngine;

namespace UnityEngine.Tilemaps
{

public sealed class TilemapCollider2D : Collider2D
{
    public float extrusionFactor { get; set; }
    public uint maximumTileChangeCount { get; set; }

    public TilemapCollider2D();

}

}
