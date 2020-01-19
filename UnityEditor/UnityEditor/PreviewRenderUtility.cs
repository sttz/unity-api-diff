using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class PreviewRenderUtility
{
    static protected GameObject CreateLight();

    public Camera m_Camera;
    public float m_CameraFieldOfView;
    public Light[] m_Light;

    public Color ambientColor { get; set; }
    public Camera camera { get; }
    public float cameraFieldOfView { get; set; }
    public Light[] lights { get; }

    public PreviewRenderUtility();
    public PreviewRenderUtility(bool renderFullScene);
    public PreviewRenderUtility(bool renderFullScene, bool pixelPerfect);

    public void AddSingleGO(GameObject go);
    public void AddSingleGO(GameObject go, bool instantiateAtZero);
    public void BeginPreview(Rect r, GUIStyle previewBackground);
    public void BeginPreviewHDR(Rect r, GUIStyle previewBackground);
    public void BeginStaticPreview(Rect r);
    public void BeginStaticPreviewHDR(Rect r);
    public void Cleanup();
    public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material mat, int subMeshIndex);
    public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties);
    public void DrawMesh(Mesh mesh, Vector3 pos, Quaternion rot, Material mat, int subMeshIndex);
    public void DrawMesh(Mesh mesh, Vector3 pos, Quaternion rot, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties);
    public void DrawMesh(Mesh mesh, Matrix4x4 m, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties, Transform probeAnchor, bool useLightProbe);
    public void DrawMesh(Mesh mesh, Vector3 pos, Quaternion rot, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties, Transform probeAnchor);
    public void DrawMesh(Mesh mesh, Vector3 pos, Quaternion rot, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties, Transform probeAnchor, bool useLightProbe);
    public void DrawMesh(Mesh mesh, Vector3 pos, Vector3 scale, Quaternion rot, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties, Transform probeAnchor, bool useLightProbe);
    public void EndAndDrawPreview(Rect r);
    public Texture EndPreview();
    public Texture2D EndStaticPreview();
    public float GetScaleFactor(float width, float height);
    public GameObject InstantiatePrefabInScene(GameObject prefab);
    public void Render(bool allowScriptableRenderPipeline = false, bool updatefov = true);

}

}
