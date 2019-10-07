using System;
using UnityEngine;

namespace UnityEngine.Experimental.TerrainAPI
{

public struct BrushTransform
{
    static public Experimental.TerrainAPI.BrushTransform FromRect(Rect brushRect);

    public Vector2 brushOrigin { get; }
    public Vector2 brushU { get; }
    public Vector2 brushV { get; }
    public Vector2 targetOrigin { get; }
    public Vector2 targetX { get; }
    public Vector2 targetY { get; }

    public BrushTransform(Vector2 brushOrigin, Vector2 brushU, Vector2 brushV);

    public Vector2 FromBrushUV(Vector2 brushUV);
    public Rect GetBrushXYBounds();
    public Vector2 ToBrushUV(Vector2 targetXY);

}

}
