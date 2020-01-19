using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Tilemaps
{

public abstract class TileBase : ScriptableObject
{
    protected TileBase();

    public bool GetTileAnimationData(Vector3Int position, Tilemaps.ITilemap tilemap, Tilemaps.TileAnimationData tileAnimationData);
    public void GetTileData(Vector3Int position, Tilemaps.ITilemap tilemap, Tilemaps.TileData tileData);
    public void RefreshTile(Vector3Int position, Tilemaps.ITilemap tilemap);
    public bool StartUp(Vector3Int position, Tilemaps.ITilemap tilemap, GameObject go);

}

}
