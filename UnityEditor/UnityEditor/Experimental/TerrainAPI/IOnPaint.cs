using System;
using UnityEngine;

namespace UnityEditor.Experimental.TerrainAPI
{

public interface IOnPaint
{
    public float brushSize { get; }
    public float brushStrength { get; }
    public Texture brushTexture { get; }
    public Vector2 uv { get; }

    public void Repaint(UnityEditor.Experimental.TerrainAPI.RepaintFlags flags = 1);
    public void RepaintAllInspectors();

}

}