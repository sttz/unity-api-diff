using System;
using UnityEngine;

namespace UnityEditor
{

public class CameraEditor : UnityEditor.Editor
{
    protected Camera previewCamera { get; }
    protected Settings settings { get; }

    public CameraEditor();

    public void OnDestroy();
    public void OnEnable();
    public void OnInspectorGUI();
    public void OnOverlayGUI(Object target, UnityEditor.SceneView sceneView);
    public void OnSceneGUI();

    public sealed class Settings
    {
        static public System.Collections.Generic.IEnumerable<string> ApertureFormatNames { get; }
        static public System.Collections.Generic.IEnumerable<Vector2> ApertureFormatValues { get; }

        static public void DrawCameraWarnings(Camera camera);

        public UnityEditor.SerializedProperty allowDynamicResolution { get; private set; }
        public UnityEditor.SerializedProperty allowMSAA { get; private set; }
        public UnityEditor.SerializedProperty backgroundColor { get; private set; }
        public UnityEditor.SerializedProperty clearFlags { get; private set; }
        public UnityEditor.SerializedProperty cullingMask { get; private set; }
        public UnityEditor.SerializedProperty depth { get; private set; }
        public UnityEditor.SerializedProperty farClippingPlane { get; private set; }
        public UnityEditor.SerializedProperty focalLength { get; private set; }
        public UnityEditor.SerializedProperty fovAxisMode { get; private set; }
        public UnityEditor.SerializedProperty gateFit { get; private set; }
        public UnityEditor.SerializedProperty HDR { get; private set; }
        public UnityEditor.SerializedProperty lensShift { get; private set; }
        public UnityEditor.SerializedProperty nearClippingPlane { get; private set; }
        public UnityEditor.SerializedProperty normalizedViewPortRect { get; private set; }
        public UnityEditor.SerializedProperty occlusionCulling { get; private set; }
        public UnityEditor.SerializedProperty orthographic { get; private set; }
        public UnityEditor.SerializedProperty orthographicSize { get; private set; }
        public UnityEditor.SerializedProperty renderingPath { get; private set; }
        public UnityEditor.SerializedProperty sensorSize { get; private set; }
        public UnityEditor.SerializedProperty stereoConvergence { get; private set; }
        public UnityEditor.SerializedProperty stereoSeparation { get; private set; }
        public UnityEditor.SerializedProperty targetDisplay { get; private set; }
        public UnityEditor.SerializedProperty targetEye { get; private set; }
        public UnityEditor.SerializedProperty targetTexture { get; private set; }
        public UnityEditor.SerializedProperty verticalFOV { get; private set; }

        public Settings(UnityEditor.SerializedObject so);

        public void ApplyModifiedProperties();
        public void DrawBackgroundColor();
        public void DrawClearFlags();
        public void DrawClippingPlanes();
        public void DrawCullingMask();
        public void DrawDepth();
        public void DrawDynamicResolution();
        public void DrawHDR();
        public void DrawMSAA();
        public void DrawMultiDisplay();
        public void DrawNormalizedViewPort();
        public void DrawOcclusionCulling();
        public void DrawProjection();
        public void DrawRenderingPath();
        public void DrawTargetEye();
        public void DrawTargetTexture(bool deferred);
        public void DrawVR();
        public void OnEnable();
        public void Update();

    }

}

}
