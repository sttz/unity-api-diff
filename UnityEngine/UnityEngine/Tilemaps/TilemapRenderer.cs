using System;
using UnityEngine;

namespace UnityEngine.Tilemaps
{

public sealed class TilemapRenderer : Renderer
{
    public Vector3 chunkCullingBounds { get; set; }
    public Vector3Int chunkSize { get; set; }
    public DetectChunkCullingBounds detectChunkCullingBounds { get; set; }
    public SpriteMaskInteraction maskInteraction { get; set; }
    public int maxChunkCount { get; set; }
    public int maxFrameAge { get; set; }
    public Mode mode { get; set; }
    public SortOrder sortOrder { get; set; }

    public TilemapRenderer();

    public enum SortOrder
    {
        BottomLeft = 0,
        BottomRight = 1,
        TopLeft = 2,
        TopRight = 3,
    }

    public enum Mode
    {
        Chunk = 0,
        Individual = 1,
    }

    public enum DetectChunkCullingBounds
    {
        Auto = 0,
        Manual = 1,
    }

}

}
