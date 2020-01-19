using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public static class SpriteEditorExtension
{
    static public UnityEditor.GUID GetSpriteID(Sprite sprite);
    static public void SetSpriteID(Sprite sprite, UnityEditor.GUID guid);

}

}
