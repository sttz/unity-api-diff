using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public interface ITerrainLayerCustomUI
{
    public bool OnTerrainLayerGUI(TerrainLayer terrainLayer, Terrain terrain);

}

}
