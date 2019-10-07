using System;
using UnityEngine;

namespace UnityEngine.Sprites
{

public sealed class DataUtility
{
    static public Vector4 GetInnerUV(Sprite sprite);
    static public Vector2 GetMinSize(Sprite sprite);
    static public Vector4 GetOuterUV(Sprite sprite);
    static public Vector4 GetPadding(Sprite sprite);

    public DataUtility();

}

}
