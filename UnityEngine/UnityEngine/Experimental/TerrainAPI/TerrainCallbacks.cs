using System;
using UnityEngine;

namespace UnityEngine.Experimental.TerrainAPI
{

public static class TerrainCallbacks
{
    static public event HeightmapChangedCallback heightmapChanged;
    static public event TextureChangedCallback textureChanged;

    public delegate void HeightmapChangedCallback(Terrain terrain, RectInt heightRegion, bool synched);

    public delegate void TextureChangedCallback(Terrain terrain, string textureName, RectInt texelRegion, bool synched);

}

}
