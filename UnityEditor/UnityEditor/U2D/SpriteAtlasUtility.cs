using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D
{

public class SpriteAtlasUtility
{
    static public void PackAllAtlases(UnityEditor.BuildTarget target, bool canCancel = true);
    static public void PackAtlases(U2D.SpriteAtlas[] atlases, UnityEditor.BuildTarget target, bool canCancel = true);

    public SpriteAtlasUtility();

}

}
