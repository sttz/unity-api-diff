using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Sprites
{

public sealed class Packer
{
    static public string kDefaultPolicy;

    static public string[] atlasNames { get; }
    static public string[] Policies { get; }
    static public string SelectedPolicy { get; set; }

    static public Texture2D[] GetAlphaTexturesForAtlas(string atlasName);
    static public void GetAtlasDataForSprite(Sprite sprite, out string atlasName, out Texture2D atlasTexture);
    static public Texture2D[] GetTexturesForAtlas(string atlasName);
    static public void RebuildAtlasCacheIfNeeded(UnityEditor.BuildTarget target);
    static public void RebuildAtlasCacheIfNeeded(UnityEditor.BuildTarget target, bool displayProgressBar);
    static public void RebuildAtlasCacheIfNeeded(UnityEditor.BuildTarget target, bool displayProgressBar, Execution execution);

    public Packer();

    public enum Execution
    {
        Normal = 0,
        ForceRegroup = 1,
    }

}

}
