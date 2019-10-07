using System;
using UnityEngine;

namespace UnityEngine
{

public struct TextGenerationSettings
{
    public bool alignByGeometry;
    public Color color;
    public Font font;
    public int fontSize;
    public FontStyle fontStyle;
    public bool generateOutOfBounds;
    public Vector2 generationExtents;
    public HorizontalWrapMode horizontalOverflow;
    public float lineSpacing;
    public Vector2 pivot;
    public bool resizeTextForBestFit;
    public int resizeTextMaxSize;
    public int resizeTextMinSize;
    public bool richText;
    public float scaleFactor;
    public TextAnchor textAnchor;
    public bool updateBounds;
    public VerticalWrapMode verticalOverflow;

    public bool Equals(TextGenerationSettings other);

}

}
