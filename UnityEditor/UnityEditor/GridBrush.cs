using System;
using UnityEngine;

namespace UnityEditor
{

public class GridBrush : GridBrushBase
{
    public int cellCount { get; }
    public BrushCell[] cells { get; }
    public Vector3Int pivot { get; set; }
    public Vector3Int size { get; set; }

    public GridBrush();

    public void BoxErase(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
    public void BoxFill(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
    public void Erase(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
    public void Flip(FlipAxis flip, CellLayout layout);
    public void FloodFill(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
    public int GetCellIndex(Vector3Int brushPosition);
    public int GetCellIndex(int x, int y, int z);
    public int GetCellIndex(int x, int y, int z, int sizex, int sizey, int sizez);
    public int GetCellIndexWrapAround(int x, int y, int z);
    public int GetHashCode();
    public void Init(Vector3Int size);
    public void Init(Vector3Int size, Vector3Int pivot);
    public void MoveEnd(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
    public void MoveStart(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
    public void Paint(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
    public void Pick(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, Vector3Int pickStart);
    public void Reset();
    public void Rotate(RotationDirection direction, CellLayout layout);
    public void SetColor(Vector3Int position, Color color);
    public void SetMatrix(Vector3Int position, Matrix4x4 matrix);
    public void SetTile(Vector3Int position, Tilemaps.TileBase tile);
    public void UpdateSizeAndPivot(Vector3Int size, Vector3Int pivot);

    public class BrushCell
    {
        public Color color { get; set; }
        public Matrix4x4 matrix { get; set; }
        public Tilemaps.TileBase tile { get; set; }

        public BrushCell();

        public int GetHashCode();

    }

}

}
