using System;
using UnityEngine;

namespace UnityEditor.Experimental.AssetImporters
{

public struct SpriteImportData
{
    public SpriteAlignment alignment { get; set; }
    public Vector4 border { get; set; }
    public string name { get; set; }
    public System.Collections.Generic.List<Vector2[]> outline { get; set; }
    public Vector2 pivot { get; set; }
    public Rect rect { get; set; }
    public string spriteID { get; set; }
    public float tessellationDetail { get; set; }

}

}
