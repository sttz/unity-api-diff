using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class Highlighter
{
    static public bool active { get; private set; }
    static public Rect activeRect { get; private set; }
    static public string activeText { get; private set; }
    static public bool activeVisible { get; private set; }

    static public bool Highlight(string windowTitle, string text);
    static public bool Highlight(string windowTitle, string text, UnityEditor.HighlightSearchMode mode);
    static public void HighlightIdentifier(Rect position, string identifier);
    static public void Stop();

    public Highlighter();

}

}
