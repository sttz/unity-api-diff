using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class MeshPreview : IDisposable
{
    static public string GetInfoString(Mesh mesh);

    public Mesh mesh { get; set; }

    public MeshPreview(Mesh target);

    public void Dispose();
    public void OnPreviewGUI(Rect rect, GUIStyle background);
    public void OnPreviewSettings();
    public Texture2D RenderStaticPreview(int width, int height);

}

}
