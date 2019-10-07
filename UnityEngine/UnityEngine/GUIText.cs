using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class GUIText : GUIElement
{
    public TextAlignment alignment { get; set; }
    public TextAnchor anchor { get; set; }
    public Color color { get; set; }
    public Font font { get; set; }
    public int fontSize { get; set; }
    public FontStyle fontStyle { get; set; }
    public float lineSpacing { get; set; }
    public Material material { get; set; }
    public Vector2 pixelOffset { get; set; }
    public bool richText { get; set; }
    public float tabSize { get; set; }
    public string text { get; set; }

    public GUIText();

}

}
