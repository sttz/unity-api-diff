using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Tilemaps
{

public sealed class TilemapCollider2D : Collider2D
{
    public float extrusionFactor { get; set; }
    public bool hasTilemapChanges { get; }
    public uint maximumTileChangeCount { get; set; }

    public TilemapCollider2D();

    public void ProcessTilemapChanges();

}

}
