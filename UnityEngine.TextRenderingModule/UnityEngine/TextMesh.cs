using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class TextMesh : Component
{
    public TextAlignment alignment { get; set; }
    public TextAnchor anchor { get; set; }
    public float characterSize { get; set; }
    public Color color { get; set; }
    public Font font { get; set; }
    public int fontSize { get; set; }
    public FontStyle fontStyle { get; set; }
    public float lineSpacing { get; set; }
    public float offsetZ { get; set; }
    public bool richText { get; set; }
    public float tabSize { get; set; }
    public string text { get; set; }

    public TextMesh();

}

}
