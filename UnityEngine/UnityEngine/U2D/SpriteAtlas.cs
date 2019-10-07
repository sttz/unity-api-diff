using System;
using UnityEngine;

namespace UnityEngine.U2D
{

public class SpriteAtlas : Object
{
    public bool isVariant { get; }
    public int spriteCount { get; }
    public string tag { get; }

    public SpriteAtlas();

    public bool CanBindTo(Sprite sprite);
    public Sprite GetSprite(string name);
    public int GetSprites(Sprite[] sprites);
    public int GetSprites(Sprite[] sprites, string name);

}

}
