using System;
using UnityEngine;

namespace UnityEngine
{

public class GridLayout : Behaviour
{
    public Vector3 cellGap { get; }
    public CellLayout cellLayout { get; }
    public Vector3 cellSize { get; }
    public CellSwizzle cellSwizzle { get; }

    public GridLayout();

    public Vector3 CellToLocal(Vector3Int cellPosition);
    public Vector3 CellToLocalInterpolated(Vector3 cellPosition);
    public Vector3 CellToWorld(Vector3Int cellPosition);
    public Bounds GetBoundsLocal(Vector3Int cellPosition);
    public Bounds GetBoundsLocal(Vector3 origin, Vector3 size);
    public Vector3 GetLayoutCellCenter();
    public Vector3Int LocalToCell(Vector3 localPosition);
    public Vector3 LocalToCellInterpolated(Vector3 localPosition);
    public Vector3 LocalToWorld(Vector3 localPosition);
    public Vector3Int WorldToCell(Vector3 worldPosition);
    public Vector3 WorldToLocal(Vector3 worldPosition);

    public enum CellLayout
    {
        Rectangle = 0,
        Hexagon = 1,
        Isometric = 2,
        IsometricZAsY = 3,
    }

    public enum CellSwizzle
    {
        XYZ = 0,
        XZY = 1,
        YXZ = 2,
        YZX = 3,
        ZXY = 4,
        ZYX = 5,
    }

}

}
