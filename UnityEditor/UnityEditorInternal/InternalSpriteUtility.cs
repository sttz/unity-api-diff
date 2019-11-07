using System;
using UnityEngine;

namespace UnityEditorInternal
{

public sealed class InternalSpriteUtility
{
    static public Rect[] GenerateAutomaticSpriteRectangles(Texture2D texture, int minRectSize, int extrudeSize);
    static public Rect[] GenerateGridSpriteRectangles(Texture2D texture, Vector2 offset, Vector2 size, Vector2 padding, bool keepEmptyRects = false);

    public InternalSpriteUtility();

}

}
