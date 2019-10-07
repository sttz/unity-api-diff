using System;
using UnityEngine;

namespace UnityEngine.TextCore
{

public struct FaceInfo
{
    public float ascentLine { get; set; }
    public float baseline { get; set; }
    public float capLine { get; set; }
    public float descentLine { get; set; }
    public string familyName { get; set; }
    public float lineHeight { get; set; }
    public float meanLine { get; set; }
    public int pointSize { get; set; }
    public float scale { get; set; }
    public float strikethroughOffset { get; set; }
    public float strikethroughThickness { get; set; }
    public string styleName { get; set; }
    public float subscriptOffset { get; set; }
    public float subscriptSize { get; set; }
    public float superscriptOffset { get; set; }
    public float superscriptSize { get; set; }
    public float tabWidth { get; set; }
    public float underlineOffset { get; set; }
    public float underlineThickness { get; set; }

    public bool Compare(TextCore.FaceInfo other);

}

}
