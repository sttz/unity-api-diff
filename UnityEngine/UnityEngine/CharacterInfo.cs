using System;
using UnityEngine;

namespace UnityEngine
{

public struct CharacterInfo
{
    public bool flipped;
    public int index;
    public int size;
    public FontStyle style;
    public Rect uv;
    public Rect vert;
    public float width;

    public int advance { get; set; }
    public int bearing { get; set; }
    public int glyphHeight { get; set; }
    public int glyphWidth { get; set; }
    public int maxX { get; set; }
    public int maxY { get; set; }
    public int minX { get; set; }
    public int minY { get; set; }
    public Vector2 uvBottomLeft { get; set; }
    public Vector2 uvBottomRight { get; set; }
    public Vector2 uvTopLeft { get; set; }
    public Vector2 uvTopRight { get; set; }

}

}
