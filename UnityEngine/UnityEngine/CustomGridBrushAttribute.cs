using System;
using UnityEngine;

namespace UnityEngine
{

public class CustomGridBrushAttribute : Attribute
{
    public bool defaultBrush { get; }
    public string defaultName { get; }
    public bool hideAssetInstances { get; }
    public bool hideDefaultInstance { get; }

    public CustomGridBrushAttribute();
    public CustomGridBrushAttribute(bool hideAssetInstances, bool hideDefaultInstance, bool defaultBrush, string defaultName);

}

}
