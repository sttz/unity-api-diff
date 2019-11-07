using System;
using UnityEngine;

namespace UnityEditor.Experimental.TerrainAPI
{

public class CreateTerrainTool : UnityEditor.Experimental.TerrainAPI.TerrainPaintTool<UnityEditor.Experimental.TerrainAPI.CreateTerrainTool>
{
    public CreateTerrainTool();

    public string GetDesc();
    public string GetName();
    public void OnSceneGUI(Terrain terrain, UnityEditor.Experimental.TerrainAPI.IOnSceneGUI editContext);

}

}
