using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Tilemaps
{

public sealed class Tilemap : GridLayout
{
    public float animationFrameRate { get; set; }
    public BoundsInt cellBounds { get; }
    public Color color { get; set; }
    public Vector3Int editorPreviewOrigin { get; }
    public Vector3Int editorPreviewSize { get; }
    public Grid layoutGrid { get; }
    public Bounds localBounds { get; }
    public Orientation orientation { get; set; }
    public Matrix4x4 orientationMatrix { get; set; }
    public Vector3Int origin { get; set; }
    public Vector3Int size { get; set; }
    public Vector3 tileAnchor { get; set; }

    public Tilemap();

    public void AddTileFlags(Vector3Int position, Tilemaps.TileFlags flags);
    public void BoxFill(Vector3Int position, Tilemaps.TileBase tile, int startX, int startY, int endX, int endY);
    public void ClearAllEditorPreviewTiles();
    public void ClearAllTiles();
    public void CompressBounds();
    public bool ContainsTile(Tilemaps.TileBase tileAsset);
    public void EditorPreviewBoxFill(Vector3Int position, Object tile, int startX, int startY, int endX, int endY);
    public void EditorPreviewFloodFill(Vector3Int position, Tilemaps.TileBase tile);
    public void FloodFill(Vector3Int position, Tilemaps.TileBase tile);
    public Vector3 GetCellCenterLocal(Vector3Int position);
    public Vector3 GetCellCenterWorld(Vector3Int position);
    public ColliderType GetColliderType(Vector3Int position);
    public Color GetColor(Vector3Int position);
    public Color GetEditorPreviewColor(Vector3Int position);
    public Sprite GetEditorPreviewSprite(Vector3Int position);
    public Tilemaps.TileBase GetEditorPreviewTile(Vector3Int position);
    public T GetEditorPreviewTile<T>(Vector3Int position);
    public Tilemaps.TileFlags GetEditorPreviewTileFlags(Vector3Int position);
    public Matrix4x4 GetEditorPreviewTransformMatrix(Vector3Int position);
    public GameObject GetInstantiatedObject(Vector3Int position);
    public Sprite GetSprite(Vector3Int position);
    public Tilemaps.TileBase GetTile(Vector3Int position);
    public T GetTile<T>(Vector3Int position);
    public Tilemaps.TileFlags GetTileFlags(Vector3Int position);
    public Tilemaps.TileBase[] GetTilesBlock(BoundsInt bounds);
    public Matrix4x4 GetTransformMatrix(Vector3Int position);
    public int GetUsedTilesCount();
    public int GetUsedTilesNonAlloc(Tilemaps.TileBase[] usedTiles);
    public bool HasEditorPreviewTile(Vector3Int position);
    public bool HasTile(Vector3Int position);
    public void RefreshAllTiles();
    public void RefreshTile(Vector3Int position);
    public void RemoveTileFlags(Vector3Int position, Tilemaps.TileFlags flags);
    public void ResizeBounds();
    public void SetColliderType(Vector3Int position, ColliderType colliderType);
    public void SetColor(Vector3Int position, Color color);
    public void SetEditorPreviewColor(Vector3Int position, Color color);
    public void SetEditorPreviewTile(Vector3Int position, Tilemaps.TileBase tile);
    public void SetEditorPreviewTransformMatrix(Vector3Int position, Matrix4x4 transform);
    public void SetTile(Vector3Int position, Tilemaps.TileBase tile);
    public void SetTileFlags(Vector3Int position, Tilemaps.TileFlags flags);
    public void SetTiles(Vector3Int[] positionArray, Tilemaps.TileBase[] tileArray);
    public void SetTilesBlock(BoundsInt position, Tilemaps.TileBase[] tileArray);
    public void SetTransformMatrix(Vector3Int position, Matrix4x4 transform);
    public void SwapTile(Tilemaps.TileBase changeTile, Tilemaps.TileBase newTile);

    public enum Orientation
    {
        XY = 0,
        XZ = 1,
        YX = 2,
        YZ = 3,
        ZX = 4,
        ZY = 5,
        Custom = 6,
    }

}

}
