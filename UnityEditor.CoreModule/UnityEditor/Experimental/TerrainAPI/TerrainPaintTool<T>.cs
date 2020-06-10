using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.TerrainAPI
{

public abstract class TerrainPaintTool<T> : UnityEditor.ScriptableSingleton<T>, UnityEditor.Experimental.TerrainAPI.ITerrainPaintTool
{
    protected TerrainPaintTool();

    public string GetDesc();
    public string GetName();
    public void OnDisable();
    public void OnEnable();
    public void OnEnterToolMode();
    public void OnExitToolMode();
    public void OnInspectorGUI(Terrain terrain, UnityEditor.Experimental.TerrainAPI.IOnInspectorGUI editContext);
    public bool OnPaint(Terrain terrain, UnityEditor.Experimental.TerrainAPI.IOnPaint editContext);
    public void OnSceneGUI(Terrain terrain, UnityEditor.Experimental.TerrainAPI.IOnSceneGUI editContext);

}

}
