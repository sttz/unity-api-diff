using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.U2D
{

public class SpriteAtlasManager
{
    static public event Action<U2D.SpriteAtlas> atlasRegistered;
    static public event Action<string, Action<U2D.SpriteAtlas>> atlasRequested;

    public SpriteAtlasManager();

}

}
