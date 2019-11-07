using System;
using UnityEngine;

namespace UnityEditor
{

public class SpriteRect
{
    static public UnityEditor.GUID GetSpriteIDFromSerializedProperty(UnityEditor.SerializedProperty sp);

    public SpriteAlignment alignment { get; set; }
    public Vector4 border { get; set; }
    public string name { get; set; }
    public Vector2 pivot { get; set; }
    public Rect rect { get; set; }
    public UnityEditor.GUID spriteID { get; set; }

    public SpriteRect();

}

}
