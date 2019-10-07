using System;
using UnityEngine;

namespace UnityEngine.Tilemaps
{

public class ITilemap
{
    public BoundsInt cellBounds { get; }
    public Bounds localBounds { get; }
    public Vector3Int origin { get; }
    public Vector3Int size { get; }

    public Color GetColor(Vector3Int position);
    public T GetComponent();
    public Sprite GetSprite(Vector3Int position);
    public Tilemaps.TileBase GetTile(Vector3Int position);
    public T GetTile(Vector3Int position);
    public Tilemaps.TileFlags GetTileFlags(Vector3Int position);
    public Matrix4x4 GetTransformMatrix(Vector3Int position);
    public void RefreshTile(Vector3Int position);

}

}
