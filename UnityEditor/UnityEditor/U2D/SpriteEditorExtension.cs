using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D
{

public static class SpriteEditorExtension
{
    static public UnityEditor.GUID GetSpriteID(Sprite sprite);
    static public void SetSpriteID(Sprite sprite, UnityEditor.GUID guid);

}

}