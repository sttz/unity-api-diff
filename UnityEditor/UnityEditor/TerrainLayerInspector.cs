using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class TerrainLayerInspector : UnityEditor.Editor
{
    public TerrainLayerInspector();

    public void ApplyCustomUI(UnityEditor.ITerrainLayerCustomUI customUI, Terrain terrain);
    public bool HasPreviewGUI();
    public void OnInspectorGUI();
    public void OnPreviewGUI(Rect r, GUIStyle background);
    public Texture2D RenderStaticPreview(string assetPath, Object[] subAssets, int width, int height);

}

}
