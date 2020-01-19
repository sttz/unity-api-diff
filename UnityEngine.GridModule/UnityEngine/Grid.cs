using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Grid : GridLayout
{
    static public Vector3 InverseSwizzle(CellSwizzle swizzle, Vector3 position);
    static public Vector3 Swizzle(CellSwizzle swizzle, Vector3 position);

    public Vector3 cellGap { get; set; }
    public CellLayout cellLayout { get; set; }
    public Vector3 cellSize { get; set; }
    public CellSwizzle cellSwizzle { get; set; }

    public Grid();

    public Vector3 GetCellCenterLocal(Vector3Int position);
    public Vector3 GetCellCenterWorld(Vector3Int position);

}

}
