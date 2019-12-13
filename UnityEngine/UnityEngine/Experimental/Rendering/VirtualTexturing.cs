using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public static class VirtualTexturing
{
    static public int AllMips = 2147483647;

    static public bool debugTilesEnabled { get; set; }
    static public bool resolvingEnabled { get; set; }

    static public string[] GetTexturesInTileset(string tileSetPathName);
    static public void RequestRegion(Material mat, int stackNameId, Rect r, int mipMap, int numMips);
    static public void UpdateSystem();
    static public bool ValidateTextureStack(Texture[] textures, out string errorMessage);

}

}
