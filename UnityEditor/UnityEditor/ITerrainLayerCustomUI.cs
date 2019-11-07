using System;
using UnityEngine;

namespace UnityEditor
{

public interface ITerrainLayerCustomUI
{
    public bool OnTerrainLayerGUI(TerrainLayer terrainLayer, Terrain terrain);

}

}
