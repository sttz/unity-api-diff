using System;
using UnityEngine;

namespace UnityEditor.Experimental.AssetImporters
{

public struct TextureGenerationOutput
{
    public string importInspectorWarnings { get; }
    public string[] importWarnings { get; }
    public Sprite[] sprites { get; }
    public Texture2D texture { get; }
    public Texture2D thumbNail { get; }

}

}