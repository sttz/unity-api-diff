using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.TerrainAPI
{

public interface IOnPaint
{
    public float brushSize { get; }
    public float brushStrength { get; }
    public Texture brushTexture { get; }
    public bool hitValidTerrain { get; }
    public RaycastHit raycastHit { get; }
    public Vector2 uv { get; }

    public void Repaint(UnityEditor.Experimental.TerrainAPI.RepaintFlags flags = 1);
    public void RepaintAllInspectors();

}

}
