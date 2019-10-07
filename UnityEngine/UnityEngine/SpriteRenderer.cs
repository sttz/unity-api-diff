using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class SpriteRenderer : Renderer
{
    public float adaptiveModeThreshold { get; set; }
    public Color color { get; set; }
    public SpriteDrawMode drawMode { get; set; }
    public bool flipX { get; set; }
    public bool flipY { get; set; }
    public SpriteMaskInteraction maskInteraction { get; set; }
    public Vector2 size { get; set; }
    public Sprite sprite { get; set; }
    public SpriteSortPoint spriteSortPoint { get; set; }
    public SpriteTileMode tileMode { get; set; }

    public SpriteRenderer();

}

}
