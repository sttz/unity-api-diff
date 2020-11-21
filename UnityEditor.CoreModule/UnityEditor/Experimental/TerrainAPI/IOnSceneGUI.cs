using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.TerrainAPI
{

public interface IOnSceneGUI
{
    public float brushSize { get; }
    public float brushStrength { get; }
    public Texture brushTexture { get; }
    public bool hitValidTerrain { get; }
    public RaycastHit raycastHit { get; }
    public UnityEditor.SceneView sceneView { get; }

    public void Repaint(UnityEditor.Experimental.TerrainAPI.RepaintFlags flags = 1);

}

}
