using System;
using UnityEngine;

namespace UnityEditor.Sprites
{

public sealed class SpriteUtility
{
    static public ushort[] GetSpriteIndices(Sprite sprite, bool getAtlasData);
    static public Vector2[] GetSpriteMesh(Sprite sprite, bool getAtlasData);
    static public Texture2D GetSpriteTexture(Sprite sprite, bool getAtlasData);
    static public Vector2[] GetSpriteUVs(Sprite sprite, bool getAtlasData);

    public SpriteUtility();

}

}
