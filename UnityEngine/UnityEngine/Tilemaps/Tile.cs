using System;
using UnityEngine;

namespace UnityEngine.Tilemaps
{

public class Tile : Tilemaps.TileBase
{
    public ColliderType colliderType { get; set; }
    public Color color { get; set; }
    public Tilemaps.TileFlags flags { get; set; }
    public GameObject gameObject { get; set; }
    public Sprite sprite { get; set; }
    public Matrix4x4 transform { get; set; }

    public Tile();

    public void GetTileData(Vector3Int position, Tilemaps.ITilemap tilemap, Tilemaps.TileData tileData);

    public enum ColliderType
    {
        None = 0,
        Sprite = 1,
        Grid = 2,
    }

}

}
