using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.TerrainAPI
{

public class PaintTextureTool : UnityEditor.Experimental.TerrainAPI.TerrainPaintTool<UnityEditor.Experimental.TerrainAPI.PaintTextureTool>
{
    public PaintTextureTool();

    public string GetDesc();
    public string GetName();
    public void OnInspectorGUI(Terrain terrain, UnityEditor.Experimental.TerrainAPI.IOnInspectorGUI editContext);
    public bool OnPaint(Terrain terrain, UnityEditor.Experimental.TerrainAPI.IOnPaint editContext);
    public void OnSceneGUI(Terrain terrain, UnityEditor.Experimental.TerrainAPI.IOnSceneGUI editContext);

}

}
